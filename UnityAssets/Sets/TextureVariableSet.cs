using System.Collections.Generic;
using UnityEngine;

namespace Avikom.UnityAssets.Sets
{
    [CreateAssetMenu(menuName = "Primitive/Sets/TextureVariableSet")]
    public class TextureVariableSet : RuntimeSet<Variables.TextureVariable> { }
    public class TextureVariableList : List<Variables.TextureVariable> { }
}
