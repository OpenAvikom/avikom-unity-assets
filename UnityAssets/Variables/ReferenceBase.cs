using System;

namespace Avikom.UnityAssets.Variables
{
    [Serializable]
    public class ReferenceBase<TVariable, T>
    where TVariable : VariableBase<T>
    {
        public bool UseConstant = true;
        public T ConstantValue;

        public TVariable Variable;

        public ReferenceBase()
        { }

        public ReferenceBase(T value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public T Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public static implicit operator T(ReferenceBase<TVariable, T> reference)
        {
            return reference.Value;
        }
    }
}