using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satisfactory_Editor.Items
{
    
    public class RawIron
    {
        public int amountCreating { get; set; }
        public int amountUsing { get; set; }

        public RawIron()
        {
            amountCreating = 0;
            amountUsing = 0;
        }

        public int getUsage()
        {
            return amountUsing;
        }
    }
}
