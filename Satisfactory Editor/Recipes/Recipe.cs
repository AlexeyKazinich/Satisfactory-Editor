using Satisfactory_Editor.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satisfactory_Editor.Recipes
{
    public abstract class Recipe
    {
        /* Precondition: the value "amount" needs to be smaller or equal to the available items in the Dictionary
         * This method Expects: amount of buildings, the Dictionary with all the items.
         * PostCondition: returns the Dictionary with all the items updated
         */
        public virtual IDictionary<string, Item> addItem(int amount, IDictionary<string, Item> Dictionary)
        {
            return Dictionary;
        }

        /* Precondition: the value "amount" needs to be smaller or equal to the available items in the Dictionary
         * This method Expects: amount of buildings, the Dictionary with all the items.
         * PostCondition: returns the Dictionary with all the items updated
         */
        public virtual IDictionary<string, Item> removeItem(int amount, IDictionary<string, Item> Dictionary)
        {
            return Dictionary;
        }

        /* Precondition: the value "amount" needs to be smaller or equal to the available, purity needs to be either "pure, normal, impure",
         * Mk must be either "Mk1, Mk2, Mk3" and Dictionary needs to be the item Dictionary
         * Postcondition: returns the Dictionary with all the items updated
         * This is an overload method, and its created for Miners as they require more parameters
         */
        public virtual IDictionary<string,Item> addItem(int amount, string purity, string mk, IDictionary<string, Item> Dictionary)
        {
            return Dictionary;
        }
        public virtual IDictionary<string, Item> removeItem(int amount, string purity, string mk, IDictionary<string, Item> Dictionary)
        {
            return Dictionary;
        }
    }
}
