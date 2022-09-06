using System.Collections.Generic;
using UnityEngine;
using Avikom.UnityAssets.Variables;

namespace Avikom.UnityAssets.Listeners
{
    public class ForwardListSize<TSet, T> : RuntimeSetListener<TSet, T>
        where T : ScriptableObject
        where TSet : Sets.RuntimeSet<T>
    {
        public IntVariable Size;
        public override void OnEventRaised(List<T> values)
        {
            Size.SetValue(values.Count);
        }
    }
}
