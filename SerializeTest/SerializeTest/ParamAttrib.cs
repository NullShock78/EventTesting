using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeTest
{
    [System.AttributeUsage(AttributeTargets.Parameter, Inherited = false, AllowMultiple = false)]
    sealed class ParamAttribute : Attribute
    {

        // This is a positional argument
        public ParamAttribute(string type)
        {

        }

    }
}
