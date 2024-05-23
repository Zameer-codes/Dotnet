using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Subscriber1
    {
        public void OnActionTriggered(object source, DataEventArgs args)
        {
            Console.WriteLine($"Subcriber1 got notified... by {args.triggeredBy.Name} who is {args.triggeredBy.Role}");
        }
    }
}
