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

namespace FormApplication.ListRandomiser
{
    public partial class ListRandomiser_Settings : Form
    {
        private ListRandomiserApp Application { get; set; }

        public ListRandomiser_Settings(ListRandomiserApp application)
        {
            Application = application;
            InitializeComponent();
        }

        private void ListRandomiser_Settings_Load(object sender, EventArgs e)
        {
            Num_mainRolls.Value = Application.NumberOfMainRolls;
            Num_slowRolls.Value = Application.NumberOfSlowDownRolls;
            Num_maxTime.Value = Application.MaxRollTime;
            Num_rollTime.Value = Application.TimeBetweenRolls;
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Application.NumberOfMainRolls = (int)Num_mainRolls.Value;
            Application.NumberOfSlowDownRolls = (int)Num_slowRolls.Value;
            Application.TimeBetweenRolls = (int)Num_rollTime.Value;
            Application.MaxRollTime = (int)Num_maxTime.Value;
            Application.SaveSettings();
            Navigation.SaveNextForm(Forms.ListRandomiser, new List<object>() { Application });
            Close();
        }

        private void Btn_DefaultSettings_Click(object sender, EventArgs e)
        {
            Application.SetDefaultSettings();
            Num_mainRolls.Value = Application.NumberOfMainRolls;
            Num_slowRolls.Value = Application.NumberOfSlowDownRolls;
            Num_maxTime.Value = Application.MaxRollTime;
            Num_rollTime.Value = Application.TimeBetweenRolls;
        }
    }
}
