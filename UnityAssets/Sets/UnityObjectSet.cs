using System.Collections.Generic;
using Avikom.UnityAssets.Variables;
using UnityEngine;

namespace Avikom.UnityAssets.Sets
{
    [CreateAssetMenu(menuName = "Primitive/Sets/VariableSet")]
    public class UnityObjectSet : RuntimeSet<UnityObjectVariable> { }
    public class VariableList : List<UnityObjectVariable> { }
}
