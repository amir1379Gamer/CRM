using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Ama.CRM.Infrastructure.Domain;

namespace Ama.CRM.Model.Customer
{
    [Table("Customer", Schema = "Customer")]
    public class CustomerModel:EntityBase<int>
    {
        [Column(TypeName = "varchar")]
        [StringLength(7)]
        public string Code { get; set; }
        [StringLength(200)]
        [Required]
        public string CustomerName { get; set; }
        [StringLength(200)]
        public string OwnerName { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string NationalCode { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string EconomicalNumber { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string RegistrationNumber { get; set; }
        [StringLength(500)]
        public string OfficeAddress { get; set; }
        [StringLength(500)]
        public string FactoryAddress { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string PostalCode { get; set; }
    }
}
