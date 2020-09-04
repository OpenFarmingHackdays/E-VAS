using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_VAS.Data.Models
{
    public class GveModel
    {
        [Key]
        public string GveId { get; set; }
        public string Name { get; set; }
        public TvdModel Tvd { get; set; }
    }
}
