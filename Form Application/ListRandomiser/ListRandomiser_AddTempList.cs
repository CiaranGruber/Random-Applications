using GeneralUtilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApplication.ListRandomiser
{
    public partial class ListRandomiser_AddTempList : Form
    {
        private List<string> TakenNames { get; set; }

        /// <summary>
        /// Gets the list name that was entered by the user
        /// </summary>
        public string ListName { get; private set; }

        public ListRandomiser_AddTempList(List<string> takenNames)
        {
            InitializeComponent();

            // Set split container
            Splt_buttons.IsSplitterFixed = true;
            Splt_buttons.SplitterWidth = 10;
            Splt_buttons.SplitterDistance = (Splt_buttons.Width - Splt_buttons.SplitterWidth) / 2;

            TakenNames = takenNames;
        }

        private void Btn_addList_Click(object sender, EventArgs e)
        {
            // If a name has not been entered
            if (Txt_listName.Text == "" || Txt_listName.Text == null)
            {
                MessageBox.Show("A name must be entered to add the list");
            }

            // If invalid characters were used
            else if (Txt_listName.Text.ContainsAny(Path.GetInvalidPathChars()))
            {
                // Give a list of all invalid characters
                string invalidChars = "";
                foreach (char character in Path.GetInvalidPathChars())
                {
                    invalidChars += character + ", ";
                }
                invalidChars = invalidChars.Substring(0, invalidChars.Length - 2);
                MessageBox.Show("Invalid characters may not be used. These include: " + invalidChars);
            }

            // Add to list if available
            else
            {
                DialogResult = DialogResult.OK;
                ListName = Txt_listName.Text;
            }
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
