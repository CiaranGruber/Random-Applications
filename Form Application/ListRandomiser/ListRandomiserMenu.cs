using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationCode;
using FormUtilities;
using System.Threading;

namespace FormApplication.ListRandomiser
{
    public partial class ListRandomiserMenu : Form
    {
        private ListRandomiserApp Application { get; set; }

        private Font smallFont = new Font("Monotxt_IV25", 8, FontStyle.Regular);
        private Font medFont = new Font("Monotxt_IV25", 10, FontStyle.Regular);
        private Font largeFont = new Font("Monotxt_IV25", 12, FontStyle.Regular);

        public ListRandomiserMenu(ListRandomiserApp application)
        {
            Application = application;

            InitializeComponent();

            // Change size of splitters
            Splt_display.SplitterWidth = 25;
            Splt_extraFunctions.SplitterWidth = 25;
            Splt_mainSplit.SplitterWidth = 50;

            // Change splitter distance to relevant relative distances
            Splt_display.SplitterDistance = (Splt_display.Width - Splt_display.SplitterWidth) / 2;
            Splt_extraFunctions.SplitterDistance = (Splt_extraFunctions.Width - Splt_extraFunctions.SplitterWidth) / 2;
            Splt_mainSplit.SplitterDistance = Splt_mainSplit.Width - Splt_mainSplit.SplitterWidth - 200;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            Navigation.SaveNextForm(Forms.MainMenu);
            Close();
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            Splt_display.Panel2.Controls.Clear();
        }

        private void Btn_roll_Click(object sender, EventArgs e)
        {
            // Exit function early if list is not ready
            if (Application.CurrentList.Items.Count == 0 || !Application.ListPrepared())
            {
                MessageBox.Show("Current list must contain some items. If items have not been added, go to modify list to modify the current list" +
                    " click reset list to reset the current list.");
                return;
            }

            Roll();
        }

        private void Btn_createList_Click(object sender, EventArgs e)
        {
            Navigation.SaveNextForm(Forms.ListRandomiser_ModifyList, new List<object>() { Application });
            Close();
        }

        private void Btn_generateRandomisedList_Click(object sender, EventArgs e)
        {
            Form randomListForm = new Form
            {
                MinimumSize = new Size(600, 200),
                MaximumSize = new Size(Screen.GetWorkingArea(this).Width - 100, Screen.GetWorkingArea(this).Height - 200),
                StartPosition = FormStartPosition.CenterParent,

                // Sets Icon to the same as the current form
                Icon = ((Icon)(new ComponentResourceManager(typeof(ListRandomiserMenu)).GetObject("$this.Icon")))
            };

            Label title = new Label
            {
                Text = "Randomly Generated List",
                Dock = DockStyle.Top,
                Height = 100,
                Font = new Font("Monotxt_IV25", 16.2F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Panel mainPanel = new Panel
            {
                Dock = DockStyle.Fill
            };

            List<string> randomisedList = Application.GetRandomisedList();
            randomListForm.Controls.Add(title);
            randomListForm.Controls.Add(mainPanel);

            foreach (string listItem in randomisedList)
            {
                Label label = new Label
                {
                    Text = listItem,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                mainPanel.Controls.Add(label);
            }

            randomListForm.Controls.Reverse();
            randomListForm.Show();
        }

        private void Btn_reroll_Click(object sender, EventArgs e)
        {
            Application.Reroll();
            Roll();
        }

        private void Roll()
        {
            List<string> items = Application.GetItems();
            Splt_mainSplit.Panel2.Controls.Clear();

            Panel halfPadding = new Panel
            {
                Dock = DockStyle.Top,
                Height = Splt_mainSplit.Panel2.Height / 9
            };

            Panel padding = new Panel
            {
                Dock = DockStyle.Top,
                Height = Splt_mainSplit.Panel2.Height / 3
            };

            // Create base layout
            Splt_mainSplit.Panel2.Controls.Add(halfPadding);
            Splt_mainSplit.Panel2.Controls.Add(padding);
            Splt_mainSplit.Panel2.Controls.Add(halfPadding);
            Splt_mainSplit.Panel2.Controls.Add(padding);
            Splt_mainSplit.Panel2.Controls.Add(halfPadding);

            for (int i = 0; i < Application.NumberOfMainRolls; ++i)
            {
                PerformRollAnimation(items);
                Thread.Sleep(Application.TimeBetweenRolls);
            }

            for (int i = 0; i < Application.NumberOfSlowDownRolls; ++i)
            {
                PerformRollAnimation(items);

                // Slow down the roll by a constant value each time
                Thread.Sleep(Application.TimeBetweenRolls + (int)((Application.MaxRollTime - Application.TimeBetweenRolls) * ((double)i / Application.NumberOfSlowDownRolls)));
            }

            // If in padding-text-padding-text-padding, perform last roll animation
            if (Splt_mainSplit.Panel2.Controls.Count == 5)
            {
                PerformRollAnimation(items);
            }

            Application.Roll(Splt_mainSplit.Panel2.Controls[2].Text);
            Splt_mainSplit.Panel2.Controls[2].Font = new Font(Splt_mainSplit.Panel2.Controls[2].Font, FontStyle.Bold);
        }

        private void PerformRollAnimation(List<string> items)
        {
            Random random = new Random();

            // If in padding-text-padding-text-padding format
            if (Splt_mainSplit.Panel2.Controls.Count == 5)
            {
                // Next option to add
                Label nextOption = new Label
                {
                    Text = items[random.Next(items.Count)],
                    Dock = DockStyle.Top,
                    Height = Splt_mainSplit.Panel2.Height / 3,
                };

                // Remove padding panels
                Splt_mainSplit.Panel2.Controls.RemoveAt(0);
                Splt_mainSplit.Panel2.Controls.RemoveAt(1);
                Splt_mainSplit.Panel2.Controls.RemoveAt(2);

                // Add next label and change fonts
                Splt_mainSplit.Panel2.Controls.Add(nextOption);
                Splt_mainSplit.Panel2.Controls[0].Font = smallFont;
                Splt_mainSplit.Panel2.Controls[1].Font = largeFont;
                Splt_mainSplit.Panel2.Controls[2].Font = smallFont;
            }

            // If in text-text-text format
            else
            {
                Panel halfPadding = new Panel
                {
                    Dock = DockStyle.Top,
                    Height = Splt_mainSplit.Panel2.Height / 9
                };

                // Remove last text (Note: controls are in reverse order)
                Splt_mainSplit.Panel2.Controls.RemoveAt(0);

                // Add half padding
                Splt_mainSplit.Panel2.Controls.Insert(0, halfPadding);
                Splt_mainSplit.Panel2.Controls.Insert(2, halfPadding);
                Splt_mainSplit.Panel2.Controls.Add(halfPadding);

                // Set font sizes
                Splt_mainSplit.Panel2.Controls[1].Font = medFont;
                Splt_mainSplit.Panel2.Controls[3].Font = medFont;
            }
        }

        private void Btn_resetList_Click(object sender, EventArgs e)
        {
            Application.PrepareList();
        }

        private void Btn_RollSettings_Click(object sender, EventArgs e)
        {
            Navigation.SaveNextForm(Forms.ListRandomiser_Settings, new List<object>() { Application });
            Close();
        }

        private void Btn_saveCurrentList_Click(object sender, EventArgs e)
        {
            ListRandomiser_AddTempList AddTemp = new ListRandomiser_AddTempList(Application.ListsAvailable);

            AddTemp.ShowDialog();

            if (AddTemp.DialogResult == DialogResult.OK)
            {
                Application.SaveList(AddTemp.ListName);
            }
        }
    }
}
