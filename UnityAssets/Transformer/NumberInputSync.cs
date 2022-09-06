using Avikom.UnityAssets.Variables;
using UnityEngine;

namespace Avikom.UnityAssets.Transformer
{
    public class NumberInputSync : MonoBehaviour
    {
        public TMPro.TMP_InputField Text;
        public IntVariable Variable;

        void OnEnable()
        {
            Text.text = Variable.Value.ToString();
        }

        public void OnValueChanged()
        {
            try
            {
                Variable.SetValue(int.Parse(Text.text));
            }
            catch (System.FormatException)
            {
                Text.text = Variable.Value.ToString();
            }
        }
    }
}
