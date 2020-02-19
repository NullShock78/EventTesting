using RTCV.CorruptCore.EventWarlock.WarlockEditor;
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
        [EditorField("a")] string aa;
        [EditorField("b")] bool bb;
        [EditorField("c")] bool cc;
        [EditorField("d")] string dd;

        public TestClass() { }

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
