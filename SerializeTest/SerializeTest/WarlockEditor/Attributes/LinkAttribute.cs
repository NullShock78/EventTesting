using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeTest.WarlockEditor
{
    /// <summary>
    /// Used to link parameters to constructor arguments for the editor
    /// </summary>
    [System.AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    public sealed class LinkToCtorAttribute : Attribute
    {
        readonly string paramName;
        public LinkToCtorAttribute(string paramName)
        {
            this.paramName = paramName;
        }

        public string ParamName
        {
            get { return paramName; }
        }

    }
}
