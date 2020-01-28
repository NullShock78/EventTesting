using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorForms.UserControls
{
    public partial class LabeledTextbox : UserControl
    {

        public new EventHandler TextChanged;
        public new string Text { get { return textBoxData.Text; } set { textBoxData.Text = value; } }
        public LabeledTextbox(string name)
        {
            InitializeComponent();
            labelName.Text = name;
            textBoxData.TextChanged += TextBox1_TextChanged;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.TextChanged?.Invoke(sender, e);
        }
    }
}
