using UnityEngine;
using UnityEngine.Events;

namespace Avikom.UnityAssets.Listeners
{
    class StringEqualityChecker : MonoBehaviour
    {
        public string Target = default(string);
        public Events.UnityBoolEvent Response;

        public void Compare(string value)
        {
            Response?.Invoke(value.Equals(Target));
        }
    };
}
