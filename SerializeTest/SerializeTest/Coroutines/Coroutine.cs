using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Core.OssCoroutines
{
    //using IEnumerator = IEnumerator<CoroutineConditional>;

    public class Coroutine
    {
        //False of movenext means done;
        public bool IsComplete { get; protected set; } = false;
        public bool Paused { get; protected set; } = false;
        IEnumerator<Yielder> coroutine;
        Yielder currentConditional;
        public Coroutine(IEnumerator<Yielder> coroutine)
        {
            this.coroutine = coroutine;
            Paused = false;
            currentConditional = coroutine.Current;
        }

        public void Pause(bool pause = true)
        {
            Paused = pause;
        }

        public void Unpause()
        {
            Paused = false;
        }

        public void Stop()
        {
            currentConditional = null;
            IsComplete = true;
        }

        public void DoCycle()
        {
            if(IsComplete || Paused)
            {
                //Do nothing
            }
            else if (currentConditional == null || currentConditional.Process())
            {
                IsComplete = !coroutine.MoveNext();
                currentConditional = coroutine.Current;
            }
        }
    }
}
