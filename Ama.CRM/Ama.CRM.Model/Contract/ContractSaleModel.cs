using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Ama.CRM.Infrastructure.Domain;
using Ama.CRM.Model.Customer;

namespace Ama.CRM.Model.Contract
{
    [Table("ContractSale",Schema = "Contract")]
   public class ContractSaleModel:EntityBase<int>
    {
        [StringLength(50),Required]
        public string ContractNumber { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ContractDate { get; set; }
        [StringLength(500)]
        public string Desc { get; set; }

        #region ForegionKey
        public int? CustomerId { get; set; }
        #endregion

        #region NavigationProperties
        [ForeignKey("CustomerId")]
        public CustomerModel Customer { get; set; }
        #endregion
    }
}
