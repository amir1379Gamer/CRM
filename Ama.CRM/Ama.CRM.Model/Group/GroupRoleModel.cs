using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Ama.CRM.Infrastructure.Domain;

namespace Ama.CRM.Model.Group
{
    [Table("GroupRole", Schema = "Group")]
    public class GroupRoleModel : EntityBase<int>
    {
        #region ForegionKey
        public int? GroupId { get; set; }
        public int? RoleId { get; set; }
        #endregion

        #region NavigationProperties
        [ForeignKey("GroupId")]
        public GroupModel Group { get; set; }
        [ForeignKey("RoleId")]
        public RoleModel Role { get; set; }
        #endregion
    }
}
