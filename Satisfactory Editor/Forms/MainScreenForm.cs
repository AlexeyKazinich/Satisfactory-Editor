using Satisfactory_Editor.Helper_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satisfactory_Editor
{
    public partial class MainScreenForm : Form
    {
        private string profileName = "";
        private Factory myFactory;
        public MainScreenForm(string profile)
        {
            InitializeComponent();
            profileName = profile;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            myFactory = new Factory(profileName);

        }

        
        private void MainScreenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save all the data before closing
            myFactory.save();
        }
    }
}
