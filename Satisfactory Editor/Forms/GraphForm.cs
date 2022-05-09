using LiveCharts;
using LiveCharts.Wpf;
using Satisfactory_Editor.Helper_Classes;
using Satisfactory_Editor.Items;
using Satisfactory_Editor.Recipes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satisfactory_Editor.Forms
{
    public partial class GraphForm : Form
    {
        private ChartValues<double> ValuesMaking = new ChartValues<double>();
        private ChartValues<double> ValuesUsing = new ChartValues<double>();
        private string[] ValuesString = new string[100];


        public GraphForm(IDictionary<string, Item> MyItemDictionary, IDictionary<string, Recipe> MyRecipeDictionary)
        {
            InitializeComponent();
            fillVarsFromItemDictionary(MyRecipeDictionary,MyItemDictionary);

            cartesianChart1.Series = new SeriesCollection
            {
                new StackedRowSeries
                {
                    Values = ValuesMaking,
                    StackMode = StackMode.Percentage,
                    DataLabels = true,
                    LabelPoint = p => p.X.ToString()

                },
                new StackedRowSeries
                {
                    Values = ValuesUsing,
                    StackMode = StackMode.Percentage,
                    DataLabels = true,
                    LabelPoint = p => p.X.ToString(),
                }


            };

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "item",
                Labels = ValuesString
            });

            cartesianChart1.AxisX.Add(new Axis
            {
                LabelFormatter = val => val.ToString("P")
            });

            var tooltip = new DefaultTooltip { SelectionMode = TooltipSelectionMode.SharedYValues };

            cartesianChart1.DataTooltip = tooltip;

        }

        private void fillVarsFromDictionary(IDictionary<string,Item> MyDictionary)
        {
            //fills valuesMaking, ValuesUsing, and ValuesString with all the Dictionary Items

            
            foreach(KeyValuePair<string,Item> entry in MyDictionary)
            {
                ValuesMaking.Add(entry.Value.amountCreating);
                ValuesUsing.Add(entry.Value.amountUsing);
                ValuesString.Append(entry.Key);
            }
            

            /*
            ValuesMaking.Add(MyDictionary["rawCopper"].amountCreating);
            ValuesMaking.Add(MyDictionary["rawIron"].amountCreating);
            ValuesMaking.Add(MyDictionary["limeStone"].amountCreating);
            ValuesMaking.Add(MyDictionary["coal"].amountCreating);

            ValuesUsing.Add(MyDictionary["rawCopper"].amountUsing);
            ValuesUsing.Add(MyDictionary["rawIron"].amountUsing);
            ValuesUsing.Add(MyDictionary["limeStone"].amountUsing);
            ValuesUsing.Add(MyDictionary["coal"].amountUsing);

            ValuesString.Append("rawCopper");
            ValuesString.Append("rawIron");
            ValuesString.Append("limestone");
            ValuesString.Append("coal");
            */
        }

        private void fillVarsFromItemDictionary(IDictionary<string,Recipe> MyRecipeDictionary, IDictionary<string,Item> MyItemDictionary)
        {
            //assume copper ingor recipe
            foreach(KeyValuePair<string,int> entry in MyRecipeDictionary["copperIngotRecipe"].GetItemUsing())
            {

                ValuesMaking.Add(MyItemDictionary[entry.Key].amountCreating);
                ValuesUsing.Add(MyItemDictionary[entry.Key].amountUsing);
                ValuesString.Append(entry.Key);
            }
            foreach(KeyValuePair<string,int> entry in MyRecipeDictionary["copperIngotRecipe"].GetItemMaking())
            {
                ValuesMaking.Add(MyItemDictionary[entry.Key].amountCreating);
                ValuesUsing.Add(MyItemDictionary[entry.Key].amountUsing);
                ValuesString.Append(entry.Key);

            }
            
            
        }
        private void GraphForm_Load(object sender, EventArgs e)
        {

        }

        private void GraphForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            this.Dispose();
        }
    }
}
