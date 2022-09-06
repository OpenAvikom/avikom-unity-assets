using Avikom.UnityAssets.Variables;
using UnityEngine;

namespace Avikom.UnityAssets.Transformer
{
    public class TextInputSync : MonoBehaviour
    {

        public TMPro.TMP_InputField Text;
        public StringVariable Variable;

        void OnEnable()
        {
            Text.text = Variable.Value;
        }

        public void OnValueChanged()
        {
            Variable.SetValue(Text.text);
        }
    }
}
