using UnityEngine;
using System;

namespace Avikom.UnityAssets.Variables
{
    public class EnumVariable<T> : VariableBase<T> where T : System.Enum
    {

        public void SetValue(Enum value)
        {
            base.SetValue((T)value);
        }

        public bool Is(T target)
        {
            return Value.Equals(target);
        }
    }
}
