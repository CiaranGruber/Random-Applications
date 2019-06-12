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

            txt_currentList.Top = (pnl_currentList.Height - txt_currentList.Height) / 2;

            splt_mainFunctions.SplitterWidth = 25;
            splt_mainFunctions.SplitterDistance = (splt_mainFunctions.Width - splt_mainFunctions.SplitterWidth) / 2;

            LoadList(Application.CurrentList);
        }

        private void LoadList(SpecificList currentList)
        {
            pnl_listOptions.Controls.Clear();

            if (currentList != null)
            {
                txt_currentList.Lines = new string[] { currentList.Name };

                for (int i = 0; i < currentList.Items.Count; i++)
                {
                    Panel overallPanel = new Panel
                    {
                        Dock = DockStyle.Top,
                        Height = 25
                    };

                    Label optionName = new Label
                    {
                        Dock = DockStyle.Fill,
                        Text = currentList.Items[i],
                        TextAlign = ContentAlignment.MiddleLeft
                    };

                    Button removeOption = new Button
                    {
                        Text = "Remove",
                        Width = 70,
                        Dock = DockStyle.Right,
                        Name = i.ToString()
                    };

                    Button moveUp = new Button
                    {
                        Text = "↑",
                        Width = 35,
                        Dock = DockStyle.Right,
                        Name = i.ToString()
                    };

                    Button moveDown = new Button
                    {
                        Text = "↓",
                        Width = 35,
                        Dock = DockStyle.Right,
                        Name = i.ToString()
                    };

                    Panel paddingPanel = new Panel
                    {
                        Width = 35,
                        Dock = DockStyle.Right
                    };

                    overallPanel.Controls.Add(optionName);
                    overallPanel.Controls.Add(removeOption);

                    if (i != 0)
                    {
                        overallPanel.Controls.Add(moveUp);
                    }
                    else
                    {
                        overallPanel.Controls.Add(paddingPanel);
                    }
                    if (i != currentList.Items.Count - 1)
                    {
                        overallPanel.Controls.Add(moveDown);
                    }
                    else
                    {
                        overallPanel.Controls.Add(paddingPanel);
                    }

                    pnl_listOptions.Controls.Add(overallPanel);
                }

                pnl_listOptions.Controls.Reverse();
            }
        }

        private void AddOption(string optionName, int optionIndex)
        {
            pnl_listOptions.Controls.Reverse();

            Panel overallPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 25
            };

            Label optionLabel = new Label
            {
                Dock = DockStyle.Fill,
                Text = optionName,
                TextAlign = ContentAlignment.MiddleLeft
            };

            Button removeOption = new Button
            {
                Text = "Remove",
                Width = 70,
                Dock = DockStyle.Right,
                Name = optionIndex.ToString()
            };
            removeOption.Click += RemoveOption_Click;

            overallPanel.Controls.Add(optionLabel);
            overallPanel.Controls.Add(removeOption);
            
            // Adds the MoveDown and MoveUp button to the previous control and current control if relevant
            if (optionIndex != 0)
            {
                Button moveUp = new Button
                {
                    Text = "↑",
                    Width = 35,
                    Dock = DockStyle.Right,
                    Name = optionIndex.ToString()
                };

                Button moveDown = new Button
                {
                    Text = "↓",
                    Width = 35,
                    Dock = DockStyle.Right,
                    Name = (optionIndex - 1).ToString()
                };

                Panel paddingPanel = new Panel
                {
                    Width = 35,
                    Dock = DockStyle.Right
                };

                // Replace padding panel with button for previous list option
                pnl_listOptions.Controls[optionIndex - 1].Controls.Replace(moveDown, pnl_listOptions.Controls[optionIndex - 1].Controls.Count - 1);

                overallPanel.Controls.Add(moveUp);
                overallPanel.Controls.Add(paddingPanel);
            }
            else
            {
                for (int x = 0; x < 2; x++)
                {
                    Panel paddingPanel = new Panel
                    {
                        Width = 35,
                        Dock = DockStyle.Right
                    };
                    overallPanel.Controls.Add(paddingPanel);
                }
            }

            pnl_listOptions.Controls.Add(overallPanel);

            pnl_listOptions.Controls.Reverse();
        }

        private void RemoveOption_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt16((sender as Control).Name);

            Application.RemoveItem(index);

            // As controls are flipped, index must be removed at the inverse number
            pnl_listOptions.Controls.RemoveAt(pnl_listOptions.Controls.Count - index - 1);
            
            for (int i = index - 1; i >= 0; i--)
            {
                // Change name for the buttons
                for (int j = 0; j < 3; j++)
                {
                    pnl_listOptions.Controls[i].Controls[j].Name = (pnl_listOptions.Controls.Count - i - 1).ToString();
                }
            }
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            Application.AddItem(txt_newItem.Lines[0]);

            AddOption(Application.CurrentList.Items.Last(), Application.CurrentList.Items.Count - 1);

            txt_newItem.Lines = new string[] { };
        }

        private void txt_currentList_TextChanged(object sender, EventArgs e)
        {
            Application.ChangeName(txt_currentList.Lines[0]);
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            Navigation.SaveNextForm(Forms.ListRandomiser, new List<object> { Application });
            Close();
        }

        private void txt_newItem_TextChanged(object sender, EventArgs e)
        {
            btn_addItem.Enabled = txt_newItem.Lines.Length > 0;
        }
    }
}
