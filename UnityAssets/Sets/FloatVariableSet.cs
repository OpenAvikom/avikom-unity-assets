using System.Collections.Generic;
using UnityEngine;

namespace Avikom.UnityAssets.Sets
{
    [CreateAssetMenu(menuName = "Primitive/Sets/FloatVariableSet")]
    public class FloatVariableSet : RuntimeSet<Variables.FloatVariable> { }
    public class FloatVariableList : List<Variables.FloatVariable> { }
}
