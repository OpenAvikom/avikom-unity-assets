using System;
using UnityEngine;

namespace Avikom.UnityAssets.Events
{
    [CreateAssetMenu(menuName = "Primitive/Events/BoolEvent")]
    [Serializable] public class BoolEvent : GameEvent<bool> { }
}