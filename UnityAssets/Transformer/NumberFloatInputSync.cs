using Avikom.UnityAssets.Variables;
using UnityEngine;
using System;

namespace Avikom.UnityAssets.Transformer
{
    public class NumberFloatInputSync : MonoBehaviour
    {
        public TMPro.TMP_InputField Text;
        public FloatVariable Variable;
        public float MinValue;
        public float MaxValue;

        void OnEnable()
        {
            Text.text = Variable.Value.ToString();
        }

        public void OnValueChanged()
        {
            try
            {
                var value = float.Parse(Text.text);
                value = (value < MinValue) ? MinValue : (value > MaxValue) ? MaxValue : value;
                Variable.SetValue(value);
            }
            catch (FormatException)
            {
            }
            Text.text = Variable.Value.ToString();
        }
    }
}
