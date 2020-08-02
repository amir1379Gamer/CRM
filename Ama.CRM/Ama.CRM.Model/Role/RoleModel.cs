using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Ama.CRM.Infrastructure.Domain;

namespace Ama.CRM.Model.Role
{
    [Table("Role", Schema = "Role")]
    public class RoleModel : EntityBase<int>
    {
        public int? Parent { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Name { get; set; }
        public byte? RoleAction { get; set; }
    }
}
