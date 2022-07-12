using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PiKitchen.Dal.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public String FirstName { get; set; }
        [Required]
        public String LastName { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        // FOREIGN KEYS
        [Required]
        public int AuthenticationLevelId { get; set; }
    }
}
