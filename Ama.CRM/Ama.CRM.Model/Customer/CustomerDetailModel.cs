using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Ama.CRM.Infrastructure.Domain;

namespace Ama.CRM.Model.Customer
{
    [Table("CustomerDetail",Schema = "Customer")]
    public class CustomerDetailModel:EntityBase<int>
    {
        #region ForegionKey
        public int? CustomerId { get; set; }
        public int? BranchId { get; set; }
        public byte? CustomerDetailTypeId { get; set; }
        [StringLength(500)]
        public string CustomerDetailValue { get; set; }
        #endregion

        #region NavigationProperties
        [ForeignKey("CustomerId")]
        public CustomerModel Customer { get; set; }
        [ForeignKey("BranchId")]
        public CustomerBranchModel Branch { get; set; }
        [ForeignKey("CustomerDetailTypeId")]
        public CustomerDetailTypeModel CustomerDetailType { get; set; }
        #endregion
        
    }
}
