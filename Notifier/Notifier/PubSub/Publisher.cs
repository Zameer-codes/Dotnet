using System;

namespace Notifier.PubSub
{
    public class Publisher
    {
        public event EventHandler<Subscriber> DataReady;

        public void GenerateData()
        {
            string message = "User created"; // Your custom message
            OnDataReady(new Subscriber(message));
        }

        protected virtual void OnDataReady(Subscriber e)
        {
            DataReady?.Invoke(this, e);
        }
    }
}
