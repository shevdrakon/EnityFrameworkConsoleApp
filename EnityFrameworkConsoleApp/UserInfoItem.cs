//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class UserInfoItem
    {
        public int Id { get; set; }
        public short UserInfoItemTypeId { get; set; }
        public int UserInfoId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> LocationTypeId { get; set; }
        public Nullable<int> CompanyServiceId { get; set; }
    
        public virtual CompanyService CompanyService { get; set; }
        public virtual Location Location { get; set; }
        public virtual LocationType LocationType { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}