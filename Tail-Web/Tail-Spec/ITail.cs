using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tail_Spec
{
    public interface ITail
    {
        /// <summary>
        /// Start following a file line append.
        /// </summary>
        /// <param name="followCallback"></param>
        void Follow(Action<string> followCallback);

        /// <summary>
        /// Is file being followed
        /// </summary>
        bool IsFollowing { get; }

        /// <summary>
        /// Unfollow the file. This will close the thread safely.
        /// </summary>
        void Unfollow();

        long Bytes(int start = 0);

        string[] Line(int line = 10);

        bool Retry();

        void Sleep(int interval = 1000);
    }
}
