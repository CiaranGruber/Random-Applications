using FormUtilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApplication.ListRandomiser
{
    static class ListRandomiserUtils
    {
        /// <summary>
        /// Gets the base panel without the move up or move down buttons
        /// </summary>
        /// <param name="listIndex">The list index of the list option</param>
        /// <returns>The base panel without Move Up or Move Down buttons</returns>
        public static Panel GetBasePanel(string optionName, int listIndex)
        {
            Panel overallPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 30
            };

            Label optionNameLabel = new Label
            {
                Dock = DockStyle.Fill,
                Text = optionName,
                TextAlign = ContentAlignment.MiddleLeft
            };

            Button removeOption = new Button
            {
                Text = "Remove",
                Width = 100,
                Dock = DockStyle.Right,
                Name = listIndex.ToString()
            };

            overallPanel.Controls.Add(optionNameLabel);
            overallPanel.Controls.Add(removeOption);

            return overallPanel;
        }

        /// <summary>
        /// Adds a Move Up button to the control with the appropriate list index
        /// </summary>
        /// <param name="control">The control to add the Move Up button to</param>
        /// <param name="listIndex">The list index of the list option</param>
        public static void AddMoveUpButton(this Control control, int listIndex)
        {
            control.Controls.Add(GetMoveUpButton(listIndex));
        }

        /// <summary>
        /// Adds a Move Up button to the control with the appropriate list index
        /// </summary>
        /// <param name="control">The control to add the Move Up button to</param>
        /// <param name="listIndex">The list index of the list option</param>
        public static void AddMoveDownButton(this Control control, int listIndex)
        {
            control.Controls.Add(GetMoveDownButton(listIndex));
        }

        /// <summary>
        /// Adds a padding panel equivalent to the width of the moveUp and moveDown buttons
        /// </summary>
        /// <param name="control">The control to add the padding panel to</param>
        public static void AddPaddingPanel(this Control control)
        {
            control.Controls.Add(GetPaddingPanel());
        }

        /// <summary>
        /// Replaces a padding panel with a Move Up button
        /// </summary>
        /// <param name="control">The control to in which the padding panel is changed</param>
        /// <param name="listIndex">The index of the item in the list</param>
        public static void PaddingToUpButton(this Control control, int listIndex)
        {
            control.Controls.Replace(2, GetMoveUpButton(listIndex));
        }

        /// <summary>
        /// Replaces a padding panel with a Move Down button
        /// </summary>
        /// <param name="control">The control to in which the padding panel is changed</param>
        /// <param name="listIndex">The index of the item in the list</param>
        public static void PaddingToDownButton(this Control control, int listIndex)
        {
            control.Controls.Replace(3, GetMoveDownButton(listIndex));
        }

        /// <summary>
        /// Converts the up button to a padding panel
        /// </summary>
        /// <param name="control">The control to in which the up button is changed</param>
        public static void UpButtonToPadding(this Control control)
        {
            control.Controls.Replace(2, GetPaddingPanel());
        }

        /// <summary>
        /// Converts the down button to a padding panel
        /// </summary>
        /// <param name="control">The control to in which the up button is changed</param>
        public static void DownButtonToPadding(this Control control)
        {
            control.Controls.Replace(3, GetPaddingPanel());
        }

        /// <summary>
        /// Gets a Move Up Button with the specific values
        /// </summary>
        /// <param name="listIndex">The index for the button name</param>
        /// <returns>A Move Up button</returns>
        private static Button GetMoveUpButton(int listIndex)
        {
            Button moveUp = new Button
            {
                Text = "↑",
                Width = 35,
                Dock = DockStyle.Right,
                Name = listIndex.ToString()
            };

            return moveUp;
        }

        /// <summary>
        /// Gets a Move Down Button with the specific values
        /// </summary>
        /// <param name="listIndex">The index for the button name</param>
        /// <returns>A Move Up button</returns>
        private static Button GetMoveDownButton(int listIndex)
        {
            Button moveDown = new Button
            {
                Text = "↓",
                Width = 35,
                Dock = DockStyle.Right,
                Name = listIndex.ToString()
            };

            return moveDown;
        }

        /// <summary>
        /// Gets a padding panel with equivalent widths to the up and down buttons
        /// </summary>
        /// <returns></returns>
        private static Panel GetPaddingPanel()
        {
            Panel paddingPanel = new Panel
            {
                Width = 35,
                Dock = DockStyle.Right
            };

            return paddingPanel;
        }
    }
}
