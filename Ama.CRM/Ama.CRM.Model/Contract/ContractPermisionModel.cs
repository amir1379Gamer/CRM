using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Ama.CRM.Infrastructure.Domain;

namespace Ama.CRM.Model.Contract
{
    [Table("ContractPermission",Schema = "Contract")]
    public class ContractPermissionModel:EntityBase<int>
    {
        #region ForegionKey
        public int? ContractSaleId { get; set; }
        public byte? SystemPermissionLevelId { get; set; }
        #endregion

        #region NavigationProperties
        [ForeignKey("ContractSaleId")]
        public ContractSaleModel ContractSale { get; set; }
        [ForeignKey("SystemPermissionLevelId")]
        public SystemPermissionLevelModel SystemPermissionLevel { get; set; }
        #endregion

    }

}
