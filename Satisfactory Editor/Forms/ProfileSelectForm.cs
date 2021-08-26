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

namespace Satisfactory_Editor
{
    public partial class ProfileSelectForm : Form
    {
        public string selectedProfile { get; set; }

        public ProfileSelectForm()
        {
            InitializeComponent();
            
            //check if profile folder exists
            if(!Directory.Exists("Profiles"))
            {
                Directory.CreateDirectory("Profiles");
            }

            string[] allProfiles = Directory.GetDirectories("Profiles");


            //check if a profile exists
            if (allProfiles.Length != 0) 
            {
                //loop through and add everything to the combo box
                foreach (string profile in allProfiles)
                {
                    comboBox1.Items.Add(profile.Substring(9));
                }
            }


        }

        private void createNewProfileButton_Click(object sender, EventArgs e)
        {
            //run create profile form
            ProfileCreateForm tempForm = new ProfileCreateForm();
            tempForm.Show();
            tempForm.Location = this.Location;
            this.Dispose();
        }

        private void SelectProfileButton_Click(object sender, EventArgs e)
        {
            //get the combobox item
            if(comboBox1.Text != "")
            {
                //get the string
                string profileSelected = comboBox1.Text;


                //load the profile
            }
        }
    }
}
