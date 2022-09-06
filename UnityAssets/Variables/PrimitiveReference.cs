using System;
using UnityEngine;

namespace Avikom.UnityAssets.Variables
{
    [Serializable]
    public class StringReference : ReferenceBase<StringVariable, string> { }

    [Serializable]
    public class FloatReference : ReferenceBase<FloatVariable, float> { }

    [Serializable]
    public class IntReference : ReferenceBase<IntVariable, int>
    {
        public IntReference(int c) : base(c) { }
    }

    [Serializable]
    public class Vector3Reference : ReferenceBase<Vector3Variable, Vector3> { }

    [Serializable]
    public class SpriteReference : ReferenceBase<SpriteVariable, Sprite> { }

    [Serializable]
    public class BoolReference : ReferenceBase<BoolVariable, bool> { }
}
