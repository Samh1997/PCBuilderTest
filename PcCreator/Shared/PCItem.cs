using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcCreator.Shared
{
    public class PCItem
    {
        public int _id { get; }
        public string _name { get; set; }
        public string typeOfComponent { get; set; }


        public PCItem(int id, string name)
        {
            this._id = id;
            this._name = name;
            this.typeOfComponent = "notsetyet";
            
        }
    }
}
