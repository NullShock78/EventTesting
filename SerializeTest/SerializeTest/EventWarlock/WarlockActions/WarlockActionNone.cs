using RTCV.CorruptCore.EventWarlock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeTest.EventWarlock.WarlockActions
{
    [Serializable]
    public class WarlockActionNone : WarlockAction
    {
        static int z = 0;
        public override void DoAction(Grimoire grimoire)
        {
            int x = 3;
            int y = x + 4;
            z += y;
        }
    }
}
