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
    internal enum ListRandomiserFolder
    {
        Main, ListsFromMain,
        SettingsFromMain
    }

    /// <summary>
    /// Contains the code for the list randomiser application including variables, etc
    /// </summary>
    public class ListRandomiserApp
    {
        /// <summary>
        /// Contains the list used when rolling, etc
        /// </summary>
        private SpecificList TempList { get; set; }

        /// <summary>
        /// Contains the last rolled item in case for when a reroll occurs
        /// </summary>
        private string LastRolledItem { get; set; }

        /// <summary>
        /// Gets or sets the number of rolls before
        /// </summary>
        public int NumberOfMainRolls { get; set; }

        /// <summary>
        /// Gets or sets the time between choosing each roll option
        /// </summary>
        public int TimeBetweenRolls { get; set; }

        /// <summary>
        /// Gets or sets how many rolls it takes for the slide to slow down
        /// </summary>
        public int NumberOfSlowDownRolls { get; set; }

        /// <summary>
        /// Gets or sets the maximum amount of roll time when slowing down
        /// </summary>
        public int MaxRollTime { get; set; }

        /// <summary>
        /// Gets the current list being used
        /// </summary>
        public SpecificList CurrentList { get; private set; }

        /// <summary>
        /// Gets the list of availble lists for preloading
        /// </summary>
        public List<string> ListsAvailable { get; private set; } = new List<string>();

        private static Dictionary<ListRandomiserFolder, string> SaveLocation = new Dictionary<ListRandomiserFolder, string>
        {
            { ListRandomiserFolder.Main, Path.Combine(BaseApplication.SaveFolder, "List Randomiser") },
            { ListRandomiserFolder.ListsFromMain, "Lists" },
            { ListRandomiserFolder.SettingsFromMain, "Settings.txt" }
        };

        /// <summary>
        /// Initialises a new <c>ListRandomiserApp</c> instance with default values
        /// </summary>
        public ListRandomiserApp()
        {
            string listLocation = Path.Combine(SaveLocation[ListRandomiserFolder.Main], SaveLocation[ListRandomiserFolder.ListsFromMain]);
            string settingsLocation = Path.Combine(SaveLocation[ListRandomiserFolder.Main], SaveLocation[ListRandomiserFolder.SettingsFromMain]);

            // Create the folders if they are missing
            Directory.CreateDirectory(SaveLocation[ListRandomiserFolder.Main]);
            Directory.CreateDirectory(listLocation);

            // Create basic list of all available lists
            foreach (string folder in Directory.EnumerateFiles(listLocation))
            {
                ListsAvailable.Add(Path.GetFileNameWithoutExtension(folder));
            }

            // Load settings
            if (File.Exists(settingsLocation))
            {
                string[] file = File.ReadAllLines(settingsLocation);
                NumberOfMainRolls = Convert.ToInt32(file[0]);
                NumberOfSlowDownRolls = Convert.ToInt32(file[1]);
                TimeBetweenRolls = Convert.ToInt32(file[2]);
                MaxRollTime = Convert.ToInt32(file[3]);
            }
            else
            {
                SetDefaultSettings();
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
        /// Saves the current settings to the settings file
        /// </summary>
        public void SaveSettings()
        {
            string settingsLocation = Path.Combine(SaveLocation[ListRandomiserFolder.Main], SaveLocation[ListRandomiserFolder.SettingsFromMain]);
            string[] saveLines = { NumberOfMainRolls.ToString(), NumberOfSlowDownRolls.ToString(), TimeBetweenRolls.ToString(), MaxRollTime.ToString() };
            File.WriteAllLines(settingsLocation, saveLines);
        }

        /// <summary>
        /// Sets the settings to their default values
        /// </summary>
        public void SetDefaultSettings()
        {
            NumberOfMainRolls = 20;
            NumberOfSlowDownRolls = 5;
            TimeBetweenRolls = 50;
            MaxRollTime = 500;
        }

        /// <summary>
        /// Saves the current list with all its contents intact
        /// </summary>
        public void SaveList()
        {
            if (ListsAvailable.Contains(CurrentList.Name))
            {
                throw new ListNameTakenException("List already exists - change name before saving");
            }

            ListsAvailable.Add(CurrentList.Name);
            File.WriteAllLines(Path.Combine(SaveLocation[ListRandomiserFolder.Main], SaveLocation[ListRandomiserFolder.ListsFromMain], CurrentList.Name + ".txt"), CurrentList.Items);
        }

        /// <summary>
        /// Saves the temporary list and it's contents to the save file
        /// </summary>
        /// <param name="name"></param>
        public void SaveList(string name)
        {
            if (ListsAvailable.Contains(name))
            {
                throw new ListNameTakenException("List already exists - change name before saving");
            }
            if (TempList == null)
            {
                throw new ListDoesNotExistException("Temporary list not created yet");
            }

            ListsAvailable.Add(name);
            File.WriteAllLines(Path.Combine(SaveLocation[ListRandomiserFolder.Main], SaveLocation[ListRandomiserFolder.ListsFromMain], name + ".txt"), TempList.Items);
        }

        /// <summary>
        /// Removes a list based upon its name
        /// </summary>
        /// <param name="listName">The name of the list to remove</param>
        public void RemoveList(string listName)
        {
            if (!ListsAvailable.Contains(listName))
            {
                throw new ListDoesNotExistException("Given list does not exist");
            }

            ListsAvailable.Remove(listName);
            File.Delete(Path.Combine(SaveLocation[ListRandomiserFolder.Main], SaveLocation[ListRandomiserFolder.ListsFromMain], listName + ".txt"));
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

            CurrentList = new SpecificList(listChoice, File.ReadAllLines(Path.Combine(SaveLocation[ListRandomiserFolder.Main], SaveLocation[ListRandomiserFolder.ListsFromMain], listChoice + ".txt")).ToList());
            TempList = null;
        }

        /// <summary>
        /// Returns if the list has been prepared yet
        /// </summary>
        /// <returns>If the temporary list has been prepared</returns>
        public bool ListPrepared()
        {
            return TempList != null;
        }
        
        /// <summary>
        /// Sets up a temporary list ready for rolling
        /// </summary>
        public void PrepareList()
        {
            TempList = new SpecificList(CurrentList.Name, CurrentList.Items);
        }

        /// <summary>
        /// Gets the list of items available in the temporary list
        /// </summary>
        /// <returns>The current temporary list</returns>
        public List<string> GetItems()
        {
            return TempList.Items;
        }

        /// <summary>
        /// Returns a randomised list of the items
        /// </summary>
        /// <returns>A randomised version of the list</returns>
        public List<string> GetRandomisedList()
        {
            Random random = new Random();
            List<string> originalListItems = new List<string>(CurrentList.Items);
            List<string> randomisedList = new List<string>();

            while (originalListItems.Count > 0)
            {
                int index = random.Next(originalListItems.Count);
                string listItem = originalListItems[index];
                originalListItems.RemoveAt(index);

                randomisedList.Add(listItem);
            }

            return randomisedList;
        }

        /// <summary>
        /// Removes an item after a roll has occurred
        /// </summary>
        /// <param name="item">The item to be removed</param>
        public void Roll(string item)
        {
            TempList.Items.Remove(item);
            LastRolledItem = item;
        }

        /// <summary>
        /// Prepares the list for a re-rolling by adding the last rolled item to the list
        /// </summary>
        /// <param name="item">The item to be added to the list</param>
        public void Reroll()
        {
            TempList.Items.Add(LastRolledItem);
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
