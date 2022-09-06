
#if !UNITY2020_1_OR_NEWER

using UnityEngine;
using UnityEngine.Events;
using System;

namespace Avikom.UnityAssets.Events
{
    [Serializable] public class UnityStringEvent : UnityEvent<string> { }
    [Serializable] public class UnityBoolEvent : UnityEvent<bool> { }
    [Serializable] public class UnityIntEvent : UnityEvent<int> { }
    [Serializable] public class UnityTextureEvent : UnityEvent<Texture> { }
    [Serializable] public class UnitySpriteEvent : UnityEvent<Sprite> { }
    [Serializable] public class UnityGameObjectEvent : UnityEvent<GameObject> { }
    [Serializable] public class UnityVideoClipEvent : UnityEvent<UnityEngine.Video.VideoClip> { }

}
#endif