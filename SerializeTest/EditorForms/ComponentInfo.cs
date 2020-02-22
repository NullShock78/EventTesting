using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorForms
{
    public struct ComponentInfo
    {
        public string Name;
        public Type type;

        public ComponentInfo(string name, Type type)
        {
            Name = name;
            this.type = type;
        }
    }
}
