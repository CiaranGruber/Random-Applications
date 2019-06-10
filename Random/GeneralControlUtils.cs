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
        /// <param name="originalControlCollection">The control collection to be reversed</param>
        public static void Reverse(this ControlCollection originalControlCollection)
        {
            List<Control> newControlCollection = new List<Control>();
            foreach (Control control in originalControlCollection)
            {
                newControlCollection.Insert(0, control);
            }
            originalControlCollection.Clear();
            originalControlCollection.AddRange(newControlCollection.ToArray());
        }
    }
}
