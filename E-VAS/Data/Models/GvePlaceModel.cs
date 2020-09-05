using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_VAS.Data.Models
{
    public class GvePlaceModel
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public List<GvePlacePointModel> Points {get; set; }
    }
}
