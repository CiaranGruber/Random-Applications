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

namespace Random.ListRandomiser
{
    public partial class ListRandomiserMenu : Form
    {
        public static ListRandomiserApp Application { get; set; }

        public ListRandomiserMenu()
        {
            InitializeComponent();
            Application = new ListRandomiserApp();
            CenterToScreen();
        }

        private void ListRandomiserMenu_Load(object sender, EventArgs e)
        {
            Navigation.SaveNextForm(Forms.MainMenu);
        }
    }
}
