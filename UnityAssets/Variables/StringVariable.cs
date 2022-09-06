using UnityEngine;

namespace Avikom.UnityAssets.Variables
{
    [CreateAssetMenu(menuName = "Primitive/Variables/StringVariable")]
    public class StringVariable : StorableVariable<string>
    {
        public override void Load()
        {
            SetValue(PlayerPrefs.GetString(name, defaultValue));
        }

        public override void Save(bool writeToDisk = false)
        {
            PlayerPrefs.SetString(name, Value);
            if (writeToDisk)
            {
                PlayerPrefs.Save();
            }
        }
    }
}
