using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Core.OssCoroutines
{
    class WaitUntil : Yielder
    {
        Func<bool> pred;

        public WaitUntil(Func<bool> predicate)
        {
            this.pred = predicate;
        }

        public override bool Process()
        {
            return pred();
        }
    }
}
