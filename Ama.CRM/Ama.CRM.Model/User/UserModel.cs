using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Ama.CRM.Infrastructure.Domain;

namespace Ama.CRM.Model.User
{
    [Table("User",Schema = "User")]
    public class UserModel:EntityBase<int>
    {
        [StringLength(50),Required]
        public string Username { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string CellPhone { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(100),Required]
        public string Email { get; set; }
        [StringLength(200)]
        public string Avatar { get; set; }

        public bool IsDisable { get; set; }

        public bool RequiredChangePassword { get; set; }

        public bool CannotChangePassword { get; set; }

        public DateTime? LastLoginAt { get; set; }

    }
}
