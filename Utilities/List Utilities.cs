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
    }
}
