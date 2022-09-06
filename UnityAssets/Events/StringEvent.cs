
#if !UNITY2020_1_OR_NEWER

using UnityEngine;
using UnityEngine.Events;
using System;

namespace Avikom.UnityAssets.Events
{
    [CreateAssetMenu(menuName = "Primitive/Events/StringEvent")]
    [Serializable]
    public class StringEvent : GameEvent<string>
    {
        public void RaiseVariable(Variables.StringVariable variable)
        {
            Raise(variable.Value);
        }
    }
}
#endif
