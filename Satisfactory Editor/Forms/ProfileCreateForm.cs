using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satisfactory_Editor
{
    public partial class ProfileCreateForm : Form
    {
        private bool allowSave = false;
        public ProfileCreateForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checks if the profile name already exists
            if (Directory.Exists($"Profiles/{textBox1.Text}") == true)
            {
                labelTaken();
            }
            else
                labelAvailable();
        }

        private void labelAvailable()
        {
            resultLabel.Text = "Available";
            resultLabel.ForeColor = Color.Green;
            allowSave = true;
        }

        private void labelTaken()
        {
            resultLabel.Text = "Taken";
            resultLabel.ForeColor = Color.Red;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (allowSave)
            {
                //create directory 
                Directory.CreateDirectory($"Profiles/{textBox1.Text}");

                //change form
                ProfileSelectForm tempForm = new ProfileSelectForm();
                tempForm.Show();
                tempForm.Location = this.Location;
                this.Dispose();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //prevent user from checking a valid input and then changing input and saving causing an overwrite
            allowSave = false;
        }
    }
}
