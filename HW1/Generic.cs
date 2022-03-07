using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW1
{
    internal class Generic<T>
    {
        private T[] _data = Array.Empty<T>();

        public int Count
        {
            get
            {
                return _data.Length;
            }
        }

        public T this[int index]
        {
            get
            {
                return _data[index];
            }
            set
            {
                _data[index] = value;
            }
        }

        public void Add(T value)
        {
            T[] newData = new T[_data.Length + 1];
            for (int i = 0; i < _data.Length; i++)
            {
                newData[i] = _data[i];
            }

            newData[_data.Length] = value;
            _data = newData;
        }

        public T[] AddRange(T[] collection)
        {
            int index = 0;
            T[] newData = new T[_data.Length + collection.Length];
            for (int i = 0; i < _data.Length; i++)
            {
                newData[i] = _data[i];
            }

            for (int i = _data.Length; i < newData.Length; i++)
            {
                newData[i] = collection[index];
                ++index;
            }

            _data = newData;
            return _data;
        }

        public bool Remove(T value)
        {
            bool result = false;
            int index = 0;
            T[] newData = new T[_data.Length - 1];
            for (int i = 0; i < _data.Length; i++)
            {
                if (_data[i].Equals(value))
                {
                    result = true;
                    continue;
                }
                else
                {
                    newData[index] = _data[i];
                    ++index;
                }
            }

            return result;
        }

        public void RemoveAt(int index)
        {
            int indexCycle = 0;
            T[] newData = new T[_data.Length - 1];
            for (int i = 0; i < _data.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                else
                {
                    newData[indexCycle] = _data[i];
                    ++indexCycle;
                }
            }
        }

        public void Sort()
        {
            for (int i = 0; i < _data.Length; i++)
            {
                for (int j = i + 1; j < _data.Length; j++)
                {
                    if (Comparer<T>.Default.Compare(_data[j], _data[j + 1]) > 0)
                    {
                        var value = _data[j + 1];
                        _data[j + 1] = _data[j];
                        _data[j] = value;
                    }
                }
            }
        }

        public IEnumerable<T> GetData()
        {
            for (int i = 0; i < _data.Length; i++)
            {
                yield return _data[i];
            }
        }
    }
}
