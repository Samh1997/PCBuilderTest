using PcCreator.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PcCreator.Services.PCItemService
{
    public class PCItemService : IPCitemService
    {
        public List<PCItem> pclist { get ; set ; } = new List<PCItem> ();

        public void LoadPcItems()
        {
            pclist = new List<PCItem>()
            {
                new GPU(1, "GTX 3070", 8, 16, 5, "Geforce", 3.5),
        new GPU(2, "GTX 3080", 10, 24, 10, "Geforce", 3.9),
        new GPU(3, "GTX 3090", 16, 32, 24, "Geforce", 5),
        new CPU(4, "Ryzen 5 5600", partCompatabile.AMD, 6, 12, 3.5, 4.4),
        new CPU(5, "Ryzen 7 5700", partCompatabile.AMD, 8, 16, 3.4, 4.6),
        new CPU(6, "Ryzen 7 5800", partCompatabile.AMD, 8, 16, 3.8, 4.7),
        new Motherboard(7, "TUF Gaming B550 Ryzen", "ASUS", chipset.AMDB550, cpuSocket.AM4, formFactor.ATX),
        new Motherboard(8, "MPG Z590", "MSI", chipset.INTELZ590, cpuSocket.LGA1200, formFactor.ATX),
        new Ram(9, "Vengeance", "Corsair", 16, RAMGeneration.DDR5, 5600, "Black", false),
        new Ram(10, "CT16G4S", "Crucial", 8, RAMGeneration.DDR4, 2666, "Green", false)
            };
        }
    }
}
