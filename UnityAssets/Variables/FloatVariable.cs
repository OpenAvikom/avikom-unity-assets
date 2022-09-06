using UnityEngine;

namespace Avikom.UnityAssets.Variables
{
    [CreateAssetMenu(menuName = "Primitive/Variables/FloatVariable")]
    public class FloatVariable : StorableVariable<float>
    {
        public override void Load()
        {
            SetValue(PlayerPrefs.GetFloat(name, defaultValue));
        }

        public override void Save(bool writeToDisk = false)
        {
            PlayerPrefs.SetFloat(name, Value);
            if (writeToDisk)
            {
                PlayerPrefs.Save();
            }
        }
    }
}
