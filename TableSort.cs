using System.Collections.Generic;

namespace Flogex.SortingAllgorithms.TableSort
{
    class TableSort
    {
        public static int[] Sort(IList<int> unsortedCollection)
        {
            int numberOfColumns = unsortedCollection.Count;
            int[] sumOfColumn = new int[numberOfColumns];
            int[] sortedCollection = new int[numberOfColumns];

            for (int x = 0; x < numberOfColumns; x++)
            {
                for (int y = x + 1; y < numberOfColumns; y++)
                {
                    if (unsortedCollection[x] < unsortedCollection[y])
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
