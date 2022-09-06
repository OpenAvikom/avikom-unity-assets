using UnityEngine;
using UnityEngine.Events;

using Avikom.UnityAssets.Events;

namespace Avikom.UnityAssets.Listeners
{
    public class GameEventListener : MonoBehaviour, IGameEventListener
    {
        [Tooltip("Event to register with.")]
        public GameEvent Event;

        [Tooltip("Response to invoke when Event is raised.")]
        public UnityEvent Response;

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public void OnEventRaised()
        {
            Response.Invoke();
        }
    }

    public abstract class GameEventListener<T> : MonoBehaviour, IGameEventListener<T>
            where T : Events.GameEvent<T>
    {
        [Tooltip("Event to register with.")]
        public T Event;

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public abstract void OnEventRaised(T value);
    }

    public abstract class GameEventListener<TGameEvent, T> : MonoBehaviour, IGameEventListener<T>
        where TGameEvent : Events.GameEvent<T>
    {
        [Tooltip("Event to register with.")]
        public TGameEvent Event;

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public abstract void OnEventRaised(T value);
    }

    public class GameEventListener<TGameEvent, TUnityEvent, T> : MonoBehaviour, IGameEventListener<T>
        where TGameEvent : Events.GameEvent<T>
        where TUnityEvent : UnityEvent<T>
    {
        [Tooltip("Event to register with.")]
        public TGameEvent Event;

        [Tooltip("Response to invoke when Event is raised.")]
        public TUnityEvent Response;

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public virtual void OnEventRaised(T value)
        {
            Response.Invoke(value);
        }
    }
}
