using RTCV.CorruptCore.EventWarlock;
using RTCV.CorruptCore.EventWarlock.WarlockEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTCV.CorruptCore.EventWarlock.WarlockConditions
{
    [Serializable]
    public class FirstEqualsSecond : EWConditional
    {
        [EditorField("a")] string a = "";
        [EditorField("b")] string b = "";

        public FirstEqualsSecond() { }

        public FirstEqualsSecond(string a, string b)
        {
            this.a = a;
            this.b = b;
        }

        public override bool Evaluate(Grimoire grimoire)
        {
            return a == b;
        }
    }
}
