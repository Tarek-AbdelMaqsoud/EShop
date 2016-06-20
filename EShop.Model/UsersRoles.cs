using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Model
{
    [Table("EShop_UsersRoles")]
    public class UsersRoles
    {
        [Key, DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public long UsersRolesID { get; set; }

        [Required]
        public long RoleID { get; set; }

        [Required]
        public long UserID { get; set; }
    }
}
