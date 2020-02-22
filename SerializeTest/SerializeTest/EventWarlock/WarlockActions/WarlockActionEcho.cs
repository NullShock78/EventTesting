using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RTCV.CorruptCore.EventWarlock.WarlockEditor;

namespace RTCV.CorruptCore.EventWarlock.WarlockActions
{
    /// <summary>
    /// Example action
    /// </summary>
    [WarlockEditable("Echo")]
    [Serializable]
    public class WarlockActionEcho : WarlockAction
    {
        [EditorField("data")] string Data = null;

        public WarlockActionEcho() { }

        public WarlockActionEcho(string data)
        {
            Data = data;
        }

        public override void DoAction(Grimoire grimoire)
        {
            Console.WriteLine("Repeating: " + Data);
        }
    }
}
