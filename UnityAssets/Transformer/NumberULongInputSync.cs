using Avikom.UnityAssets.Variables;
using UnityEngine;
using System;

namespace Avikom.UnityAssets.Transformer
{
    public class NumberULongInputSync : MonoBehaviour
    {
        public TMPro.TMP_InputField Text;
        public UnsignedLongVariable Variable;

        void OnEnable()
        {
            Text.text = Variable.Value.ToString();
        }

        public void OnValueChanged()
        {
            try
            {
                Variable.SetValue(UInt64.Parse(Text.text));
            }
            catch (FormatException)
            {
                Text.text = Variable.Value.ToString();
            }
        }
    }
}
