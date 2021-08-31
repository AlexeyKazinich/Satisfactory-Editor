using Satisfactory_Editor.Forms;
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
            updateAllDropDowns();


        }

        //sets the initial value for the dropbox
        private void updateAllDropDowns()
        {
            //miner drop downs
            comboBoxMinerPurity.SelectedItem = "normal";
            comboBoxMinerMk.SelectedItem = "Mk1";
        }

        
        private void MainScreenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save all the data before closing
            myFactory.save();
        }


        #region buttons

        #region Raw Copper
        private void buttonAddRawCopper_Click(object sender, EventArgs e)
        {
            int amount = Int32.Parse(textBoxRawCopper.Text);
            string purity = comboBoxMinerPurity.Text;
            string mk = comboBoxMinerMk.Text;
            myFactory.recipeDictionary["rawCopperRecipe"].addItem(amount, purity, mk, myFactory.itemDictionary);
            textBoxRawCopper.Text = "Raw Copper";
            
        }

        private void buttonRemoveRawCopper_Click(object sender, EventArgs e)
        {
            int amount = Int32.Parse(textBoxRawCopper.Text);
            string purity = comboBoxMinerPurity.Text;
            string mk = comboBoxMinerMk.Text;
            myFactory.recipeDictionary["rawCopperRecipe"].removeItem(amount, purity, mk, myFactory.itemDictionary);
            textBoxRawCopper.Text = "Raw Copper";
        }

        private void textBoxRawCopper_Click(object sender, EventArgs e)
        {
            textBoxRawCopper.Text = "";
        }



        #endregion

        #region Raw Iron
        private void buttonRawIronAdd_Click(object sender, EventArgs e)
        {
            int amount = Int32.Parse(textBoxRawIron.Text);
            string purity = comboBoxMinerPurity.Text;
            string mk = comboBoxMinerMk.Text;
            myFactory.recipeDictionary["rawIronRecipe"].addItem(amount, purity, mk, myFactory.itemDictionary);
            textBoxRawCopper.Text = "Raw Iron";

        }

        private void buttonRawIronRemove_Click(object sender, EventArgs e)
        {
            int amount = Int32.Parse(textBoxRawIron.Text);
            string purity = comboBoxMinerPurity.Text;
            string mk = comboBoxMinerMk.Text;
            myFactory.recipeDictionary["rawIronRecipe"].removeItem(amount, purity, mk, myFactory.itemDictionary);
            textBoxRawCopper.Text = "Raw Iron";
        }

        private void textBoxRawIron_Click(object sender, EventArgs e)
        {
            textBoxRawIron.Text = "";
        }


        #endregion

        #endregion

        #region comboBoxes for Miners
        private void comboBoxMinerPurity_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxMinerMk_SelectedIndexChanged(object sender, EventArgs e)
        {
        }



        #endregion

        #region Allow only numbers in textboxes
        private void textBoxRawCopper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxRawIron_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        #endregion

        private void buttonOpenGraph_Click(object sender, EventArgs e)
        {
            //create new window
            GraphForm tempFormGraph = new GraphForm();
            tempFormGraph.Show();
            tempFormGraph.Location = this.Location;
        }
    }
}
