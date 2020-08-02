using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Ama.CRM.Infrastructure.Domain;

namespace Ama.CRM.Model.SystemPermission
{
    [Table("SystemPermissionLevel", Schema = "SystemPermission")]
    public class SystemPermissionLevelModel : EntityBase<byte>
    {
        [StringLength(200), Required]
        public string Name { get; set; }
        [StringLength(500)]
        public string Desc { get; set; }
        #region ForegionKey
        public byte? SystemPermissionId { get; set; }
        #endregion

        #region NavigaitionProperties
        [ForeignKey("SystemPermissionId")]
        public SystemPermissionModel SystemPermission { get; set; }
        #endregion
    }
}
