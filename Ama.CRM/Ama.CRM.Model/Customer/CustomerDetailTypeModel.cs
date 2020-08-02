using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Ama.CRM.Infrastructure.Domain;

namespace Ama.CRM.Model.Customer
{
    [Table("CustomerDetailType",Schema = "Customer")]
    public class CustomerDetailTypeModel:EntityBase<int>
    {
        [StringLength(200)]
        public string Title { get; set; }
    }
}
