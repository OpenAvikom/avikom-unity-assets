using UnityEngine;

namespace Avikom.UnityAssets.Listeners
{
    public class BoolVariableListener : VariableListener<Variables.BoolVariable, Events.UnityBoolEvent, bool>
    {
        public Events.UnityBoolEvent NegativeResponse;

        public override void OnEventRaised(bool value)
        {
            Response?.Invoke(value);
            NegativeResponse?.Invoke(!value);
        }
    };
}
