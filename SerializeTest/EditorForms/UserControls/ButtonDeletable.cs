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
    public partial class ButtonDeletable : UserControl
    {

        public new event EventHandler Click;
        public event EventHandler DeleteClick;

        public new string Text
        {
            get { return buttonItem.Text; }
            set {
                buttonItem.Text = value;
            }
        }
        public ButtonDeletable()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteClick?.Invoke(sender, e);
        }

        private void buttonItem_Click(object sender, EventArgs e)
        {
            this.Click?.Invoke(sender, e);
        }
    }
}
