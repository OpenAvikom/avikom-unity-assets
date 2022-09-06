using UnityEngine;
using Avikom.UnityAssets.Events;

namespace Avikom.UnityAssets.Variables
{
    public interface IVariable : IGameEvent
    {
        void Reset();
    }

    [System.Serializable]
    public class VariableBase<T> : GameEvent<T>, IVariable
    {
        public static T TypeDefault = default(T);

        [Multiline]
        public string DeveloperDescription = "";
        public T Value = default(T);

        [SerializeField]
        protected T defaultValue = default(T);

        [SerializeField]
        private bool useDefault = false;
        private bool initialized = false;

        public void OnEnable()
        {
            if (useDefault)
            {
                Reset();
            }
            initialized = true;
        }

        public void Reset()
        {
            Value = defaultValue;
            Raise(Value);
        }

        public void Raise()
        {
            Raise(Value);
        }

        public T GetValue()
        {
            return Value;
        }

        public virtual void SetValue(T value)
        {
            if (Value?.Equals(value) != true)
            {
                Value = (value != null) ? value : default(T);
                Raise(Value);
            }
        }
        public virtual void SetValue(VariableBase<T> value)
        {
            var newVal = (value != null) ? value.Value : default(T);
            SetValue(newVal);
        }

        public void OnValidate()
        {
            Raise(Value);
        }

        public override void RegisterListener(IGameEventListener<T> listener)
        {
            base.RegisterListener(listener);
            if (initialized)
            {
                listener.OnEventRaised(Value);
            }
        }
    }
}
