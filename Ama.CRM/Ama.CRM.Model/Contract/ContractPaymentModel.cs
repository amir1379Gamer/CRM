using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Ama.CRM.Infrastructure.Domain;

namespace Ama.CRM.Model.Contract
{
    [Table("ContractPayment",Schema = "Contract")]
   public class ContractPaymentModel:EntityBase<int>
    {
        public byte PaymentType { get; set; }

        [Column(TypeName = "date")]
        public DateTime PaymentDate { get; set; }

        [StringLength(50)]
        public string Serial { get; set; }

        [StringLength(500)]
        public string Desc { get; set; }

        public long Amount { get; set; }

        [StringLength(50)]
        public string ImageName { get; set; }
        #region ForegionKey
        public int? ContractSaleId { get; set; }
        #endregion

        #region NavigationProperties
        [ForeignKey("ContractSaleId")]
        public ContractSaleModel ContractSale { get; set; }
        #endregion
        
    }
}
