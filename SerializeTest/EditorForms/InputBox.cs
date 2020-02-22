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
    public partial class InputBox : Form
    {
        public string Data { get; private set; } = null;

        public InputBox(string title = "Input", string varName = "Name")
        {
            InitializeComponent();
            Text = title;
            labelVal.Text = varName;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Data = textBoxData.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.Cancel;
        }
    }
}
