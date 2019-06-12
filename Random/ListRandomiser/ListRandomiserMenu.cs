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
            splt_display.SplitterWidth = 25;
            splt_extraFunctions.SplitterWidth = 25;
            splt_mainSplit.SplitterWidth = 50;

            // Change splitter distance to relevant relative distances
            splt_display.SplitterDistance = (splt_display.Width - splt_display.SplitterWidth) / 2;
            splt_extraFunctions.SplitterDistance = (splt_extraFunctions.Width - splt_extraFunctions.SplitterWidth) / 2;
            splt_mainSplit.SplitterDistance = splt_mainSplit.Width - splt_mainSplit.SplitterWidth - 150;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Navigation.SaveNextForm(Forms.MainMenu);
            Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            splt_display.Panel2.Controls.Clear();
        }

        private void btn_roll_Click(object sender, EventArgs e)
        {
            if (Application.ListsAvailable.Count == 0)
            {
                MessageBox.Show("A list must be selected");
            }
        }

        private void btn_createList_Click(object sender, EventArgs e)
        {
            Navigation.SaveNextForm(Forms.ListRandomiser_ModifyList, new List<object>() { Application });
            Close();
        }
    }
}
