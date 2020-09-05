using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_VAS.Data.Models
{
    public class GvePlacePointModel
    {
        [Key]
        public int Id { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        
    }
}
