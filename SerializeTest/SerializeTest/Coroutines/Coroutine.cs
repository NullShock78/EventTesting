using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTCV.CorruptCore.Coroutines
{
    //Can probably simplify logic or refactor

    /// <summary>
    /// Class form of a coroutine. Call StartCoroutine() on a <see cref="CoroutineRunner"/> in <see cref="CoroutineEngine"/> to start one
    /// </summary>
    public class Coroutine
    {
        public bool IsComplete { get; protected set; } = false;
        IEnumerator<Yielder> coroutine;
        Yielder currentConditional;
        //CoroutineReturn startable;
        /// <summary>
        /// Used to create a coroutine, must be created
        /// </summary>
        /// <param name="coroutine"></param>
        internal Coroutine(IEnumerator<Yielder> coroutine)
        {
            this.coroutine = coroutine;
            currentConditional = coroutine.Current;
            //startable = null;
        }

        //internal Coroutine(CoroutineReturn coroutine)
        //{
        //    coroutine = null;
        //    this.startable = coroutine;
        //    currentConditional = null;
        //}


        /// <summary>
        /// Stops the coroutine and disposes it
        /// </summary>
        public void Stop()
        {
            IsComplete = true;
            coroutine.Dispose();
        }

        public void DoCycle()
        {
            //if(startable != null)
            //{
            //    coroutine = startable.Invoke();
            //    currentConditional = coroutine.Current;
            //    startable = null;
            //}
            //else 
            if(IsComplete)
            {
                //Do nothing
            }
            else if (currentConditional == null || currentConditional.Process())
            {
                //current conditional can be null if you use yield return null; basically acts as a single cycle skip
                IsComplete = !coroutine.MoveNext();
                currentConditional = coroutine.Current;
            }
        }
    }
}
