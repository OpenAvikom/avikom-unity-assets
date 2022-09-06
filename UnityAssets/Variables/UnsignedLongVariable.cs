using UnityEngine;

namespace Avikom.UnityAssets.Variables
{
    [CreateAssetMenu(menuName = "Primitive/Variables/UnsignedLongVariable")]
    public class UnsignedLongVariable : StorableVariable<ulong>
    {
        public override void Load()
        {
            SetValue(System.Convert.ToUInt64(PlayerPrefs.GetString(name, "0")));
        }

        public override void Save(bool writeToDisk = false)
        {
            PlayerPrefs.SetString(name, Value.ToString());
            if (writeToDisk)
            {
                PlayerPrefs.Save();
            }
        }
    }
}
