using RTCV.CorruptCore.Coroutines;
using RTCV.CorruptCore.EventWarlock.WarlockEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTCV.CorruptCore.EventWarlock.WarlockActions
{
    [Serializable]
    internal enum CoroutineToAddToTest
    {
        PreExecute = 0,
        Execute = 1,
        PostExecute = 2
    }

    [WarlockEditable("Coroutine Test")]
    [Serializable]
    public class WarlockActionCoroutineTest : WarlockAction
    {
        [EditorField("Message")] private string message = "Message";
        [EditorField("Frame Delay")] public int frameDelay = 0;
        [EditorField("Coroutine To Add To")] CoroutineToAddToTest AddToThis;

        public override void DoAction(Grimoire grimoire)
        {
            switch (AddToThis)
            {
                case CoroutineToAddToTest.PreExecute:
                    CoroutineEngine.PreExecute.StartCoroutine(Routine(grimoire));
                    break;
                case CoroutineToAddToTest.Execute:
                    CoroutineEngine.Execute.StartCoroutine(Routine(grimoire));
                    break;
                case CoroutineToAddToTest.PostExecute:
                    CoroutineEngine.PostExecute.StartCoroutine(Routine(grimoire));
                    break;
                default:
                    break;
            }

        }

        private IEnumerator<Yielder> Routine(Grimoire grimoire)
        {
            if (frameDelay > 0)
            {
                yield return new WaitFrames(frameDelay);
            }
            Console.WriteLine(message);
            yield break;
        }
    }
}
