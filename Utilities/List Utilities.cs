using System;
using System.Collections;
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
            for (int i = 0; i < originalList.Count / 2; ++i)
            {
                originalList.SwapValues(i, originalList.Count - 1 - i);
            }
            return originalList;
        }

        /// <summary>
        /// Swaps two values in a list between each other
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="originalList">The list that is being modified</param>
        /// <param name="firstIndex">The index of the first item to swap</param>
        /// <param name="secondIndex">The index of the second item to swap</param>
        /// <returns>The list with the two swapped values</returns>
        public static IList<T> SwapValues<T>(this IList<T> originalList, int firstIndex, int secondIndex)
        {
            T firstItem = originalList[firstIndex];
            originalList[firstIndex] = originalList[secondIndex];
            originalList[secondIndex] = firstItem;
            return originalList;
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
            // Attempt efficient movement when capacity is not an issue
            try
            {
                // Accounts for the deletion of the old item
                if (newIndex > oldIndex) newIndex++;

                originalList.Insert(newIndex, originalList[oldIndex]);

                originalList.RemoveAt(newIndex >= oldIndex ? oldIndex : oldIndex + 1);
            }

            // If list is fixed capacity, use inefficient method
            catch (NotSupportedException)
            {
                // Negate effect of failed attempt
                if (newIndex > oldIndex) newIndex--;

                // Swaps values until entire list is swapped
                if (oldIndex >= newIndex)
                {
                    for (int i = oldIndex; i > newIndex; --i)
                    {
                        originalList.SwapValues(i, i - 1);
                    }
                }
                else
                {
                    for (int i = oldIndex; i < newIndex; ++i)
                    {
                        originalList.SwapValues(i, i + 1);
                    }
                }
            }
        }

        /// <summary>
        /// Finds anythings size. If it is not an IEnumerable it will set it to -1
        /// </summary>
        /// <param name="theObject">The object to be measured</param>
        /// <returns></returns>
        public static int GetObjSize(this object theObject)
        {
            // Return size of -1 if it is not a list
            if (theObject as IEnumerable == null || theObject is string) return -1;
            
            // Otherwise return the size of the object
            return ((IEnumerable)theObject).Cast<object>().ToArray().Length;
        }

        /// <summary>
        /// Returns whether two values are equals. Contents are measured when objects are IEnumerables
        /// </summary>
        /// <param name="object1">The first object to compare</param>
        /// <param name="object2">The second object to compare</param>
        /// <returns>Whether the two object's values are equal</returns>
        public static bool ContentEquals(this object object1, object object2)
        {
            int objectSize1 = object1.GetObjSize();
            object[] convertedObject1;
            object[] convertedObject2;

            // Test for null
            if (object1 == null || object2 == null) return object1 == object2;

            // Test types
            if (object1.GetType() != object2.GetType()) return false;

            // Test sizes of objects
            if (objectSize1 != object2.GetObjSize()) return false;
            
            // If object is not an IEnumerable, return Equals value
            if (objectSize1 == -1) return object1.Equals(object2);
            
            // Get converted objects
            convertedObject1 = ((IEnumerable)object1).Cast<object>().ToArray();
            convertedObject2 = ((IEnumerable)object2).Cast<object>().ToArray();

            // Test each interior value
            for (int i = 0; i < objectSize1; i++)
            {
                if (!ContentEquals(convertedObject1[i], convertedObject2[i])) return false;
            }
            return true;
        }

        /// <summary>Returns a human readable version of any IEnumerables or other objects</summary>
        /// <param name="itemOrList">The item or list to convert</param>
        /// <returns>A human readable version of any IEnumerables or other objects</returns>
        public static string ToReadableString(this object itemOrList)
        {
            string currentString = "";
            int size = GetObjSize(itemOrList);

            // If object is a list
            if (size > -1)
            {
                // Encapsulate list in []
                currentString += "[";
                for (int i = 0; i < size; i++)
                {
                    // Get interior of list
                    currentString += ((IEnumerable)itemOrList).Cast<object>().ToList()[i].ToReadableString();
                    if (i < size - 1) currentString += ", ";
                }
                currentString += "]";
            }

            // If object is not a list
            else
            {
                // Encapsulate object in either "" or ''
                if (itemOrList is string) currentString += "\"";
                else if (itemOrList is char) currentString += "'";

                // Gets object as a string
                currentString += itemOrList.ToString();

                if (itemOrList is string) currentString += "\"";
                else if (itemOrList is char) currentString += "'";
            }
            return currentString;
        }

        /// <summary>
        /// Determines whether a sequence contains any values from a list of specified elements by using the default equality comparer
        /// </summary>
        /// <typeparam name="T">The type of the list</typeparam>
        /// <param name="primaryList">The list containing the main values</param>
        /// <param name="valuesList">The list containing the values to locate</param>
        /// <returns>Whether the <c>encapsultingList</c> contains any of the <c>checkingList</c> values</returns>
        public static bool ContainsAny<T>(this IEnumerable<T> primaryList, IEnumerable<T> valuesList)
        {
            foreach (T value in valuesList)
            {
                if (primaryList.Contains(value)) return true;
            }
            return false;
        }
    }
}
