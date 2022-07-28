namespace PcCreator.Shared
{
    public class Motherboard : PCItem
    {

        public string vendor { get; set; }
        public chipset chipset { get; set; }
        public cpuSocket cpuSocket { get; set; }
        public formFactor formFactor { get; set; }
        public Motherboard(int id, string name, string vendor, chipset chipset, cpuSocket cpuSocket, formFactor formFactor) : base(id, name)
        {
            this.typeOfComponent = "Motherboard";
            this.vendor = vendor;
            this.chipset = chipset;
            this.cpuSocket = cpuSocket;
            this.formFactor = formFactor;
        }
    }
}
