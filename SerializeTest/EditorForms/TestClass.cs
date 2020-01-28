using SerializeTest.WarlockEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorForms
{
    class TestClass
    {
        //Linked to load
        [LinkToCtor("a")] string aa;
        [LinkToCtor("b")] bool bb;
        [LinkToCtor("c")] bool cc;
        [LinkToCtor("d")] string dd;

        [EditorConstructor]
        public TestClass(string a, bool b, bool c, string d)
        {
            aa = a;
            bb = b;
            cc = c;
            dd = d;
        }

        public override string ToString()
        {
            return $"TestClass:{{aa: {aa}, bb: {bb}, cc: {cc}, dd: {dd}}}";
        }
    }
}
