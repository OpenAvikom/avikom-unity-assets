using System.Collections.Generic;
using UnityEngine;

namespace Avikom.UnityAssets.Sets
{
    public class RuntimeSet<T> : Events.GameEvent<List<T>>, IRuntimeSet
        where T : ScriptableObject
    {
        [Multiline]
        public string DeveloperDescription = "";

        public List<T> Items = new List<T>();

        [SerializeField]
        private List<T> defaultValue = new List<T>();

        [SerializeField]
        private bool useDefault = false;


        public int Count => Items.Count;

        public void OnEnable()
        {
            if (useDefault)
            {
                Items.Clear();
                Items.AddRange(defaultValue);
            }
        }

        public void Add(T thing)
        {
            if (!Items.Contains(thing))
            {
                Items.Add(thing);
            }
        }

        public void SetValue(List<T> things)
        {
            Items.Clear();
            foreach (var item in things)
            {
                Add(item);
            }
            Raise();
        }

        public void Remove(T thing)
        {
            if (Items.Contains(thing))
            {
                Items.Remove(thing);
            }
        }

        public void Raise()
        {
            Raise(Items);
        }

        public void Clear()
        {
            Items.Clear();
        }

        public void OnValidate()
        {
            Raise();
        }
    }

    public interface IRuntimeSet
    {
        void Clear();
    }
}