using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeTest.WarlockEditor
{

    [System.AttributeUsage(AttributeTargets.Constructor, Inherited = false, AllowMultiple = false)]
    public sealed class EditorConstructorAttribute : Attribute
    {
        public EditorConstructorAttribute()
        {
        }
    }
}
