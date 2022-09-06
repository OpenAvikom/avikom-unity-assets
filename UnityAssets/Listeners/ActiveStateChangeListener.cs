using UnityEngine;
using UnityEngine.Events;

namespace Avikom.UnityAssets.Listeners
{
    public class ActiveStateChangeListener : MonoBehaviour
    {
        public UnityEvent OnEnableEvent;
        public UnityEvent OnDisableEvent;
        void OnEnable()
        {
            OnEnableEvent.Invoke();
        }

        void OnDisable()
        {
            OnDisableEvent.Invoke();
        }
    }
}
