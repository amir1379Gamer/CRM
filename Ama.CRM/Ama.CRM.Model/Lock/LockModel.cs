using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Ama.CRM.Infrastructure.Domain;
using Ama.CRM.Model.Customer;

namespace Ama.CRM.Model.Lock
{
    [Table("Lock",Schema = "Lock")]
   public class LockModel:EntityBase<int>
    {
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string ActivationCode { get; set; }
        public DateTime? ActivationDate { get; set; }
        [StringLength(100)]
        public string ComputerName { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string IpAddress { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string MacAddress { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string HardDiskSerialNum { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string BoardSerialNum { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string CpuSerialNum { get; set; }

        public bool IsDisable { get; set; }

        public DateTime? LastLoginAt { get; set; }
        #region ForegionKey
        [Required]
        public int? CustomerId { get; set; }
        public int? BranchId { get; set; }
        #endregion

        #region NavigationProperties
        [ForeignKey("CustomerId")]
        public CustomerModel Customer { get; set; }
        [ForeignKey("BranchId")]
        public CustomerBranchModel Branch { get; set; }
        #endregion
    }
}
