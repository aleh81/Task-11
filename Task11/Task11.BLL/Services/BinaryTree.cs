using System;
using System.Collections.Generic;
using System.Collections;

namespace Task11.BLL.Services
{
    public sealed class BinaryTree<T> : ICollection<T> where T : IComparable<T>
    {
        public T Item { get; private set; }

        public T Left { get; set; }

        public T Right { get; set; }

        public T Parent { get; set; }

        //public T this[int index]
        //{
        //    get
        //    {
        //        return Data[index];
        //    }
        //    set
        //    {
        //        Data[index] = value;
        //    }
        //}
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            if(Item == null /*|| Item == item*/)
            {
                Item = item;

                return;
            }
            if(Item.CompareTo(item) > 0)
            {

            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(var i = 0; i< Data.Length; i++)
            {
                yield return Data[i];
            }
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
