using RTCV.CorruptCore.EventWarlock.WarlockEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTCV.CorruptCore.EventWarlock.WarlockActions
{
    [WarlockEditable("Custom Editor Action", "Custom Editor")]
    [Serializable]
    public class WarlockActionCustomEditor : WarlockAction
    {
        public override void DoAction(Grimoire grimoire)
        {
            Console.WriteLine("Bad joke here");
        }
    }
}
