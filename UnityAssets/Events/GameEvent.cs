using System.Collections.Generic;
using UnityEngine;

namespace Avikom.UnityAssets.Events
{
    [CreateAssetMenu(menuName = "Primitive/Events/GameEvent")]
    public class GameEvent : ScriptableObject, IGameEvent
    {
        private readonly List<IGameEventListener> eventListeners =
            new List<IGameEventListener>();

        public void Raise()
        {
            var listeners = new List<IGameEventListener>(eventListeners);
            for (int i = listeners.Count - 1; i >= 0; i--)
                listeners[i].OnEventRaised();
        }

        public void RegisterListener(IGameEventListener listener)
        {
            if (!eventListeners.Contains(listener))
                eventListeners.Add(listener);
        }

        public void UnregisterListener(IGameEventListener listener)
        {
            if (eventListeners.Contains(listener))
                eventListeners.Remove(listener);
        }
    }

    public interface IGameEventListener
    {
        void OnEventRaised();
    }

    public interface IGameEventListener<T>
    {
        void OnEventRaised(T value);
    }

    public interface IGameEvent
    {
        void Raise();
    }

    public class GameEvent<T> : ScriptableObject
    {
        private readonly List<IGameEventListener<T>> eventListeners =
            new List<IGameEventListener<T>>();

        public void Raise(T value)
        {
            var listeners = new List<IGameEventListener<T>>(eventListeners);
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised(value);
            }
        }

        public virtual void RegisterListener(IGameEventListener<T> listener)
        {
            if (!eventListeners.Contains(listener))
                eventListeners.Add(listener);
        }

        public void UnregisterListener(IGameEventListener<T> listener)
        {
            if (eventListeners.Contains(listener))
                eventListeners.Remove(listener);
        }
    }
}
