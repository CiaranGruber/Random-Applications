using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCode.Exceptions
{
    /// <summary>The exception that is thrown when a list does not exist</summary>
    [Serializable]
    public class ListDoesNotExistException : Exception
    {
        /// <summary>Initialises a new instance of the <c>ListDoesNotExistException</c> class</summary>
        public ListDoesNotExistException()
        {
        }

        /// <summary>Initialises a new instance of the <c>ListDoesNotExistException</c> class with a message</summary>
        /// <param name="message">The error message that explains the reason for the exception</param>
        public ListDoesNotExistException(string message)
            : base(message)
        {
        }

        /// <summary>Initialises a new instance of the <c>ListDoesNotExistException</c> class with a message and a reference to the inner exception that is the cause of this error</summary>
        /// <param name="message">The error message that explains the reason for the exception</param>
        /// <param name="inner">The exception that is the cause of this exception. If the inner parameter is not a null reference (Nothing in Visual Basic), the current exception is raised in a catch block that handles the inner exception</param>
        public ListDoesNotExistException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    /// <summary>The exception that is thrown when a list name is already taken</summary>
    [Serializable]
    public class ListNameTakenException : Exception
    {
        /// <summary>Initialises a new instance of the <c>ListNameTakenException</c> class</summary>
        public ListNameTakenException()
        {
        }

        /// <summary>Initialises a new instance of the <c>ListNameTakenException</c> class with a message</summary>
        /// <param name="message">The error message that explains the reason for the exception</param>
        public ListNameTakenException(string message)
            : base(message)
        {
        }

        /// <summary>Initialises a new instance of the <c>ListNameTakenException</c> class with a message and a reference to the inner exception that is the cause of this error</summary>
        /// <param name="message">The error message that explains the reason for the exception</param>
        /// <param name="inner">The exception that is the cause of this exception. If the inner parameter is not a null reference (Nothing in Visual Basic), the current exception is raised in a catch block that handles the inner exception</param>
        public ListNameTakenException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
