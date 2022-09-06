
#if !UNITY2020_1_OR_NEWER

using UnityEngine;
using UnityEngine.Events;
using System;

namespace Avikom.UnityAssets.Events
{
    [CreateAssetMenu(menuName = "Primitive/Events/IntEvent")]
    [Serializable] public class IntEvent : GameEvent<int> { }

    [CreateAssetMenu(menuName = "Primitive/Events/TextureEvent")]
    [Serializable] public class TextureEvent : GameEvent<Texture> { }

    [CreateAssetMenu(menuName = "Primitive/Events/SpriteEvent")]
    [Serializable] public class SpriteEvent : GameEvent<Sprite> { }

}
#endif