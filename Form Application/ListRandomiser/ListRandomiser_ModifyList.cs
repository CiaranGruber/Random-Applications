using ApplicationCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormUtilities;

namespace FormApplication.ListRandomiser
{
    public partial class ListRandomiser_ModifyList : Form
    {
        private ListRandomiserApp Application { get; set; }

        public ListRandomiser_ModifyList(ListRandomiserApp application)
        {
            Application = application;

            InitializeComponent();
            CenterToScreen();

            Txt_currentList.Top = (Pnl_currentList.Height - Txt_currentList.Height) / 2;

            // Set splitter widths/distances
            Splt_mainFunctions.SplitterWidth = 25;
            Splt_secondMainFunctions.SplitterWidth = 25;
            Splt_mainFunctions.SplitterDistance = (Splt_mainFunctions.Width - Splt_mainFunctions.SplitterWidth) / 2;
            Splt_secondMainFunctions.SplitterDistance = (Splt_secondMainFunctions.Width - Splt_secondMainFunctions.SplitterWidth) / 2;

            // Load the lists and fill the combo boxes
            LoadCurrentList();
            CBo_loadList.Items.AddRange(Application.ListsAvailable.ToArray());
            CBo_removeList.Items.AddRange(Application.ListsAvailable.ToArray());
        }

        private void LoadCurrentList()
        {
            Pnl_listOptions.Controls.Clear();

            if (Application.CurrentList != null)
            {
                Txt_currentList.Lines = new string[] { Application.CurrentList.Name };

                for (int i = 0; i < Application.CurrentList.Items.Count; i++)
                {
                    // Get the base panel with the name and remove button
                    Panel overallPanel = ListRandomiserUtils.GetBasePanel(Application.CurrentList.Items[i], i);

                    // Add Remove button Click event
                    overallPanel.Controls[1].Click += RemoveOption_Click;
                    
                    // Add Move Up button and Click event if not at the top of the list
                    if (i != 0)
                    {
                        overallPanel.AddMoveUpButton(i);
                        overallPanel.Controls[2].Click += MoveUp_Click;
                    }
                    else
                    {
                        overallPanel.AddPaddingPanel();
                    }

                    // Add Move Down button and Click event if not at the bottom of the list
                    if (i != Application.CurrentList.Items.Count - 1)
                    {
                        overallPanel.AddMoveDownButton(i);
                        overallPanel.Controls[3].Click += MoveDown_Click;
                    }
                    else
                    {
                        overallPanel.AddPaddingPanel();
                    }

                    Pnl_listOptions.Controls.Add(overallPanel);
                }

                Pnl_listOptions.Controls.Reverse();
            }
        }

        private void AddOption(string optionName, int optionIndex)
        {
            // Get the base panel with the name and remove button
            Panel overallPanel = ListRandomiserUtils.GetBasePanel(optionName, optionIndex);

            // Add Remove button Click event
            overallPanel.Controls[1].Click += RemoveOption_Click;

            
            // Adds the MoveDown and MoveUp button to the previous control and current control if not the first
            if (optionIndex != 0)
            {
                // Add down button to previous panel - Note bottom panel is index 0
                Pnl_listOptions.Controls[0].PaddingToDownButton(optionIndex - 1);

                // Add up button to current panel
                overallPanel.AddMoveUpButton(optionIndex);
                overallPanel.AddPaddingPanel();

                // Add Click events
                overallPanel.Controls[2].Click += MoveUp_Click;
                Pnl_listOptions.Controls[0].Controls[3].Click += MoveDown_Click;
            }
            else
            {
                // Add padding rather than buttons
                overallPanel.AddPaddingPanel();
                overallPanel.AddPaddingPanel();
            }
            
            Pnl_listOptions.Controls.Insert(0, overallPanel);

            UpdateButtons();
        }

        private void RemoveOption_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt16((sender as Control).Name);

            Application.RemoveItem(index);

            // For all changes, note that controls are in reverse order. Ie. Index 0 is at the bottom

            // Remove down arrow of previous index if last option
            if (Pnl_listOptions.Controls.Count > 1 && index == Pnl_listOptions.Controls.Count - 1)
            {
                Pnl_listOptions.Controls[1].DownButtonToPadding();
            }

