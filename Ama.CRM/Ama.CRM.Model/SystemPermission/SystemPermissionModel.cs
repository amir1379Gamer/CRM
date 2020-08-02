using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Ama.CRM.Infrastructure.Domain;

namespace Ama.CRM.Model.SystemPermission
{
    [Table("SystemPermission", Schema = "SystemPermission")]
    public class SystemPermissionModel : EntityBase<int>
    {
        [StringLength(200), Required]
        public string Name { get; set; }
    }
}
