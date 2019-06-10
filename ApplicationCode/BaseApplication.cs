using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCode
{
    /// <summary>
    /// Contains the code for the base application including variables, etc
    /// </summary>
    public class BaseApplication
    {
        /// <summary>
        /// Contains the variable used for randomising values
        /// </summary>
        private Random rand { get; set; }

        /// <summary>
        /// The starting save folder name for the save info
        /// </summary>
        public static readonly string SaveFolder = "./Save Data";

        /// <summary>
        /// Loads the base application by creating relevant folders
        /// </summary>
        public BaseApplication()
        {
            Directory.CreateDirectory(SaveFolder);
        }

        /// <summary>
        /// Returns a non-negative random integer
        /// </summary>
        /// <returns>A non-negative random integer</returns>
        public int GetRandInt()
        {
            return GetRandInt(0, int.MaxValue);
        }

        /// <summary>
        /// Returns a non-negative random integer that is less than the specified maximum
        /// </summary>
        /// <param name="maxValue">The exclusive upper bound of the random number returned</param>
        /// <returns>A non-negative random integer that is less than the specified maximum</returns>
        public int GetRandInt(int maxValue)
        {
            return GetRandInt(0, maxValue);
        }

        /// <summary>
        /// Returns a random integer that is within a specified range
        /// </summary>
        /// <param name="minValue">The inclusive lower bound of the random number returned</param>
        /// <param name="maxValue">The exclusive upper bound of the random number returned. maxValue must be greater than or equal to minValue.</param>
        /// <returns>A random integer that is within a specified range</returns>
        public int GetRandInt(int minValue, int maxValue)
        {
            return rand.Next(minValue, maxValue);
        }
    }
}
