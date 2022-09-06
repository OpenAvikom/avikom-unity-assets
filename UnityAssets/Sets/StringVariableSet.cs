using System.Collections.Generic;
using UnityEngine;

namespace Avikom.UnityAssets.Sets
{
    [CreateAssetMenu(menuName = "Primitive/Sets/StringVariableSet")]
    public class StringVariableSet : RuntimeSet<Variables.StringVariable> { }
    public class StringVariableList : List<Variables.StringVariable> { }
}
