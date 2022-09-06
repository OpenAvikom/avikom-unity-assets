using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

namespace Avikom.UnityAssets.Listeners
{
    public class ForwardListElement<TSet, TItemEvent, T> : RuntimeSetListener<TSet, T>
        where T : ScriptableObject
        where TSet : Sets.RuntimeSet<T>
        where TItemEvent : UnityEvent<T>
    {
        public int Index;
        public TItemEvent ItemResponse;
        public override void OnEventRaised(List<T> values)
        {
            if (values.Count > Index)
            {
                ItemResponse.Invoke(values[Index]);
            }
        }
    }
}
