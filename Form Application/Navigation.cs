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

namespace FormApplication
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
        public static Tuple<Forms, List<object>> NextForm { get; private set; }

        public Navigation(Forms startingForm)
        {
            InitializeComponent();
            SaveNextForm(startingForm);
            CenterToScreen();
            Application = new BaseApplication();
        }
        
        private void Navigation_Load(object sender, EventArgs e)
        {
            while (NextForm.Item1 != Forms.Quit)
            {
                Form newForm;

                if (NextForm.Item1 == Forms.MainMenu)
                {
                    newForm = new MainMenu();
                }
                else if (NextForm.Item1 == Forms.ListRandomiser)
                {
                    newForm = new ListRandomiser.ListRandomiserMenu(NextForm.Item2[0] as ListRandomiserApp);
                }
                else if (NextForm.Item1 == Forms.ListRandomiser_ModifyList)
                {
                    newForm = new ListRandomiser.ListRandomiser_ModifyList(NextForm.Item2[0] as ListRandomiserApp);
                }
                else if (NextForm.Item1 == Forms.ListRandomiser_Settings)
                {
                    newForm = new ListRandomiser.ListRandomiser_Settings(NextForm.Item2[0] as ListRandomiserApp);
                }
                else
                {
                    newForm = new Form();
                }

                // Quits application by default if the next form isn't set
                SaveNextForm(Forms.Quit);

                Hide();
                newForm.ShowDialog();

                Show();
            }
            Close();
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
        public static void SaveNextForm(Forms nextForm, List<object> formData)
        {
            NextForm = new Tuple<Forms, List<object>>(nextForm, formData);
        }
    }
}
