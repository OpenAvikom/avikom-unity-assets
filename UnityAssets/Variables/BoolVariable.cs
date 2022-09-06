using UnityEngine;

namespace Avikom.UnityAssets.Variables
{
    [CreateAssetMenu(menuName = "Primitive/Variables/BoolVariable")]
    public class BoolVariable : StorableVariable<bool>
    {
        public override void Load()
        {
            SetValue(PlayerPrefs.GetInt(name, defaultValue ? 1 : 0) != 0);
        }

        public override void Save(bool writeToDisk = false)
        {
            PlayerPrefs.SetInt(name, Value ? 1 : 0);
            if (writeToDisk)
            {
                PlayerPrefs.Save();
            }
        }
    }
}
