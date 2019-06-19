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

namespace FormApplication.ListRandomiser
{
    public partial class ListRandomiserMenu : Form
    {
        private ListRandomiserApp Application { get; set; }

        public ListRandomiserMenu(ListRandomiserApp application)
        {
            Application = application;
            InitializeComponent();
            CenterToScreen();

            // Change size of splitters
            Splt_display.SplitterWidth = 25;
            Splt_extraFunctions.SplitterWidth = 25;
            Splt_mainSplit.SplitterWidth = 50;

            // Change splitter distance to relevant relative distances
            Splt_display.SplitterDistance = (Splt_display.Width - Splt_display.SplitterWidth) / 2;
            Splt_extraFunctions.SplitterDistance = (Splt_extraFunctions.Width - Splt_extraFunctions.SplitterWidth) / 2;
            Splt_mainSplit.SplitterDistance = Splt_mainSplit.Width - Splt_mainSplit.SplitterWidth - 150;
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
            if (Application.ListsAvailable.Count == 0)
            {
                MessageBox.Show("A list must be selected");
            }
        }

        private void Btn_createList_Click(object sender, EventArgs e)
        {
            Navigation.SaveNextForm(Forms.ListRandomiser_ModifyList, new List<object>() { Application });
            Close();
        }
    }
}