            // Remove up arrow of index after if first option
            if (Pnl_listOptions.Controls.Count > 1 && index == 0)
            {
                Pnl_listOptions.Controls[Pnl_listOptions.Controls.Count - 2].UpButtonToPadding();
            }

            // Remove option
            Pnl_listOptions.Controls.RemoveAt(Pnl_listOptions.Controls.Count - 1 - index);

            for (int i = Pnl_listOptions.Controls.Count - 1 - index; i >= 0; --i)
            {
                // Change name for the buttons
                for (int j = 1; j < 4; j++)
                {
                    Pnl_listOptions.Controls[i].Controls[j].Name = (Pnl_listOptions.Controls.Count - 1 - i).ToString();
                }
            }

            UpdateButtons();
        }

        private void MoveUp_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt16((sender as Control).Name);

            Application.MoveUp(index);

            // Swap names - Note: list options are in reverse order
            string originalText = Pnl_listOptions.Controls[Pnl_listOptions.Controls.Count - index - 1].Controls[0].Text;
            string newText = Pnl_listOptions.Controls[Pnl_listOptions.Controls.Count - index].Controls[0].Text;

            Pnl_listOptions.Controls[Pnl_listOptions.Controls.Count - index].Controls[0].Text = originalText;
            Pnl_listOptions.Controls[Pnl_listOptions.Controls.Count - index - 1].Controls[0].Text = newText;
        }

        private void MoveDown_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt16((sender as Control).Name);

            Application.MoveDown(index);

            // Swap names - Note: list options are in reverse order
            string originalText = Pnl_listOptions.Controls[Pnl_listOptions.Controls.Count - index - 1].Controls[0].Text;
            string newText = Pnl_listOptions.Controls[Pnl_listOptions.Controls.Count - index - 2].Controls[0].Text;

            Pnl_listOptions.Controls[Pnl_listOptions.Controls.Count - index - 2].Controls[0].Text = originalText;
            Pnl_listOptions.Controls[Pnl_listOptions.Controls.Count - index - 1].Controls[0].Text = newText;
        }

        private void Btn_addItem_Click(object sender, EventArgs e)
        {
            Application.AddItem(Txt_newItem.Lines[0]);

            AddOption(Application.CurrentList.Items.Last(), Application.CurrentList.Items.Count - 1);

            Txt_newItem.Lines = new string[] { };
            UpdateButtons();
        }

        private void Txt_currentList_TextChanged(object sender, EventArgs e)
        {
            if (Txt_currentList.Lines.Length > 0)
            {
                Application.ChangeName(Txt_currentList.Lines[0]);
            }
            else
            {
                Application.ChangeName(null);
            }
        }

        private void Btn_done_Click(object sender, EventArgs e)
        {
            Navigation.SaveNextForm(Forms.ListRandomiser, new List<object> { Application });
            Close();
        }

        private void Txt_newItem_TextChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void Btn_removeList_Click(object sender, EventArgs e)
        {
            // Cancel function if user wishes not to remove the list
            if (MessageBox.Show("Are you sure you wish to continue? Once deleted, you cannot retrieve a list", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            Application.RemoveList(CBo_removeList.SelectedItem.ToString());
            CBo_loadList.Items.Remove(CBo_removeList.SelectedItem);
            CBo_removeList.Items.Remove(CBo_removeList.SelectedItem);

            UpdateButtons();
        }

        private void Btn_saveList_Click(object sender, EventArgs e)
        {
            if (Application.ListsAvailable.Contains(Txt_currentList.Text))
            {
                MessageBox.Show("List name is already taken - please choose a new one");
                return;
            }
            Application.SaveList();

            CBo_loadList.Items.Add(Application.CurrentList.Name);
            CBo_removeList.Items.Add(Application.CurrentList.Name);

            MessageBox.Show("List successfully saved");
        }

        private void CBo_loadList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void CBo_removeList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void Btn_loadList_Click(object sender, EventArgs e)
        {
            Application.ChooseList(CBo_loadList.SelectedItem.ToString());
            
            CBo_loadList.SelectedItem = null;
            LoadCurrentList();
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            Btn_loadList.Enabled = CBo_loadList.SelectedItem != null;
            Btn_removeList.Enabled = CBo_removeList.SelectedItem != null;
            Btn_saveList.Enabled = Pnl_listOptions.Controls.Count > 0;
            Btn_addItem.Enabled = Txt_newItem.Lines.Length > 0;
        }
    }
}
