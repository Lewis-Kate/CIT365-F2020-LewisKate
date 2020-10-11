using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
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
            return Convert.ToInt32(this.DeskWidthLabel.Text);
        }

        public int getDeskDepth()
        {
            return Convert.ToInt32(this.DeskDepthLabel.Text);
        }

        public int getDeskDrawers()
        {
            return Convert.ToInt32(this.DeskDrawersLabel.Text);
        }

        public String getClientName()
        {
            return this.NameLabel.Text;
        }

        public int getRushDays()
        {
            return Convert.ToInt32(this.ShippingLabel.Text);
        }

        public string getMaterial()
        {
            return this.MaterialLabel.Text;
        }

        public bool checkWidth()
        {
            int width = Convert.ToInt32(this.DeskWidthLabel.Text);

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
            int depth = Convert.ToInt32(this.DeskDepthLabel.Text);

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
                DeskWidthLabel.Select();
                System.Windows.Forms.MessageBox.Show(errorMessage);
            }
        }

        private void DeskDepth_Validating(object sender, CancelEventArgs e)
        {
            bool result = checkDepth();
            string errorMessage = "Depth must be betwenn 12 and 48 inches.";

            if (!result)
            {
                DeskWidthLabel.Select();
                System.Windows.Forms.MessageBox.Show(errorMessage);
            }

        }



        private void HomeButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void QuoteButton_Click(object sender, EventArgs e)
        {


            DisplayQuote viewDisplayQuote = new DisplayQuote();
            viewDisplayQuote.Show();
            Hide();

        }

        private void Date_Click(object sender, EventArgs e)
        {

            DateTime d = new DateTime();
            d = DateTime.Now;

            Date.Text = d.ToString("dd.MM.yyyy");
        }

        public enum desktopMaterials
        {
            Oak = 200,
            Laminate = 100,
            Pine = 50,
            Rossewood = 300,
            Veneer = 150
        }



        private void DeskDrawers_ValueChanged(object sender, EventArgs e)
        {
            DeskDrawers.Maximum = 7;
            DeskDrawers.Minimum = 0;
        }

        private void Material_SelectedIndexChanged(object sender, EventArgs e)
        {
        var listOfEnums = Enum.GetValues(typeof(desktopMaterials)).Cast<desktopMaterials>().ToList();
        Material.DataSource = listOfEnums;
        }

    }

}

   

    

    
