using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Models
{
    public class UserModel
    {
        [Required]
        [StringLength(50)]
        public String FullName { get; set; }

        [Required]
        [EmailAddress]
        public String EmailId { get; set; }
    }
}