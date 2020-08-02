using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Ama.CRM.Infrastructure.Domain;
using Ama.CRM.Model.Group;

namespace Ama.CRM.Model.User
{
    [Table("UserGroup", Schema = "User")]
    public class UserGroupModel:EntityBase<int>
    {
        #region ForegionKey
        public int? SelectedUserId { get; set; }
        public int? GroupId { get; set; }
        #endregion

        #region NavigationProperties
        [ForeignKey("UserId")]
        public UserModel User { get; set; }
        [ForeignKey("GroupId")]
        public GroupModel Group { get; set; }
        #endregion

    }
}
