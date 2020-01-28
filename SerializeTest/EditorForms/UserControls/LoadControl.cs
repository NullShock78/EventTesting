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
using SerializeTest.WarlockEditor;

namespace EditorForms.UserControls
{

    /// <summary>
    /// A class used for displaying constructors for arbitrary actions and conditionals, creating them
    /// </summary>
    public partial class LoadControl : UserControl
    {
        object loaded = null;
        public bool Dirty { get; set; } = false;
        Type generatedType = null;
        ParameterBind[] parameters = null;

        //basically there for toolbox stuff
        public LoadControl()
        {
            InitializeComponent();
        }

        //Todo: attribute field info instead
        public LoadControl(Type genType)
        {
            InitializeComponent();

            //if(!genType.IsSubclassOf()) { //throw error }
            this.loaded = null;
            Dirty = false;
            labelName.Text = genType.Name;
            generatedType = genType;
            var parameters = genType.GetConstructors()
               .FirstOrDefault(x => x.GetCustomAttribute<EditorConstructorAttribute>() != null)?.GetParameters();

            this.parameters = new ParameterBind[parameters.Length];
            for (int j = 0; j < parameters.Length; j++)
            {
                //if parameters has ignore, add parameter with default of 

                var pb = new ParameterBind(parameters[j].Name, parameters[j].ParameterType, parameters[j].HasDefaultValue ? parameters[j].RawDefaultValue: null);


                if (pb.type == typeof(bool))
                {
                    AddCheckbox(pb, parameters[j]);
                }
                else if(pb.type == typeof(string))
                {
                    AddTextBox(pb, parameters[j]);
                }
                this.parameters[j] = pb;
            }
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
            var parameters = loadedObj.GetType().GetConstructors()
                .FirstOrDefault(x => x.GetCustomAttribute<EditorConstructorAttribute>() != null)?.GetParameters();

            this.loaded = loadedObj;
            Dirty = false;
            generatedType = loadedObj.GetType();
            labelName.Text = loadedObj.GetType().Name;

            var fields = loadedObj.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .Where(x => x.GetCustomAttribute<LinkToCtorAttribute>() != null);


            List<LoadHelper> linkedParamFields = new List<LoadHelper>();
            foreach (var field in fields)
            {
                string pName = field.GetCustomAttribute<LinkToCtorAttribute>().ParamName;
                var o = field.GetValue(loadedObj);
                linkedParamFields.Add(new LoadHelper(pName, o));
            }
            
            this.parameters = new ParameterBind[parameters.Length];
            for (int j = 0; j < parameters.Length; j++)
            {
                //if parameters has ignore, add parameter with default of 
                var curVal = linkedParamFields.FirstOrDefault(x => x.paramName == parameters[j].Name)?.val;
                var pb = new ParameterBind(parameters[j].Name, parameters[j].ParameterType, curVal);

                if (pb.type == typeof(bool))
                {
                    AddCheckbox(pb, parameters[j], (bool)curVal);
                }
                else if (pb.type == typeof(string))
                {
                    AddTextBox(pb, parameters[j], (string)curVal);
                }
                this.parameters[j] = pb;
            }
        }


        void AddTextBox(ParameterBind parameter, ParameterInfo info, string curval = "")
        {
            LabeledTextbox c = new LabeledTextbox(parameter.Name);
            c.Name = parameter.Name + "_TB";
            c.Text = curval;

            c.TextChanged += (object sender, EventArgs e) =>
            {
                parameter.param = c.Text;
            };
            this.flowPanel.Controls.Add(c);
        }

        void AddCheckbox(ParameterBind parameter, ParameterInfo info, bool curval = false)
        {
            CheckBox c = new CheckBox();
            c.Name = parameter.Name + "_CB";
            c.Text = parameter.Name;
            c.Checked = curval;

            c.CheckedChanged += (object sender, EventArgs e) =>
            {
                parameter.param = c.Checked;
            };
            this.flowPanel.Controls.Add(c);
        }

        public object[] CtorParams()
        {
            return parameters.Select(x => x.param).ToArray();
        }

        public object/*Action*/ Generate()
        {
            return Activator.CreateInstance(generatedType, CtorParams());
        }

    }

    class ParameterBind
    {
        public string Name;
        public object param;
        public Type type;

        /// <summary>
        /// Sets the value to default
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        static object GetDefault(Type t)
        {
            if (t.IsValueType)
            {
                return Activator.CreateInstance(t);
            }
            return null;
        }

        public ParameterBind(string name, Type t, object def = null)
        {
            this.Name = name;
            if (def == null) { this.param = GetDefault(t); }
            else { this.param = def; }
            this.type = t;
        }
    }

}
