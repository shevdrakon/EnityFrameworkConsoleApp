﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnityFrameworkConsoleApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OnlineShopEntities : DbContext
    {
        public OnlineShopEntities()
            : base("name=OnlineShopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Addon> Addons { get; set; }
        public virtual DbSet<Agreement> Agreements { get; set; }
        public virtual DbSet<AgreementText> AgreementTexts { get; set; }
        public virtual DbSet<AjaxSetting> AjaxSettings { get; set; }
        public virtual DbSet<Audit> Audits { get; set; }
        public virtual DbSet<AuditSetting> AuditSettings { get; set; }
        public virtual DbSet<AxiomusRegionRequestsAddress> AxiomusRegionRequestsAddresses { get; set; }
        public virtual DbSet<AxiomusRegionRequestsArea> AxiomusRegionRequestsAreas { get; set; }
        public virtual DbSet<AxiomusRegionRequestsRegion> AxiomusRegionRequestsRegions { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyService> CompanyServices { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CrmSource> CrmSources { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<Good> Goods { get; set; }
        public virtual DbSet<GoodsCategory> GoodsCategories { get; set; }
        public virtual DbSet<GoodsMotion> GoodsMotions { get; set; }
        public virtual DbSet<GoodsPosition> GoodsPositions { get; set; }
        public virtual DbSet<GoodsSize> GoodsSizes { get; set; }
        public virtual DbSet<GoodsType> GoodsTypes { get; set; }
        public virtual DbSet<InvitationRole> InvitationRoles { get; set; }
        public virtual DbSet<Invitation> Invitations { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<LocationType> LocationTypes { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<MailMessageFile> MailMessageFiles { get; set; }
        public virtual DbSet<MailMessage> MailMessages { get; set; }
        public virtual DbSet<MessageChainMessage> MessageChainMessages { get; set; }
        public virtual DbSet<MessageChain> MessageChains { get; set; }
        public virtual DbSet<MessageType> MessageTypes { get; set; }
        public virtual DbSet<NewsBlock> NewsBlocks { get; set; }
        public virtual DbSet<NewsBlockMessage> NewsBlockMessages { get; set; }
        public virtual DbSet<NewsBlockMessageFile> NewsBlockMessageFiles { get; set; }
        public virtual DbSet<NewsBlockMessageFilter> NewsBlockMessageFilters { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Phras> Phrases { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<ServiceType> ServiceTypes { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<UserInfoItem> UserInfoItems { get; set; }
        public virtual DbSet<UserInfo> UserInfos { get; set; }
        public virtual DbSet<Version> Versions { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
    }
}
