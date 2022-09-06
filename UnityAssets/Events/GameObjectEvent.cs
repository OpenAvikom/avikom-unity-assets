
#if !UNITY2020_1_OR_NEWER

using UnityEngine;
using UnityEngine.Events;
using System;

namespace Avikom.UnityAssets.Events
{
    [CreateAssetMenu(menuName = "Primitive/Events/GameObjectEvent")]
    [Serializable] public class GameObjectEvent : GameEvent<GameObject> { }
}
#endif