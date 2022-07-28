using PcCreator.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PcCreator.Services.PCItemService
{
    interface IPCitemService
    {
        List<PCItem> pclist { get; set; }
        void LoadPcItems();
        
    }
}
