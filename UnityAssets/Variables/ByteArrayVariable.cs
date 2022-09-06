using UnityEngine;

namespace Avikom.UnityAssets.Variables
{
    [CreateAssetMenu(menuName = "Primitive/Variables/ByteArrayVariable")]
    public class ByteArrayVariable : VariableBase<byte[]>
    {
        public static new string TypeDefault = default(string);
    }
}
