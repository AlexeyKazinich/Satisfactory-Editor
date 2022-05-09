using Satisfactory_Editor.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satisfactory_Editor.Recipes.Smelter
{
    public class IronIngotRecipe : Recipe
    {
        public IDictionary<string, int> itemUsing;
        public IDictionary<string,int> itemMaking; 

        public IronIngotRecipe()
        {
            itemUsing = new Dictionary<string, int>();
            itemMaking = new Dictionary<string, int>();
            AddItemUsingAndMaking();
        }

        private void AddItemUsingAndMaking()
        {
            //add to dictionary the items its using
            itemUsing.Add("rawIron", 30);

            //add to dictionary the items its making
            itemMaking.Add("ironIngot", 30);
        }

        public override IDictionary<string, Item> AddItem(int amount, IDictionary<string, Item> Dictionary)
        {

            foreach (KeyValuePair<string,int> entry in itemUsing)
            {
                Dictionary[$"{entry.Key}"].amountUsing += ((itemUsing[$"{entry.Key}"])*amount);
            }


            foreach (KeyValuePair<string,int> entry in itemMaking)
            {
                Dictionary[$"{entry.Key}"].amountCreating += ((itemMaking[$"{entry.Key}"])*amount);
            }

            return Dictionary;
        }



        public override IDictionary<string, Item> RemoveItem(int amount, IDictionary<string, Item> Dictionary)
        {
            //removes items Using from Dictionary
            foreach (KeyValuePair<string, int> entry in itemUsing)
            {
                Dictionary[$"{entry.Key}"].amountUsing -= ((itemUsing[$"{entry.Key}"]) * amount);
            }

            //removes items Making from Dictionary
            foreach (KeyValuePair<string, int> entry in itemMaking)
            {
                Dictionary[$"{entry.Key}"].amountCreating -= ((itemMaking[$"{entry.Key}"]) * amount);
            }

            return Dictionary;

        }

        public override IDictionary<string, int> GetItemMaking()
        {
            throw new NotImplementedException();
        }

        public override IDictionary<string, int> GetItemUsing()
        {
            throw new NotImplementedException();
        }
    }
}
