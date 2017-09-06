using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tail_Spec
{
    public interface ITail
    {
        void Follow(Action<string> followCallback);

        long Bytes(int start = 0);

        string[] Line(int line = 10);

        bool Retry();

        void Sleep(int interval = 1000);
    }
}
