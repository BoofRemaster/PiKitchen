using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiKitchen.Dal.Entities
{
    public class AuthenticationLevel
    {
        [Key]
        public int AuthenticationLevelId { get; set; }

        [Required]
        public String Name { get; set; }
        [ForeignKey("AuthenticationLevelId")]
        public IEnumerable<User> Users { get; set; }
    }
}
