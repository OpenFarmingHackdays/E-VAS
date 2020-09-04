using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_VAS.Data.Models
{
    public class TvdModel
    {
        [Key]
        public string TvdId { get; set; }
        //Other data from the TVD
    }
}
