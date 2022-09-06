using UnityEngine;

namespace Avikom.UnityAssets.Variables
{
    [CreateAssetMenu(menuName = "Primitive/Variables/IntVariable")]
    public class IntVariable : StorableVariable<int>
    {
        public override void Load()
        {
            SetValue(PlayerPrefs.GetInt(name, defaultValue));
        }

        public override void Save(bool writeToDisk = false)
        {
            PlayerPrefs.SetInt(name, Value);
            if (writeToDisk)
            {
                PlayerPrefs.Save();
            }
        }
    }
}
