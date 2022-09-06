using UnityEngine;
using UnityEngine.Events;

using Avikom.UnityAssets.Events;

namespace Avikom.UnityAssets.Listeners
{
    public class VariableListener<TVariable, TEvent, T> : MonoBehaviour, IGameEventListener<T>
        where TVariable : Variables.VariableBase<T>
        where TEvent : UnityEvent<T>
    {
        public TVariable Variable;
        public TEvent Response;

        protected virtual void OnEnable()
        {
            Variable.RegisterListener(this);
            OnEventRaised(Variable.Value);
        }

        protected virtual void OnDisable()
        {
            Variable.UnregisterListener(this);
        }

        public virtual void OnEventRaised(T value)
        {
            Response?.Invoke(value);
        }
    }

    public abstract class VariableListener<TVariable, T> : MonoBehaviour, IGameEventListener<T>
    where TVariable : Variables.VariableBase<T>
    {
        public TVariable Variable;

        private void OnEnable()
        {
            Variable.RegisterListener(this);
            OnEventRaised(Variable.Value);
        }

        private void OnDisable()
        {
            Variable.UnregisterListener(this);
        }

        public abstract void OnEventRaised(T value);
    }
}
