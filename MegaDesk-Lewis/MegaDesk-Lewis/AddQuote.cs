using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Lewis
{
    public partial class AddQuote : Form
    {
        const int MIN_WITH = 24;
        public int MAX_WITH = 96;
        const int MIN_DEPTH = 12;
        const int MAX_DEPTH = 48;

        public AddQuote()
        {
            InitializeComponent();
        }

        public AddQuote(MainMenu mainMenu)
        {
            InitializeComponent();

            this.QuoteButton.Enabled = false;

            //This will assign the current date from the beging
            string Date = DateTime.Now.ToString("dd-MM-yyyy");


            ArrayList materials = new ArrayList();
            int enumlen = Enum.GetValues(typeof(desktopMaterials)).Length;
            Array materialNames = Enum.GetValues(typeof(desktopMaterials));

            for (int i = 0; i < enumlen; i++)
            {
                materials.Add(materialNames.GetValue(i));
            }


        }




        public int getDeskWidth()
        {
            return Convert.ToInt32(this.DeskWidth.Text);
        }

        public int getDeskDepth()
        {
            return Convert.ToInt32(this.DeskDepth.Text);
        }

        public int getDeskDrawers()
        {
            return Convert.ToInt32(this.DeskDrawers.Text);
        }

        public String getClientName()
        {
            return this.ClientName.Text;
        }

        public int getRushDays()
        {
            return Convert.ToInt32(this.RushDays.Text);
        }

        public string getMaterial()
        {
            return this.Material.Text;
        }

        public bool checkWidth()
        {
            int width = Convert.ToInt32(this.DeskWidth.Text);

            if (width < MIN_WITH || width > MAX_WITH)
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        public bool checkDepth()
        {
            int depth = Convert.ToInt32(this.DeskDepth.Text);

            if (depth < MIN_DEPTH || depth > MAX_DEPTH)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        private void Width_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            bool result = checkWidth();
            string errorMessage = "Width must be between 24 and 96 inches.";

            if (!result)
            {
                e.Cancel = true;
                DeskWidth.Select();
                System.Windows.Forms.MessageBox.Show(errorMessage);
            }
        }

        private void DeskDepth_Validating(object sender, CancelEventArgs e)
        {
            bool result = checkDepth();
            string errorMessage = "Depth must be betwenn 12 and 48 inches.";

            if (!result)
            {
                DeskWidth.Select();
                System.Windows.Forms.MessageBox.Show(errorMessage);
            }

        }

        private void QuoteButton_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearchQuotes = new SearchQuotes();
            viewSearchQuotes.Tag = this;
            viewSearchQuotes.Show(this);
            Hide();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }


        private void Date_Click(object sender, EventArgs e)
        {
            string today = DateTime.Now.ToString("dd-MM-yyyy");
            Console.WriteLine(today);
        }

        public enum desktopMaterials
        {
            Oak = 200,
            Laminate = 100,
            Pine = 50,
            Rossewood = 300,
            Veneer = 150
        }

       

        private void DrawersUpDown_ValueChanged(object sender, EventArgs e)
        {
            DrawersUpDown.Maximum = 7;
            DrawersUpDown.Minimum = 0;
        }

        private void MaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaterialComboBox.DataSource = Enum.GetNames(typeof(desktopMaterials));
        }
    }

}

   

    

    
