using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satisfactory_Editor.Recipes.Miner
{
    public class LimestoneRecipe : Recipe
    {
        public IDictionary<string, int> itemMaking; //only making 1 item and doesnt use any items

        public LimestoneRecipe()
        {
            itemMaking = new Dictionary<string, int>();
            //addItemUsingAndMaking();
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
