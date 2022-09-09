using PcCreator.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PcCreator.Services.PCItemService
{
    public interface IBasketService
    {

        Dictionary<int, int> basket { get; }

        public void AddBasketItem(int pcItem);
        public void LoadBasketItems();
    }
}
