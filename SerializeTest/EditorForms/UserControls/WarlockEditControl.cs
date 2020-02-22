using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorForms.UserControls
{
    public abstract class WarlockEditControl : UserControl
    {
        public abstract void Apply();
        public abstract void LoadObject(object o, string name = null);
        public abstract void Clear();
    }
}
