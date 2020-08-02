using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ama.CRM.Infrastructure.Domain;
using Ama.CRM.Model.Contract;
using Ama.CRM.Model.Customer;
using Ama.CRM.Model.Group;
using Ama.CRM.Model.Lock;
using Ama.CRM.Model.Role;
using Ama.CRM.Model.Support;
using Ama.CRM.Model.SystemPermission;
using Ama.CRM.Model.User;
using Microsoft.EntityFrameworkCore;

namespace Ama.CRM.Model
{
    public class CrmDbContext : DbContext
    {
        public DbSet<SupportModel> Supports { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<CustomerBranchModel> CustomerBranches { get; set; }
        public DbSet<ContractSaleModel> ContractSales { get; set; }
        public DbSet<ContractPaymentModel> ContractPayments { get; set; }
        public DbSet<ContractPermissionModel> ContractPermissions { get; set; }
        public DbSet<CustomerDetailModel> CustomerDetails { get; set; }
        public DbSet<CustomerDetailTypeModel> CustomerDetailTypes { get; set; }
        public DbSet<GroupModel> Groups { get; set; }
        public DbSet<GroupRoleModel> GroupRoles { get; set; }
        public DbSet<LockModel> LockMs { get; set; }
        public DbSet<RoleModel> Roles { get; set; }
        public DbSet<SystemPermissionModel> SystemPermissions { get; set; }
        public DbSet<SystemPermissionLevelModel> SystemPermissionLevels { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<UserGroupModel> UserGroups { get; set; }
    }
}
