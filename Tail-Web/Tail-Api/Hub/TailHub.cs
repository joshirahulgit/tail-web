using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Timers;
using Tail_Impl;

namespace Tail_Api
{
    public class TailHub : Hub
    {
        private static Dictionary<string, Tail> tails;
        private static Dictionary<string, int> groupCount;

        static TailHub()
        {
            groupCount = new Dictionary<string, int>();
            groupCount.Add("log1Tail", 0);
            tails = new Dictionary<string, Tail>();
            tails.Add("log1Tail", new Tail(@"C:\rahul\src\Tail-Web\Tail-Web\Tail-Api\test-tail.txt"));
        }

        public TailHub()
        {
        }

        public override Task OnConnected()
        {
            Groups.Add(Context.ConnectionId, "log1Tail");
            groupCount["log1Tail"] = groupCount["log1Tail"] + 1;
            if (!tails["log1Tail"].IsFollowing && groupCount["log1Tail"] > 0)
            {
                tails["log1Tail"].Follow(this.Broadcast);
            }
            return base.OnConnected();
        }

        public override Task OnReconnected()
        {
            return base.OnReconnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            Groups.Remove(Context.ConnectionId, "log1Tail");
            groupCount["log1Tail"] = groupCount["log1Tail"] - 1;
            if (tails["log1Tail"].IsFollowing && groupCount["log1Tail"] < 1)
            {
                tails["log1Tail"].Unfollow();
            }
            return base.OnDisconnected(stopCalled);
        }

        public void Broadcast(string line)
        {
            Clients.Group("log1Tail").Publish(line);
        }
    }

    public class TailBroadcast
    {
        private IHubContext _context;

        private TailBroadcast(IHubContext context)
        {
            _context = context;
        }
    }
}