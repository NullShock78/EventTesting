using RTCV.CorruptCore;
using RTCV.CorruptCore.EventWarlock;
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
    public partial class AddGrimoireForm : Form
    {
        public string GrimoireName { get; private set; }
        public BlastLayer GrimoireLayer { get; private set; } = null;

        public AddGrimoireForm()
        {
            InitializeComponent();
            //Load blast layers
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text) && Warlock.GetByName(textBoxName.Text) != null)
            {
                MessageBox.Show("Grimoire name already exists", "A", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GrimoireName = textBoxName.Text;                
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.Cancel;
        }
    }
}
