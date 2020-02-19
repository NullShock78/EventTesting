using RTCV.CorruptCore.Coroutines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTCV.CorruptCore.EventWarlock.WarlockActions
{
    [Serializable]
    public class WarlockActionCoroutineTest : WarlockAction
    {

        public WarlockActionCoroutineTest() { }

        public override void DoAction(Grimoire grimoire)
        {
            CoroutineEngine.PostExecute.StartCoroutine(PostExecRoutine(grimoire));
        }

        private IEnumerator<Yielder> PostExecRoutine(Grimoire grimoire)
        {
            Console.WriteLine("Does this break?");
            yield break;
        }
    }
}
