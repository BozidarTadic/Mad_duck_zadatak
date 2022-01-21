using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreChain
{
    public class Bill
    {
        public string date { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string telephone { get; set; }
        public List<Products> products { get; set; }

        public List<string>? serialNumber { get; set; }


    }
}
