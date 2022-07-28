namespace PcCreator.Shared
{
    public interface IGPUitem
    {
        double _memory { get; set; }
        double _cores { get; set; }
        double _virtualMemory { get; set; }
        string _vendor { get; set; }
        double _speed { get; set; }



        
    }
}
