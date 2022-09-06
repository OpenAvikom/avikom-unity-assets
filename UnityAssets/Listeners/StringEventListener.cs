using UnityEngine;
using UnityEngine.Events;

using Avikom.UnityAssets.Events;

namespace Avikom.UnityAssets.Listeners
{
    public class StringEventListener : GameEventListener<Events.StringEvent, Events.UnityStringEvent, string> { }
}
