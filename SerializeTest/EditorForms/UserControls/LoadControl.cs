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
using System.Runtime.Serialization;

namespace EditorForms.UserControls
{

    /// <summary>
    /// A class used for displaying constructors for arbitrary actions and conditionals, creating them
    /// </summary>
    public partial class LoadControl : WarlockEditControl
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

        public override void Clear()
        {
            Dirty = false;
            objectType = null;
            loadedObject = null;
            fieldBinds = null;
            this.flowPanel.Controls.Clear();
            this.labelName.Text = "[None]";
        }

        //Todo: attribute field info instead
        public void LoadNewInstanceOfType(Type genType)
        {
            Clear();
            var instance = FormatterServices.GetUninitializedObject(genType);
            Setup(instance, null);
        }

        public override void LoadObject(object obj, string name = null)
        {
            Clear();
            Setup(obj, name);
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

        public void Setup(object loadedObj, string name)
        {
            this.loadedObject = loadedObj;
            this.objectType = loadedObj.GetType();
            this.labelName.Text = name == null ? objectType.Name : name;

            var fields = objectType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)
                .Where(x => x.GetCustomAttribute<EditorFieldAttribute>() != null).ToArray();

            this.fieldBinds = new FieldBind[fields.Length];

            for (int j = 0; j < fields.Length; j++)
            {
                //var curVal = fields[j].GetValue(loadedObj);

                var pb = new FieldBind(fields[j], loadedObj);

                //TODO: Handle dynamically or with classes
                if (fields[j].FieldType == typeof(bool))
                {
                    AddCheckbox(pb);
                }
                else if (fields[j].FieldType == typeof(string))
                {
                    AddTextBox(pb);
                }
                else if(fields[j].FieldType == typeof(int))
                {
                    AddNumberBox(pb);
                }
                else if (fields[j].FieldType.IsSubclassOf(typeof(Enum)))
                {
                    AddEnumComboBox(pb);
                }
                else
                {
                    Console.WriteLine("Unknown type");
                }
                this.fieldBinds[j] = pb;
            }
        }


        void AddEnumComboBox(FieldBind field)
        {
            string name = field.GetEditorName();
            ComboBox c = new ComboBox();
            c.Name = name + "_TB";

            var names = Enum.GetNames(field.field.FieldType);
            if(names.Length > 0)
            {
                c.Items.AddRange(names);
                c.Text = Enum.GetName(field.field.FieldType, field.GetValue());
                field.GetDataAction = () => {
                    return Enum.Parse(field.field.FieldType, c.Text);
                };
            }
            else
            {
                field.GetDataAction = () => {
                    return Activator.CreateInstance(field.field.FieldType);
                };
            }
           

           
            field.Reverted += (object o) => { c.Text = Enum.GetName(field.field.FieldType, o); };
            //c.TextChanged += (object sender, EventArgs e) =>
            //{
            //    field.data = c.Text;
            //};
            this.flowPanel.Controls.Add(c);
        }

        void AddNumberBox(FieldBind field)
        {
            string name = field.GetEditorName();
            LabeledTextbox c = new LabeledTextbox(name);
            c.Name = name + "_TB";

            c.Text = field.GetValue().ToString();

            field.GetDataAction = () => {
                if (int.TryParse(c.Text, out int r))
                {
                    return r;
                }
                else
                {
                    return 0;
                }
            };
            field.Reverted += (object o) => { c.Text = o.ToString(); };
            //c.TextChanged += (object sender, EventArgs e) =>
            //{
            //    field.data = c.Text;
            //};
            this.flowPanel.Controls.Add(c);
        }


        void AddTextBox(FieldBind field)
        {
            string name = field.GetEditorName();
            LabeledTextbox c = new LabeledTextbox(name);
            c.Name = name + "_TB";

            c.Text = (string)field.GetValue();

            field.GetDataAction = () => { return c.Text; };
            field.Reverted += (object o) => { c.Text = (string)o; };
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
            field.Reverted += (object o) => { c.Checked = (bool)o; };

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

        public override void Apply()
        {
            if (this.loadedObject != null)
            {
                for (int j = 0; j < fieldBinds.Length; j++)
                {
                    fieldBinds[j].Apply();
                }
            }
        }

        //public void ApplyAndLoad(object obj)
        //{
        //    if (this.loadedObject != null)
        //    {
        //        Apply();
        //    }
        //    LoadObject(obj);
        //}


        public void Revert()
        {
            for (int j = 0; j < fieldBinds.Length; j++)
            {
                fieldBinds[j].Revert();
            } 
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            Apply();
        }

        private void buttonRevert_Click(object sender, EventArgs e)
        {
            Revert();
        }
    }

    class FieldBind
    {
        public FieldInfo field;
        object owner = null;
        public object data = null;
        public object def;

        public Func<object> GetDataAction = null;
        public event Action<object> Reverted;

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
                def = data = GetValue();
            }
            catch
            {
                def = data = GetDefault(field.FieldType);
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
            if (GetDataAction != null)
            {
                SetValue(GetDataAction.Invoke());
            }
        }

        public void Revert()
        {
            data = def;
            Reverted?.Invoke(def);
        }

    }

}
