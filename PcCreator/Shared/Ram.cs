namespace PcCreator.Shared
{
    public class Ram : PCItem
    {

        public string vendor { get; set; }
        public double size { get; set; }
        public RAMGeneration generation { get; set; }
        public double speed { get; set; }
        public string colour { get; set; }
        public bool rgb { get; set; }
        public Ram(int id, string name, string vendor, double size, RAMGeneration generation, double speed, string colour, bool rgb) : base(id,name)
        {
            this.vendor = vendor;
            this.size = size;
            this.generation = generation;
            this.speed = speed;
            this.colour = colour;
            this.rgb = rgb;
            this.typeOfComponent = "Ram";
        }
    }
}
