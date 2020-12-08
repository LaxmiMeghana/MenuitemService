using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MenuitemService.Models
{
    public class Item
    {
        [Key]

        public int Item_Id { get; set; }

        public double Cost { get; set; }
        public string Item_Name { get; set; }
        public string Category { get; set; }

        //public int Status { get; set; }
    }
}
