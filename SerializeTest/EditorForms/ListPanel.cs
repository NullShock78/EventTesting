using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorForms
{
    internal partial class ListPanel : UserControl
    {
        public List<Control> Items = new List<Control>();
        //private bool internalUpdate = false;

        //private void ListPanel_ControlRemoved(object sender, ControlEventArgs e)
        //{
        //    if (!internalUpdate)
        //    {
        //        Items.Remove(e.Control);
        //        UpdateList();
        //    }
        //}

        public void SetScrollHeight()
        {
            this.VerticalScroll.LargeChange = 1;
            this.VerticalScroll.SmallChange = 1;
            this.VerticalScroll.Maximum = 100;
        }

        public List<T> ItemsAsT<T>() where T : Control
        {
            return Items.Cast<T>().ToList();
        }

        public void UpdateList()
        {
            //internalUpdate = true;
            SuspendLayout();
            Controls.Clear();
            for (int j = Items.Count - 1; j >= 0; j--)
            {
                Controls.Add(Items[j]);
            }
            ResumeLayout();
            //internalUpdate = false;
        }

        public void Remove(string cname)
        {
            //internalUpdate = true;
            Items.RemoveAll(c => c.Text.Equals(cname));
            UpdateList();
            //internalUpdate = false;

        }

        public void Remove(Control c)
        {
            //internalUpdate = true;
            Items.Remove(c);
            UpdateList();
            //internalUpdate = false;
        }

        public void Add(Control c)
        {
            c.Dock = DockStyle.Top;
            Items.Add(c);
            UpdateList();
        }

        public void AddNoUpdate(Control c)
        {
            c.Dock = DockStyle.Top;
            Items.Add(c);
        }


        public void AddRange(Control[] c)
        {
            for (int j = 0; j < c.Length; j++)
            {
                c[j].Dock = DockStyle.Top;
                Items.Add(c[j]);
            }
            UpdateList();
        }

        public void AddRange(List<Control> c)
        {
            for (int j = 0; j < c.Count; j++)
            {
                c[j].Dock = DockStyle.Top;
                Items.Add(c[j]);
            }
            UpdateList();
        }

        public void RemoveLast()
        {
            if (Items.Count > 0)
            {
                Items.RemoveAt(Items.Count - 1);
                UpdateList();
            }
        }

        public void Clear()
        {
            Items.Clear();
            Controls.Clear();
        }
        public void AddToTop(Control c)
        {
            Items.Insert(0, c);
            UpdateList();
        }
        public void AddToTopNoUpdate(Control c)
        {
            Items.Insert(0, c);
        }

        public void MoveToBottom(Control c)
        {
            Items.Remove(c);
            Items.Add(c);
            UpdateList();
        }

        public void MoveToTop(Control c)
        {
            Items.Remove(c);
            Items.Insert(0, c);
            UpdateList();
        }

        public void ClearExcept(params Control[] c)
        {
            var cs = Items.Where(x => object.ReferenceEquals(x, c));
            Items.Clear();
            Controls.Clear();
            AddRange(c);
        }

        public ListPanel()
        {
            InitializeComponent();
            this.AutoScroll = true;
            SetScrollHeight();
            //this.ControlRemoved += ListPanel_ControlRemoved;

        }

    }
}
