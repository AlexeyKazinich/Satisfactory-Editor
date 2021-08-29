using Satisfactory_Editor.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satisfactory_Editor.Recipes
{
    public abstract class Recipes
    {
        /* Precondition: the value "amount" needs to be smaller or equal to the available items in the Dictionary
         * This method Expects: amount of buildings, the Dictionary with all the items.
         * PostCondition: returns the Dictionary with all the items updated
         */
        public abstract IDictionary<string, Item> addItem(int amount, IDictionary<string, Item> Dictionary);

        /* Precondition: the value "amount" needs to be smaller or equal to the available items in the Dictionary
         * This method Expects: amount of buildings, the Dictionary with all the items.
         * PostCondition: returns the Dictionary with all the items updated
         */
        public abstract IDictionary<string, Item> removeItem(int amount, IDictionary<string, Item> Dictionary);
    }
}
