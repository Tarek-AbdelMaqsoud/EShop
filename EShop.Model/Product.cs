using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Model
{
    [Table("EShop_Product")]
    public class Product
    {
        [Key, DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public long ProductID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        [Range(0.0, int.MaxValue)]
        public double Price { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Count { get; set; }
    }
}
