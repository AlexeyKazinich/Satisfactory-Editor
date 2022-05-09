using Satisfactory_Editor.Forms;
using Satisfactory_Editor.Helper_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satisfactory_Editor
{
    public partial class MainScreenForm : Form
    {
        private string profileName = "";
        private Factory myFactory;

        private enum Building
        {
            Miner,
            Smelter,
            Constructor,
            Assembler,
            Manufacturer,
        }

        private Building buildingState = Building.Miner; //starts off with miner

        public MainScreenForm(string profile)
        {
            InitializeComponent();
            profileName = profile;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            myFactory = new Factory(profileName);
            UpdateAllDropDowns();

        }

        //sets the initial value for the dropbox
        private void UpdateAllDropDowns()
        {
            //miner drop downs
            comboBoxMinerPurity.SelectedItem = "normal";
            comboBoxMinerMk.SelectedItem = "Mk1";
        }

        
        private void MainScreenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save all the data before closing
            myFactory.Save();
        }


        #region buttons

        #region Raw Copper
        private void ButtonAddRawCopper_Click(object sender, EventArgs e)
        {
            int amount = Int32.Parse(textBoxRawCopper.Text);
            string purity = comboBoxMinerPurity.Text;
            string mk = comboBoxMinerMk.Text;
            myFactory.recipeDictionary["rawCopperRecipe"].AddItem(amount, purity, mk, myFactory.itemDictionary);
            textBoxRawCopper.Text = "Raw Copper";
            
        }

        private void ButtonRemoveRawCopper_Click(object sender, EventArgs e)
        {
            int amount = Int32.Parse(textBoxRawCopper.Text);
            string purity = comboBoxMinerPurity.Text;
            string mk = comboBoxMinerMk.Text;
            myFactory.recipeDictionary["rawCopperRecipe"].RemoveItem(amount, purity, mk, myFactory.itemDictionary);
            textBoxRawCopper.Text = "Raw Copper";
        }

        private void TextBoxRawCopper_Click(object sender, EventArgs e)
        {
            textBoxRawCopper.Text = "";
        }



        #endregion

        #region Raw Iron
        private void ButtonRawIronAdd_Click(object sender, EventArgs e)
        {
            int amount = Int32.Parse(textBoxRawIron.Text);
            string purity = comboBoxMinerPurity.Text;
            string mk = comboBoxMinerMk.Text;
            myFactory.recipeDictionary["rawIronRecipe"].AddItem(amount, purity, mk, myFactory.itemDictionary);
            textBoxRawCopper.Text = "Raw Iron";

        }

        private void ButtonRawIronRemove_Click(object sender, EventArgs e)
        {
            int amount = Int32.Parse(textBoxRawIron.Text);
            string purity = comboBoxMinerPurity.Text;
            string mk = comboBoxMinerMk.Text;
            myFactory.recipeDictionary["rawIronRecipe"].RemoveItem(amount, purity, mk, myFactory.itemDictionary);
            textBoxRawCopper.Text = "Raw Iron";
        }

        private void TextBoxRawIron_Click(object sender, EventArgs e)
        {
            textBoxRawIron.Text = "";
        }


        #endregion

        #region Limestone

        #endregion

        #region Coal

        #endregion

        #region Quartz

        #endregion

        #endregion buttons

        #region comboBoxes for Miners
        private void ComboBoxMinerPurity_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ComboBoxMinerMk_SelectedIndexChanged(object sender, EventArgs e)
        {
        }



        #endregion

        #region Allow only numbers in textboxes
        private void TextBoxRawCopper_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TextBoxRawIron_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ButtonOpenGraph_Click(object sender, EventArgs e)
        {
            //create new window
            GraphForm tempFormGraph = new GraphForm(myFactory.itemDictionary, myFactory.recipeDictionary);
            tempFormGraph.Show();
            tempFormGraph.Location = this.Location;
        }
    }
}
