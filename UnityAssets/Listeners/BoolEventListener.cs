using Avikom.UnityAssets.Events;

namespace Avikom.UnityAssets.Listeners
{
    public class BoolEventListener : GameEventListener<BoolEvent, UnityBoolEvent, bool>
    {
        public Events.UnityBoolEvent NegativeResponse;

        public override void OnEventRaised(bool value)
        {
            Response.Invoke(value);
            NegativeResponse.Invoke(!value);
        }
    };
}
