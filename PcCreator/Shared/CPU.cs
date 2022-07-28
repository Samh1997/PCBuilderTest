namespace PcCreator.Shared
{
    public class CPU : PCItem
    {

        public partCompatabile pCompat { get; set; }
        public int cores { get; set; }
        public int threads { get; set; }
        public double speed { get; set; }
        public double boostSpeed { get; set; }
        public CPU(int id, string name, partCompatabile pc, int cores, int threads, double speed, double boostSpeed) :base(id, name)
        {
            this.pCompat = pc;
            this.cores = cores;
            this.threads = threads;
            this.speed = speed;
            this.boostSpeed = boostSpeed;
            this.typeOfComponent = "CPU";
        }
        
    }
}
