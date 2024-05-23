using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class SubscriptionManager
    {
        public void ManageSubscriptions()
        {
            Provider provider = new Provider();
            Subscriber1 subscriber1 = new Subscriber1();
            Subscriber2 subscriber2 = new Subscriber2();
            provider.IntitialEvent += subscriber1.OnActionTriggered;
            provider.IntitialEvent += subscriber2.OnActionTriggered;

            provider.TakeAction();
        }
    }
}
