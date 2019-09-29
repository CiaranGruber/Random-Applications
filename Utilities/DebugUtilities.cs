using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralUtilities
{
    public static class DebugUtilities
    {
        /// <summary>
        /// Returns a message using a specific number to determine parts of the message
        /// </summary>
        /// <param name="testName">The name of the test</param>
        /// <param name="testNumber">The number used in the test</param>
        /// <param name="expected">The expected value to be returned</param>
        /// <param name="actual">The actual value that was returned</param>
        /// <returns>A string containing a message for failed test</returns>
        public static string FailedAssertMessage(string testName, int testNumber, object expected, object actual)
        {
            string message = "\nTest: " + testName + "\n";
            message += "Iteration: " + testNumber + "\n";

            message += "\nExpected:\n";
            message += expected.ToString() + "\n";

            message += "\nActual:\n";
            message += actual.ToString();

            return message;
        }

        /// <summary>
        /// Returns a message for the failed assert function
        /// </summary>
        /// <param name="testName">The name of the test</param>
        /// <param name="expected">The expected value to be returned</param>
        /// <param name="actual">The actual value that was returned</param>
        /// <returns>A string containing a message for failed test</returns>
        public static string FailedAssertMessage(string testName, object expected, object actual)
        {
            string message = "\n" + testName + ":\n";

            message += "\nExpected:\n";
            message += expected.ToString() + "\n";

            message += "\nActual\n";
            message += actual.ToString();

            return message;
        }
    }
}
