using RTCV.CorruptCore.EventWarlock;
using SerializeTest.WarlockEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeTest.EventWarlock.WarlockActions
{
    public class WarlockActionMega : WarlockAction
    {
        [LinkToCtor("a")] string a;
        [LinkToCtor("b")] string b;
        [LinkToCtor("c")] string c;
        [LinkToCtor("d")] bool d;

        [EditorConstructor]
        public WarlockActionMega(string a, string b, string c, bool d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public override void DoAction()
        {
            
        }
    }
}
