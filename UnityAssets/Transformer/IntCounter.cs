using Avikom.UnityAssets.Variables;
using UnityEngine;

namespace Avikom.UnityAssets.Transformer
{
    public class IntCounter : MonoBehaviour
    {
        public IntReference Max;
        public IntReference Min;
        public IntReference Mod = new IntReference(int.MaxValue);
        public IntVariable Target;

        public void Increase()
        {
            var newValue = (Target.Value + 1);
            if (Mod.Value > 0)
            {
                newValue %= Mod.Value;
            }
            if (newValue <= Max.Value)
            {
                Target.SetValue(newValue);
            }
        }

        public void Decrease()
        {
            var newValue = Target.Value - 1;
            if (newValue >= Min.Value)
            {
                Target.SetValue(newValue);
            }
        }
    }
}
