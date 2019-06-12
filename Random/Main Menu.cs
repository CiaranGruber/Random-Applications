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

namespace FormApplication
{
    public partial class MainMenu : Form
    {
        private Dictionary<string, Dictionary<string, Forms>> GroupNameToGroup = new Dictionary<string, Dictionary<string, Forms>>
        {
            {
                "Number-based Generators", new Dictionary<string, Forms>
                {
                    { "Integer Generator (not created)", Forms.Quit }
                }
            },
            {
                "String-based Generators", new Dictionary<string, Forms>
                {
                    { "List Randomiser (not created)", Forms.ListRandomiser }
                }
            }

        };

        public MainMenu()
        {
            InitializeComponent();
            CenterToScreen();

            LoadChoices();
        }

        private void LoadChoices()
        {
            // Set the next form to quit
            Navigation.SaveNextForm(Forms.Quit);

            bool firstGeneratorPanel = true;

            // Create generator groups
            foreach (KeyValuePair<string, Dictionary<string, Forms>> groupNameToForm in GroupNameToGroup)
            {
                Panel overallPanel = new Panel
                {
                    Dock = DockStyle.Top,
                    AutoSize = true
                };

                Label groupTitle = new Label
                {
                    Dock = DockStyle.Top,
                    Text = groupNameToForm.Key,
                    Font = new Font("Monotxt_IV25", 10.2F, FontStyle.Regular),
                    AutoSize = true,
                    Padding = new Padding(0, 0, 0, 10)
                };

                Panel generatorsPanel = new Panel
                {
                    Dock = DockStyle.Top,
                    MinimumSize = new Size(10, 25),
                    AutoSize = true,
                    Padding = new Padding(10, 0, 0, 0)
                };

                // Add padding for all panels except the first
                if (!firstGeneratorPanel)
                {
                    overallPanel.Padding = new Padding(0, 25, 0, 10);
                }
                else
                {
                    firstGeneratorPanel = false;
                }

                // Add individual generators
                foreach (KeyValuePair<string, Forms> formNameToForm in groupNameToForm.Value)
                {
                    SplitContainer generatorPanel = new SplitContainer
                    {
                        Dock = DockStyle.Top,
                        SplitterWidth = 25,
                        Height = 50,
                        IsSplitterFixed = true,
                        TabStop = false
                    };
                    generatorPanel.SplitterDistance = (generatorPanel.Width - generatorPanel.SplitterWidth) / 2;

                    Label generatorName = new Label
                    {
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Text = formNameToForm.Key
                    };

                    Button generatorButton = new Button
                    {
                        Dock = DockStyle.Fill,
                        Name = groupNameToForm.Key + "|" + formNameToForm.Key,
                        Text = "Go to menu"
                    };
                    generatorButton.Click += GeneratorButton_Click;

                    generatorPanel.Panel1.Controls.Add(generatorName);
                    generatorPanel.Panel2.Controls.Add(generatorButton);

                    generatorsPanel.Controls.Add(generatorPanel);
                }

                // Correct order of generators
                generatorsPanel.Controls.Reverse();

                // Add generator group
                overallPanel.Controls.Add(groupTitle);
                overallPanel.Controls.Add(generatorsPanel);
                overallPanel.Controls.Reverse();

                pnl_availableGenerators.Controls.Add(overallPanel);
            }

            // Correct panel order
            pnl_availableGenerators.Controls.Reverse();
        }

        private void GeneratorButton_Click(object sender, EventArgs e)
        {
            Control convertedSender = sender as Control;

            // Separate name into differing parts to be searched in the dictionary
            Tuple<string, string> groupNameToFormName = new Tuple<string, string>(convertedSender.Name.Split('|')[0], convertedSender.Name.Split('|')[1]);

            // Save next form to open and close menu
            if (GroupNameToGroup[groupNameToFormName.Item1][groupNameToFormName.Item2] == Forms.ListRandomiser)
            {
                Navigation.SaveNextForm(GroupNameToGroup[groupNameToFormName.Item1][groupNameToFormName.Item2], new List<object> { new ListRandomiserApp() });
            }
            else
            {
                Navigation.SaveNextForm(GroupNameToGroup[groupNameToFormName.Item1][groupNameToFormName.Item2]);
            }
            Close();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
