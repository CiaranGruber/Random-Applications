using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralUtilities;
using ApplicationCode.Exceptions;

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

        /// <summary>
        /// Initialises a new <c>SpecificList</c> with a set name
        /// </summary>
        /// <param name="name">Name of the list</param>
        public SpecificList(string name)
        {
            Name = name;
            Items = new List<string>();
        }

        /// <summary>
        /// Initialises an existing <c>SpecificList</c> from a set of parameters
        /// </summary>
        /// <param name="name">Name of the list</param>
        /// <param name="items">Items in the list</param>
        public SpecificList(string name, List<string> items)
        {
            Name = name;
            Items = items;
        }
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
        /// Gets the current list being used
        /// </summary>
        public SpecificList CurrentList { get; private set; }

        /// <summary>
        /// Gets the list of availble lists for preloading
        /// </summary>
        public List<string> ListsAvailable { get; private set; } = new List<string>();

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
                ListsAvailable.Add(folder);
            }
            
            // Set current list to default
            CurrentList = new SpecificList(GetDefaultName());
        }
        
        /// <summary>
        /// Changes the name of the current list
        /// </summary>
        /// <param name="newName">The new name of the list</param>
        public void ChangeName(string newName)
        {
            CurrentList.Name = newName;
        }

        /// <summary>
        /// Adds an item to the current list
        /// </summary>
        /// <param name="itemName">The name of the new item</param>
        public void AddItem(string itemName)
        {
            CurrentList.Items.Add(itemName);
        }

        /// <summary>
        /// Removes an item at a specific index
        /// </summary>
        /// <param name="itemIndex">The index of the item to remove</param>
        public void RemoveItem(int itemIndex)
        {
            CurrentList.Items.RemoveAt(itemIndex);
        }

        /// <summary>
        /// Moves an item up in the list
        /// </summary>
        /// <param name="itemIndex">The index of the item to be moved</param>
        public void MoveUp(int itemIndex)
        {
            CurrentList.Items.MoveItem(itemIndex, itemIndex - 1);
        }

        /// <summary>
        /// Moves an item down in the list
        /// </summary>
        /// <param name="itemIndex">The index of the item to be moved</param>
        public void MoveDown(int itemIndex)
        {
            CurrentList.Items.MoveItem(itemIndex, itemIndex + 1);
        }

        /// <summary>
        /// Chooses a list choice from the available lists
        /// </summary>
        /// <param name="listChoice">Name of the list</param>
        /// <exception cref="ListDoesNotExistException">Thrown if the list does not exist</exception>
        public void ChooseList(string listChoice)
        {
            if (!ListsAvailable.Contains(listChoice))
            {
                throw new ListDoesNotExistException("The list chosen is not available");
            }

            CurrentList = new SpecificList(listChoice, File.ReadAllLines(SaveFolderToLocation[ListRandomiserFolders.Lists] + "/" + listChoice).ToList());
        }

        private string GetDefaultName()
        {
            string defaultName = "Unnamed List ";
            int i = 1;

            while (ListsAvailable.Contains(defaultName + i))
            {
                i++;
            }
            return defaultName + i;
        }
    }
}
