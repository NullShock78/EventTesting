using RTCV.CorruptCore.EventWarlock;
using SerializeTest.WarlockEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeTest.EventWarlock.WarlockConditions
{
    [Serializable]
    public class FirstEqualsSecond : EWConditional
    {
        [LinkToCtor("a")] string a = "";
        [LinkToCtor("b")] string b = "";

        [EditorConstructor]
        public FirstEqualsSecond(string a, string b)
        {
            this.a = a;
            this.b = b;
        }

        public override bool Evaluate()
        {
            return a == b;
        }
    }
}
