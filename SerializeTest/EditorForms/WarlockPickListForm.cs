using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorForms
{
    public partial class WarlockPickListForm : Form
    {
        public Type SelectedType { get; private set; } = null;

        public WarlockPickListForm(string text, List<ComponentInfo> list)
        {
            InitializeComponent();
            this.Text = text;
            for (int j = 0; j < list.Count; j++)
            {
                Button b = new Button();
                b.Text = list[j].Name;
                var t = list[j].type;
                b.Click += (object o, EventArgs e) => {
                    SelectedType = t;
                    DialogResult = DialogResult.OK;
                    Close();
                };
                listPanelItems.AddNoUpdate(b);
            }
            listPanelItems.UpdateList();
        }

        public void Reset()
        {
            DialogResult = DialogResult.None;
            SelectedType = null;
        }

    }
}
