using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Core.OssCoroutines
{
    public abstract class Yielder
    {
        /// <summary>
        /// Implement a yielder. Return true to continue the coroutine.
        /// </summary>
        /// <returns>whether or not to continue</returns>
        public abstract bool Process();
    }
}
