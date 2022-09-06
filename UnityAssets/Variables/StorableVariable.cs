namespace Avikom.UnityAssets.Variables
{
    public interface IStorableVariable : IVariable
    {
        void Save(bool writeToDisk = false);
        void Load();
    }

    [System.Serializable]
    public abstract class StorableVariable<T> : VariableBase<T>, IStorableVariable
    {
        public abstract void Load();
        public abstract void Save(bool writeToDisk = false);
    }
}
