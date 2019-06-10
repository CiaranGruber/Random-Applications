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

namespace Random
{
     public partial class Navigation : Form
    {
        /// <summary>
        /// Gets or sets the Base Application for the Forms
        /// </summary>
        public static BaseApplication Application { get; set; }

        /// <summary>
        /// Gets the data for the next form to be opened
        /// </summary>
        public static Tuple<Forms, List<string>> NextForm { get; private set; }

        public Navigation(Forms startingForm)
        {
            InitializeComponent();
            SaveNextForm(startingForm);
        }
        
        private void Navigation_Load(object sender, EventArgs e)
        {
            while (NextForm.Item1 != Forms.Quit)
            {
                Form newForm;

                if (NextForm.Item1 == Forms.MainMenu)
                {

                }

                Hide();
                newForm.ShowDialog();

                Show();
            }
        }

        /// <summary>
        /// Gets the next form ready to be opened with extra data included
        /// </summary>
        /// <param name="nextForm">The next form that is to be opened</param>
        public static void SaveNextForm(Forms nextForm)
        {
            SaveNextForm(nextForm, null);
        }

        /// <summary>
        /// Gets the next form ready to be opened with extra data included
        /// </summary>
        /// <param name="nextForm">The next form that is to be opened</param>
        /// <param name="formData">The data needed for the next form</param>
        public static void SaveNextForm(Forms nextForm, List<string> formData)
        {
            NextForm = new Tuple<Forms, List<string>>(nextForm, formData);
        }
    }
}
