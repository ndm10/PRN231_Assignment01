using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Member
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MemberId { get; set; }

        [Required, MaxLength(20)]
        public string Email { get; set; }

        [MaxLength(30)]
        public string CompanyName { get; set; }

        [MaxLength(15)]
        public string City { get; set; }

        [MaxLength(15)]
        public string Country { get; set; }

        [Required,MaxLength(15)]
        public string Password { get; set; }

        //reference objects
        public virtual ICollection<Order> Orders { get; set; }
    }
}
