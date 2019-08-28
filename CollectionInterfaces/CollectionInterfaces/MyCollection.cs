using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInterfaces
{
    class MyCollection<T> : IEnumerable<T>
    {
        T[] items;
        int index;

        public MyCollection()
        {
            items = new T[4];
        }
        public void Add(T item)
        {
            if (index == items.Length)
            {
                T[] temp = items;
                items = new T[items.Length * 2];
                temp.CopyTo(items, 0);
                temp = null;
            }
            items[index] = item;
            index++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int Capacity
        {
            get { return items.Length; }
        }
        public int Count
        {
            get { return index; }
        }
        public T this[int indexPosition]
        {
            set { this.items[indexPosition] = value; }
            get { return this.items[indexPosition]; }
        }
    }

    struct Entry<Tk, Tv>
    {
        private Tk key;
        private Tv value;
        public Entry(Tk key, Tv value)
        {
            this.key = key;
            this.value = value;
        }

        public Tk Key { get => key; set => key = value; }
        public Tv Value { get => value; set => this.value = value; }
    }
    class MyDictionary<TKey, TValue> : IEnumerable<Entry<TKey, TValue>>
    {
        private Entry<TKey, TValue>[] entries;
        int index;

        public MyDictionary()
        {
            entries = new Entry<TKey, TValue>[4];
        }
        public void Add(TKey key, TValue value)
        {
            if (index == entries.Length)
            {
                Entry<TKey, TValue>[] temp = entries;
                entries = new Entry<TKey, TValue>[entries.Length * 2];
                temp.CopyTo(entries, 0);
                temp = null;
            }

            Entry<TKey, TValue> entry = new Entry<TKey, TValue>(key, value);
            entries[index] = entry;
            index++;
        }
        public int Count
        {
            get { return index; }
        }
        public IEnumerator<Entry<TKey, TValue>> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.entries[i];
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public TValue this[TKey key]
        {
            set
            {
                Nullable<Entry<TKey, TValue>> entry = null;
                foreach (Entry<TKey, TValue> item in this.entries)
                {
                    if (item.Key.Equals(key))
                    {
                        entry = item;
                        break;
                    }
                }
                if (entry.HasValue)
                {
                    Entry<TKey, TValue> e = entry.Value;
                    e.Value = value;
                }
                else
                {
                    entries[index] = new Entry<TKey, TValue>(key, value);
                }
            }
            get
            {
                Entry<TKey, TValue>? entry = null;
                foreach (Entry<TKey, TValue> item in this.entries)
                {
                    if (item.Key.Equals(key))
                    {
                        entry = item;
                        break;
                    }
                }
                if (entry.HasValue)
                {
                    return entry.Value.Value;
                }
                else
                    return default(TValue);
            }
        }
    }
}
