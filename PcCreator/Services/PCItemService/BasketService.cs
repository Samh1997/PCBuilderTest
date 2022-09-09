using PcCreator.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PcCreator.Services.PCItemService
{
    public class BasketService : IBasketService
    {
        public BasketService()
        {
        }

        public Dictionary<int, int> basket { get; set; } = new Dictionary<int, int>();
        public void AddBasketItem(int pcItem)
        {
            bool keyExists = basket.ContainsKey(pcItem);
            if (keyExists)
            {
                basket[pcItem]++;
            }
            else
                basket.Add(pcItem, 1);
        }

        public void LoadBasketItems()
        {
            Dictionary<int, int> items = basket;
        }



    }
}
