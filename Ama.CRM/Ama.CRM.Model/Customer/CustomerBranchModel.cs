using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Ama.CRM.Infrastructure.Domain;

namespace Ama.CRM.Model.Customer
{
    [Table("CustomerBranch",Schema = "Customer")]
    public class CustomerBranchModel:EntityBase<int>
    {
        [Column(TypeName = "varchar")]
        [StringLength(3)]
        [Required]
        public string Code { get; set; }
        [StringLength(200)]
        [Required]
        public string Name { get; set; }
        [StringLength(200)]
        public string ManagerName { get; set; }
        [StringLength(500)]
        public string Address { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string PostalCode { get; set; }
        #region ForegionKey
        public int? CustomerId { get; set; }
        #endregion

        #region NavigationProperties
        [ForeignKey("CustomerId")]
        public CustomerModel Customer { get; set; }
        #endregion

    }
}
