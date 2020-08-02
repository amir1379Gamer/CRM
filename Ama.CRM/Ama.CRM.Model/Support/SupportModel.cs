using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Ama.CRM.Infrastructure.Domain;

namespace Ama.CRM.Model.Support
{
    [Table("Support", Schema= "Support")]
    public class SupportModel : EntityBase<int>
    {
        public int Duration { get; set; }
        public DateTime? RegisterDate { get; set; }

        #region ForegionKey
        public int? SupportId { get; set; }

        #endregion
        #region NavigationProperties
        [ForeignKey("SupportId")]
        public SupportModel Support { get; set; }
        #endregion
    }
}
