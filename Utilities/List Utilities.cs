using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralUtilities
{
    /// <summary>
    /// Contains a variety of different utilities made for the list
    /// </summary>
    public static class ListUtilities
    {
        /// <summary>
        /// Returns the reversed version of a list
        /// </summary>
        /// <typeparam name="T">The type for the original list</typeparam>
        /// <param name="originalList">The original list</param>
        /// <returns>A new list that has been reversed</returns>
        public static IList<T> Reverse<T>(this IList<T> originalList)
        {
            IList<T> newList = new List<T>();
            for (int i = originalList.Count - 1; i >= 0; i--)
            {
                newList.Add(originalList[i]);
            }
            return newList;
        }

        /// <summary>
        /// Moves an item in a list from one index to another
        /// </summary>
        /// <typeparam name="T">The type of the IList</typeparam>
        /// <param name="originalList">The list to be modified</param>
        /// <param name="oldIndex">The original index of the item</param>
        /// <param name="newIndex">The new index for the item</param>
        public static void MoveItem<T>(this IList<T> originalList, int oldIndex, int newIndex)
        {
            originalList.Insert(newIndex, originalList[oldIndex]);

            if (newIndex >= oldIndex)
            {
                originalList.RemoveAt(oldIndex);
            }
            else
            {
                originalList.RemoveAt(oldIndex + 1);
            }
        }
    }
}
