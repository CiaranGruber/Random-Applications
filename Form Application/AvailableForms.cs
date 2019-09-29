using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApplication
{
    /// <summary>
    /// Specifies the available forms
    /// </summary>
    public enum Forms
    {
        /// <summary>
        /// Indicates to quit the application
        /// </summary>
        Quit,

        /// <summary>
        /// The form for the main menu
        /// </summary>
        MainMenu,

        /// <summary>
        /// The list randomiser application
        /// </summary>
        ListRandomiser,

        /// <summary>
        /// The modify list function for the randomiser app
        /// </summary>
        ListRandomiser_ModifyList,

        /// <summary>
        /// The settings function for the randomiser app
        /// </summary>
        ListRandomiser_Settings,

        /// <summary>
        /// The form where a temporary list may be added
        /// </summary>
        ListRandomiser_AddTempList
    }

}
