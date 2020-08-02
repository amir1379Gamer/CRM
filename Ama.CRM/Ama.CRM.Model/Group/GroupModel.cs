using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Ama.CRM.Infrastructure.Domain;

namespace Ama.CRM.Model.Group
{
    [Table("Group",Schema = "Group")]
   public class GroupModel:EntityBase<int>
    {
        [StringLength(200),Required]
        public string Name { get; set; }

        [StringLength(500)]
        public string Desc { get; set; }
        public bool IsDisable { get; set; }
    }
}
