using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satisfactory_Editor.Items
{
    public class Item
    {
        public double amountCreating;
        public double amountUsing;

        public Item()
        {
            amountCreating = 0.0;
            amountUsing = 0.0;
        }

        public double GetUsage()
        {
            return amountUsing;
        }

        public double GetCreating()
        {
            return amountCreating;
        }
    }


}
