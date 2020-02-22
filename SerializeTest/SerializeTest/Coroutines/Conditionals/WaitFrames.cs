using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTCV.CorruptCore.Coroutines
{
    /// <summary>
    /// Note: will always delay at least one frame
    /// </summary>
    public class WaitFrames : Yielder
    {
        int framesLeft;
        public WaitFrames(int frames = 1)
        {
            framesLeft = frames;
        }

        public override bool Process()
        {
            framesLeft--;
            return (framesLeft <= 0);
        }
    }
}
