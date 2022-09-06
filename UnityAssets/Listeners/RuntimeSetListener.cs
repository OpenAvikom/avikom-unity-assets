using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

using Avikom.UnityAssets.Events;

namespace Avikom.UnityAssets.Listeners
{
    public class RuntimeSetListener<TSet, TEvent, T> : MonoBehaviour, IGameEventListener<List<T>>
        where T : ScriptableObject
        where TSet : Sets.RuntimeSet<T>
        where TEvent : UnityEvent<List<T>>
    {
        public TSet Set;

        public TEvent Response;
        private void OnEnable()
        {
            Set.RegisterListener(this);
            OnEventRaised(Set.Items);
        }

        private void OnDisable()
        {
            Set.UnregisterListener(this);
        }

        public virtual void OnEventRaised(List<T> values)
        {
            Response.Invoke(values);
        }
    }

    public abstract class RuntimeSetListener<TSet, T> : MonoBehaviour, IGameEventListener<List<T>>
    where T : ScriptableObject
    where TSet : Sets.RuntimeSet<T>
    {
        public TSet Set;

        private void OnEnable()
        {
            Set.RegisterListener(this);
            OnEventRaised(Set.Items);
        }

        private void OnDisable()
        {
            Set.UnregisterListener(this);
        }

        public abstract void OnEventRaised(List<T> values);
    }
}
