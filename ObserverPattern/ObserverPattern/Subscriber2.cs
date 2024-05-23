using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Subscriber2
    {
        public void OnActionTriggered(object source, DataEventArgs args)
        {
            Console.WriteLine($"Subscriber2 got notified... by {args.triggeredBy.Name} who is {args.triggeredBy.Role}");
        }
    }
}
