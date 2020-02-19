using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTCV.CorruptCore.EventWarlock
{
    abstract class WarlockDoubleAction : WarlockAction
    {

        public abstract void ExecutePost();

        internal override void ActionPost()
        {
            Warlock.PostExecActions.Add(this);
        }
    }
}
