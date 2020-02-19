using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using RTCV.CorruptCore.EventWarlock.WarlockEditor;

namespace EditorForms.UserControls
{

    /// <summary>
    /// A class used for displaying constructors for arbitrary actions and conditionals, creating them
    /// </summary>
    public partial class LoadControl : UserControl
    {
        object loadedObject = null;
        public bool Dirty { get; set; } = false;
        Type objectType = null;
        FieldBind[] fieldBinds = null;

        //basically there for toolbox stuff
        public LoadControl()
        {
            InitializeComponent();
        }

        //Todo: attribute field info instead
        public LoadControl(Type genType)
        {
            InitializeComponent();
            var instance = Activator.CreateInstance(genType);
            Setup(instance);
        }

        private class LoadHelper 
        {
            public string paramName;
            public object val;
            public LoadHelper(string p, object val)
            {
                paramName = p;
                this.val = val;
            }        
        }

        public LoadControl(object loadedObj)
        {
            InitializeComponent();
            Setup(loadedObj);
        }

        public void Setup(object loadedObj)
        {
            this.loadedObject = loadedObj;
            this.objectType = loadedObj.GetType();
            this.labelName.Text = objectType.Name;

            var fields = objectType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)
                .Where(x => x.GetCustomAttribute<EditorFieldAttribute>() != null).ToArray();

            this.fieldBinds = new FieldBind[fields.Length];

            for (int j = 0; j < fields.Length; j++)
            {
                //var curVal = fields[j].GetValue(loadedObj);

                var pb = new FieldBind(fields[j], loadedObj);

                //TODO: Handle dynamically?
                if (fields[j].FieldType == typeof(bool))
                {
                    AddCheckbox(pb);
                }
                else if (fields[j].FieldType == typeof(string))
                {
                    AddTextBox(pb);
                }
                else
                {
                    Console.WriteLine("Unknown type");
                }
                this.fieldBinds[j] = pb;
            }
        }

        void AddTextBox(FieldBind field)
        {
            string name = field.GetEditorName();
            LabeledTextbox c = new LabeledTextbox(name);
            c.Name = name + "_TB";

            c.Text = (string)field.GetValue();

            field.GetDataAction = () => { return c.Text; };

            //c.TextChanged += (object sender, EventArgs e) =>
            //{
            //    field.data = c.Text;
            //};
            this.flowPanel.Controls.Add(c);
        }

        void AddCheckbox(FieldBind field)
        {
            string name = field.GetEditorName();
            CheckBox c = new CheckBox();
            c.Name = name + "_CB";
            c.Text = name;
            c.Checked = (bool)field.GetValue();

            field.GetDataAction = () => { return c.Checked; };

            //c.CheckedChanged += (object sender, EventArgs e) =>
            //{
            //    field.data = c.Checked;
            //};
            this.flowPanel.Controls.Add(c);
        }

        //public object[] CtorParams()
        //{
        //    return parameters.Select(x => x.data).ToArray();
        //}

        public object/*Action*/ Apply()
        {
            for (int j = 0; j < fieldBinds.Length; j++)
            {
                fieldBinds[j].Apply();
            }

            return loadedObject;
        }

    }

    class FieldBind
    {
        public FieldInfo field;
        object owner = null;
        public object data = null;

        public Func<object> GetDataAction = null;

        static object GetDefault(Type t)
        {
            if (t.IsValueType)
            {
                return Activator.CreateInstance(t);
            }
            return null;
        }

        public FieldBind(FieldInfo f, object owner)
        {
            this.field = f;
            this.owner = owner;

            try
            {
                data = GetValue();
            }
            catch
            {
                data = GetDefault(field.FieldType);
            }
        
        }

        public string GetEditorName()
        {
            return this.field.GetCustomAttribute<EditorFieldAttribute>().FieldName;
        }

        public void SetValue(object val)
        {
            this.field.SetValue(owner, val);
        }

        public object GetValue()
        {
            return this.field.GetValue(owner);
        }

        public void Apply()
        {
            SetValue(GetDataAction.Invoke());
        }

    }

}
