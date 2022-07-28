using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PcCreator.Shared
{
    public class AllItems
    {
        public List<PCItem> pcItems { get; set; }

        public AllItems()
        {
            pcItems = new();
        }

       /* public void addItem(PCItem p)
        {
            pcItems.Add(p);
        }*/
    }
}
