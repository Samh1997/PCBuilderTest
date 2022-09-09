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
        public int NumOfItem { get; set; }

        public AllItems()
        {
            pcItems = new List<PCItem>();
            
        }

        public void AddItemToBasket(PCItem i)
        {
            if (pcItems.Contains(i))
            {
                NumOfItem++;
            }
            else 
                pcItems.Add(i);
            
        }

        public void RemoveItemFromBasket(PCItem i)
        {
            if (pcItems.Contains(i) && NumOfItem > 1)
            {
                NumOfItem--;
            }
            else
                pcItems.Remove(i);
                
        }
       
    }
}
