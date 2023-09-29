using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        [Required]
        public float Weight { get;set; }

        [Required]
        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        //reference object
        public virtual Category Category { get; set; }
    }
}
