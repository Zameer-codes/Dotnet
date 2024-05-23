using System;

namespace Notifier.PubSub
{
    public class Subscriber : EventArgs
    {
        public string Message { get; }

        public Subscriber(string message)
        {
            Message = message;
        }
    }
}
