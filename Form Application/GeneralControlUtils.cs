using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace FormUtilities
{
    /// <summary>
    /// Contains utilities code for the general control class
    /// </summary>
    public static class GeneralControlUtils
    {
        /// <summary>
        /// Reverses the control collection in the controls
        /// </summary>
        /// <param name="originalCollection">The control collection to be reversed</param>
        public static void Reverse(this ControlCollection originalCollection)
        {
            List<Control> newControlCollection = new List<Control>();
            foreach (Control control in originalCollection)
            {
                newControlCollection.Insert(0, control);
            }
            originalCollection.Clear();
            originalCollection.AddRange(newControlCollection.ToArray());
        }

        /// <summary>
        /// Replaces a specific index in a control collection
        /// </summary>
        /// <param name="originalCollection">The collection that is being modified</param>
        /// <param name="newControl">The new control to replace the old control</param>
        /// <param name="indexToReplace">The index to be replaced</param>
        public static void Replace(this ControlCollection originalCollection, Control newControl, int indexToReplace)
        {
            Control newCollectionControl = new Control();
            for (int i = 0; originalCollection.Count > 1 || i == indexToReplace; i++)
            {
                if (i == indexToReplace)
                {
                    newCollectionControl.Controls.Add(newControl);
                }
                else
                {
                    newCollectionControl.Controls.Add(originalCollection[0]);
                }
            }

            originalCollection.Clear();
            originalCollection.AddRange(newCollectionControl.Controls.ToArray());
        }

        /// <summary>
        /// Copies the elements of the <c>ControlCollection</c> to a new array
        /// </summary>
        /// <param name="controlCollection">The control collection to copy from</param>
        /// <returns>A list containing all controls</returns>
        public static Control[] ToArray(this ControlCollection controlCollection)
        {
            return controlCollection.ToList().ToArray();
        }

        /// <summary>
        /// Copies the elements of the <c>ControlCollection</c> to a new list
        /// </summary>
        /// <param name="controlCollection">The control collection to copy from</param>
        /// <returns>A list containing all controls</returns>
        public static List<Control> ToList(this ControlCollection controlCollection)
        {
            List<Control> controlList = new List<Control>();
            foreach (Control control in controlCollection)
            {
                controlList.Add(control);
            }
            return controlList;
        }
    }
}
