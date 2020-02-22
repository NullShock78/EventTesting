using RTCV.CorruptCore.EventWarlock;
using RTCV.CorruptCore.EventWarlock.WarlockEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeTest.EventWarlock.WarlockActions
{
    [WarlockEditable("Mega")]
    [Serializable]
    public class WarlockActionMega : WarlockAction
    {
        [EditorField("a")] public string a;
        [EditorField("b")] public string b;
        [EditorField("c")] public string c;
        [EditorField("d")] bool d;

        public WarlockActionMega(string a, string b, string c, bool d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public override void DoAction(Grimoire grimoire)
        {
            
        }
    }
}
