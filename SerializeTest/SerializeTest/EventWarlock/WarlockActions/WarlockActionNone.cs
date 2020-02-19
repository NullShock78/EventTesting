using RTCV.CorruptCore.EventWarlock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeTest.EventWarlock.WarlockActions
{
    [Serializable]
    class WarlockActionNone : WarlockAction
    {
        public override void DoAction(Grimoire grimoire)
        {
            
        }
    }
}
