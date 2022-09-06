using UnityEngine;
using UnityEngine.Events;

namespace Avikom.UnityAssets.Variables
{
    public class UnityEventRaiser : MonoBehaviour
    {
        public UnityEvent OnEnableEvent;

        public void OnEnable()
        {
            OnEnableEvent.Invoke();
        }
    }
}