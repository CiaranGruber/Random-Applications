using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCode
{
    /// <summary>
    /// Contains a list with a name and set of items
    /// </summary>
    public class SpecificList
    {
        /// <summary>
        /// Gets or sets the name of the list
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the items in the list
        /// </summary>
        public List<string> Items { get; set; }
    }

    /// <summary>
    /// Contains a list of folders available for the List Randomiser Application
    /// </summary>
    internal enum ListRandomiserFolders
    {
        Main, Lists
    }

    /// <summary>
    /// Contains the code for the list randomiser application including variables, etc
    /// </summary>
    public class ListRandomiserApp
    {
        /// <summary>
        /// Gets the starting list that will be randomised
        /// </summary>
        public SpecificList StartingList { get; private set; }

        /// <summary>
        /// Gets the choices for the lists
        /// </summary>
        public List<string> ListChoices { get; private set; } = new List<string>();

        private static Dictionary<ListRandomiserFolders, string> SaveFolderToLocation = new Dictionary<ListRandomiserFolders, string>
        {
            { ListRandomiserFolders.Main, BaseApplication.SaveFolder + "/List Randomiser" },
            { ListRandomiserFolders.Lists, BaseApplication.SaveFolder + "/List Randomiser/Lists" }
        };

        public ListRandomiserApp()
        {
            // Create the folders if they are missing
            foreach (string saveFolder in SaveFolderToLocation.Values)
            {
                Directory.CreateDirectory(saveFolder);
            }

            // Create basic list of all available lists
            foreach (string folder in Directory.EnumerateDirectories(SaveFolderToLocation[ListRandomiserFolders.Lists]))
            {
                ListChoices.Add(folder);
            }
        }
    }
}
