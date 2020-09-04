using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_VAS.Data.Models
{
    public class GveLocationModel
    {
        public string GveId { get; set; }
        public string Coordinates { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
