using Newtonsoft.Json;
using Satisfactory_Editor.Items;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satisfactory_Editor.Helper_Classes
{
    public class Factory
    {
        public List<Item> itemsList = new List<Item>();
        public IDictionary<string, Item> itemDictionary = new Dictionary<string, Item>();
        private string profileSelected = "";
        public Factory(string profile)
        {
            profileSelected = profile;
            checkContents();
        }

        private void readProfile()
        {
            using (StreamReader file = new StreamReader($"Profiles/{profileSelected}/{profileSelected}.json"))
            {
                itemDictionary = JsonConvert.DeserializeObject<IDictionary<string,Item>>(file.ReadToEnd());
            }
        }

        private void writeToProfile()
        {
            using (StreamWriter myFile2 = new StreamWriter($"Profiles/{profileSelected}/{profileSelected}.json"))
            {
                myFile2.WriteLine(JsonConvert.SerializeObject(itemDictionary));
            }
        }

        private void createProfile()
        {
            //add all items to the list
            addAllItems();
            //write to profile to create a json
            writeToProfile();

        }

        private void addAllItems()
        {
            //Miner
            itemDictionary.Add("rawCopper", new Item());
            itemDictionary.Add("rawIron", new Item());
            itemDictionary.Add("limeStone", new Item());
            itemDictionary.Add("coal", new Item());
            itemDictionary.Add("rawCaterium", new Item());
            itemDictionary.Add("quartz", new Item());
            itemDictionary.Add("sulfur", new Item());
            itemDictionary.Add("bauxite", new Item());
            itemDictionary.Add("uranium", new Item());

            //liquids
            itemDictionary.Add("water", new Item());
            itemDictionary.Add("crudeOil", new Item());
            itemDictionary.Add("heavyOilResidue", new Item());
            itemDictionary.Add("fuel", new Item());
            itemDictionary.Add("liquidBioFuel", new Item());
            itemDictionary.Add("truboFuel", new Item());
            itemDictionary.Add("aluminaSolution", new Item());
            itemDictionary.Add("sulfuricAcid", new Item());
            itemDictionary.Add("nitricAcid", new Item());

            //gas
            itemDictionary.Add("nitrogenGas", new Item());

            //Smelter
            itemDictionary.Add("ironIngot", new Item());
            itemDictionary.Add("copperIngot", new Item());
            itemDictionary.Add("cateriumIngot", new Item());
            itemDictionary.Add("AluminumIngot", new Item());

            //Foundry
            itemDictionary.Add("steelIngot", new Item());

            //Constructor
            itemDictionary.Add("concrete", new Item());
            itemDictionary.Add("quartzCrystal", new Item());
            itemDictionary.Add("cable", new Item());
            itemDictionary.Add("wire", new Item());
            itemDictionary.Add("screw", new Item());
            itemDictionary.Add("ironPlate", new Item());
            itemDictionary.Add("ironRod", new Item());
            itemDictionary.Add("copperSheet", new Item());
            itemDictionary.Add("aluminumCasing", new Item());
            itemDictionary.Add("steelBeam", new Item());
            itemDictionary.Add("steelPipe", new Item());
            itemDictionary.Add("copperPowder", new Item());
            itemDictionary.Add("silica", new Item());
            itemDictionary.Add("quickWire", new Item());
            itemDictionary.Add("", new Item());

            //Assembler
            itemDictionary.Add("ReinforcedIronPlate", new Item());
            itemDictionary.Add("circuitBoard", new Item());
            itemDictionary.Add("modularFrame", new Item());
            itemDictionary.Add("rotor", new Item());
            itemDictionary.Add("alcladAluminumSheet", new Item());
            itemDictionary.Add("enchasedIndustrialBeam", new Item());
            itemDictionary.Add("motor", new Item());
            itemDictionary.Add("stator", new Item());
            itemDictionary.Add("aiLimiter", new Item());
            itemDictionary.Add("fabric", new Item());
            itemDictionary.Add("heatSink", new Item());
            itemDictionary.Add("encasedPlutoniumCell", new Item());

            //ManuFacturer
            itemDictionary.Add("radioControlUnit", new Item());
            itemDictionary.Add("crystalOscillator", new Item());
            itemDictionary.Add("heavyModularFrame", new Item());
            itemDictionary.Add("computer", new Item());
            itemDictionary.Add("battery", new Item());
            itemDictionary.Add("superComputer", new Item());
            itemDictionary.Add("highSpeedConnector", new Item());
            itemDictionary.Add("plutoniumFuelRod", new Item());
            itemDictionary.Add("uraniumFuelRod", new Item());
            itemDictionary.Add("turboMotor", new Item());
            itemDictionary.Add("beacon", new Item());
            itemDictionary.Add("encasedUraniumCell", new Item());
            itemDictionary.Add("gasFilter", new Item());
            itemDictionary.Add("iodineInfusedFilter", new Item());
            itemDictionary.Add("rifleCartridge", new Item());
            //Refinery
            itemDictionary.Add("polymerResin", new Item());
            itemDictionary.Add("petroleumCoke", new Item());
            itemDictionary.Add("plastic", new Item());
            itemDictionary.Add("rubber", new Item());
            itemDictionary.Add("aluminumScrap", new Item());
            itemDictionary.Add("packagedFuel", new Item());

            //Blender
            itemDictionary.Add("coolingSystem", new Item());
            itemDictionary.Add("non-fissleUranium", new Item());
            itemDictionary.Add("fusedModularFrame", new Item());

            //Packager
            itemDictionary.Add("packagedLiquidBioFuel", new Item());
            itemDictionary.Add("packagedOil", new Item());
            itemDictionary.Add("packagedHeavyOilResidue", new Item());
            itemDictionary.Add("packagedWater", new Item());
            itemDictionary.Add("emptyCanister", new Item());
            itemDictionary.Add("packagedAluminaSolution", new Item());
            itemDictionary.Add("packagedTurboFuel", new Item());
            itemDictionary.Add("packagedSulfuricAcid", new Item());
            itemDictionary.Add("packagedNitrogenGas", new Item());
            itemDictionary.Add("emptyFluidTank", new Item());
            itemDictionary.Add("packagedNitricAcid", new Item());

            //particle accelerator
            itemDictionary.Add("plutoniumPellet", new Item());
            

            //for space elevator
            itemDictionary.Add("smartPlating", new Item());
            itemDictionary.Add("automatedWiring", new Item());
            itemDictionary.Add("versatileFramework", new Item());
            itemDictionary.Add("assemblyDirectorSystem", new Item());
            itemDictionary.Add("modularEngine", new Item());
            itemDictionary.Add("adaptiveControlUnit", new Item());
            itemDictionary.Add("magneticFieldGenerator", new Item());
            itemDictionary.Add("thermalPropulsionRocket", new Item());
            itemDictionary.Add("nuclearPasta", new Item());

        }

        private void checkContents()
        {
            //check if the json exists in the profile
            if (!File.Exists($"Profiles/{profileSelected}/{profileSelected}.json"))
            {
                //create file
                createProfile();
            }
            else
            {
                //read the json file
                readProfile();
            }
        }


        public void save()
        {
            //when the user closes the form save all the content
            writeToProfile();
        }



    }
}
