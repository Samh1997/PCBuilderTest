using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PcCreator.Shared
{
  
        public class GPU : PCItem
        {

        public double _memory { get; set; }
        public double _cores { get; set ; }
        public double _virtualMemory { get ; set; }
        public string _vendor { get; set; }
        public double _speed { get ; set ; }

        public GPU(int id, string name, double memory, double cores, double virtualMemory, string vendor, double speed) : base (id, name)
            {
              
                this._memory = memory;
                this._cores = cores;
                this._virtualMemory = virtualMemory;
                this._vendor = vendor;
                this._speed = speed;
                this.typeOfComponent = "GPU";
                
            }
        

 
    }
    
}
