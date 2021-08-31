using Satisfactory_Editor.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satisfactory_Editor.Recipes.Miner
{
    public class RawCopperRecipe : Recipe
    {
        public IDictionary<string, int> itemMaking;

        public RawCopperRecipe()
        {
            itemMaking = new Dictionary<string, int>();
            addItemUsingAndMaking();
        }

        private void addItemUsingAndMaking()
        {
            //add to dictionary the items its making
            itemMaking.Add("rawCopper", 60);
        }

        public override IDictionary<string, Item> addItem(int amount,string purity,string mk, IDictionary<string, Item> Dictionary)
        {
            double purityMult = 0;
            double mkMult = 0;

            switch (purity)
            {
                case "impure":
                    purityMult = 0.5;
                    break;
                case "normal":
                    purityMult = 1.0;
                    break;
                case "pure":
                    purityMult = 1.5;
                    break;
                default:
                    throw new Exception("wrong input");
            }

            switch (mk)
            {
                case "Mk1":
                    mkMult = 1.0;
                    break;
                case "Mk2":
                    mkMult = 2.0;
                    break;
                case "Mk3":
                    mkMult = 4.0;
                    break;
                default:
                    throw new Exception("wrong input");
            }



            foreach (KeyValuePair<string, int> entry in itemMaking)
            {
                
                Dictionary[$"{entry.Key}"].amountCreating += ((itemMaking[$"{entry.Key}"]) * amount * purityMult * mkMult);
            }

            return Dictionary;
        }

        public override IDictionary<string, Item> removeItem(int amount, string purity, string mk, IDictionary<string, Item> Dictionary)
        {


            double purityMult = 0;
            double mkMult = 0;

            switch (purity)
            {
                case "impure":
                    purityMult = 0.5;
                    break;
                case "normal":
                    purityMult = 1.0;
                    break;
                case "pure":
                    purityMult = 1.5;
                    break;
                default:
                    throw new Exception("wrong input");
            }

            switch (mk)
            {
                case "Mk1":
                    mkMult = 1.0;
                    break;
                case "Mk2":
                    mkMult = 2.0;
                    break;
                case "Mk3":
                    mkMult = 4.0;
                    break;
                default:
                    throw new Exception("wrong input");
            }



            foreach (KeyValuePair<string, int> entry in itemMaking)
            {

                Dictionary[$"{entry.Key}"].amountCreating -= ((itemMaking[$"{entry.Key}"]) * amount * purityMult * mkMult);
            }

            return Dictionary;

        }
    }
}
