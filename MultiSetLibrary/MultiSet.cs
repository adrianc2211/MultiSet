using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace MultiSetLibrary
{
    public class MultiSet<T> : IMultiSet<T>
    {

        //wewnętrzna reprezentacja
        private Dictionary<T, int> mset = new Dictionary<T, int>();
        //KONSTRUKTOEY

        #region --------- ctor's

        public MultiSet()
        {

        }

        #endregion
        public override string ToString()
        {
            StringBuilder wynik = new StringBuilder();
            foreach (var (klucz,wartosc) in mset) { wynik.Append($"{klucz}: {wartosc}, "); }
                
            return wynik.ToString(0, wynik.Length-2);
        }

        public bool IsEmpty => mset.Count ==0;
        public bool IsReadOnly => false;
        public void Clear() => mset.Clear();
        public void Add(T item)
        {
            if (mset.ContainsKey(item))
            {
                mset[item]++;
            }
            else
            {
                mset.Add(item, 1);
            }
        }

        public IMultiSet<T> Add(T item, int numberOfItems = 1)
        {
            while (numberOfItems-- > 0)
             {
                 Add(item);
             }
            return this;
        }


        public int this[T item] => throw new NotImplementedException();



        public IEqualityComparer<T> Comparer => throw new NotImplementedException();

        public int Count => mset.Values.Sum();



       
        

        public IReadOnlyDictionary<T, int> AsDictionary()
        {
            throw new NotImplementedException();
        }

        public IReadOnlySet<T> AsSet()
        {
            throw new NotImplementedException();
        }


        public bool Contains(T item) => mset.ContainsKey(item);

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IMultiSet<T> ExceptWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IMultiSet<T> IntersectWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsProperSubsetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsProperSupersetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsSubsetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsSupersetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool MultiSetEquals(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool Overlaps(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public IMultiSet<T> Remove(T item, int numberOfItems = 1)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public IMultiSet<T> RemoveAll(T item)
        {
            throw new NotImplementedException();
        }

        public IMultiSet<T> SymmetricExceptWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public IMultiSet<T> UnionWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
