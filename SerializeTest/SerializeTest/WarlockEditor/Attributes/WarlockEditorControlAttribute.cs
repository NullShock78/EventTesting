using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTCV.CorruptCore.EventWarlock.WarlockEditor
{ 
    [System.AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class WarlockEditorControlAttribute : Attribute
    {
        readonly string name;
        public WarlockEditorControlAttribute(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }

    }

}
