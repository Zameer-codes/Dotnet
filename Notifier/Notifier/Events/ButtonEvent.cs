namespace Notifier.Events
{
    public static class TriggerEvent
    {
        public static void RequestedToTriggerEvent()
        {
            Button button = new Button();
            button.ButtonEvent = (s, args) =>
            {
                Console.WriteLine("Event Raised");
            };
            button.RaiseEvent();
        }
    }
    public class Button
    {
        public EventHandler ButtonEvent;
        public void RaiseEvent()
        {
            ButtonEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
