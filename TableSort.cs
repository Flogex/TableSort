using System;
using System.Collections.Generic;

namespace Flogex.SortingAllgorithms
{
    class TableSort<T> where T:IComparable
    {
        public static T[] Sort(IList<T> unsortedCollection)
        {
            int numberOfColumns = unsortedCollection.Count;
            int[] sumOfColumn = new int[numberOfColumns];
            T[] sortedCollection = new T[numberOfColumns];

            for (int x = 0; x < numberOfColumns; x++)
            {
                for (int y = x + 1; y < numberOfColumns; y++)
                {
                    if (unsortedCollection[x].CompareTo(unsortedCollection[y]) < 0)
                    {
                        sumOfColumn[y] += 1;
                    }
                    else
                    {
                        sumOfColumn[x] += 1;
                    }
                }
                sortedCollection[sumOfColumn[x]] = unsortedCollection[x];
            }
            return sortedCollection;
        }
    }
}
