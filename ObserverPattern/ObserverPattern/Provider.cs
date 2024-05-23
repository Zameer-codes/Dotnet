using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Provider
    {
        public event EventHandler<DataEventArgs> IntitialEvent;
        public void TakeAction()
        {
            //Data to be notified to all subscribers
            TriggeredByModel triggeredBy = new TriggeredByModel()
            {
                Name = "Zameer",
                Role = "Admin"
            };

            Console.WriteLine("Provider did an action...");
            OnActionTriggered(triggeredBy);//Triggering event
        }
        protected virtual void OnActionTriggered(TriggeredByModel triggeredBy)
        {
            if(IntitialEvent != null)
                IntitialEvent(this, new DataEventArgs() {triggeredBy = triggeredBy});//Initiating Event with custom args
        }
    }

    //Event Args Custom Model
    public class DataEventArgs : EventArgs
    {
        public TriggeredByModel triggeredBy { get; set; }
    }
}
