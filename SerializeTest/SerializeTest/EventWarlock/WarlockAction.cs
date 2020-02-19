using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTCV.CorruptCore.EventWarlock
{
    [Serializable]
    public abstract class WarlockAction
    {
        //Add param data in subclasses
        public abstract void DoAction(Grimoire grimoire);
    }
}
