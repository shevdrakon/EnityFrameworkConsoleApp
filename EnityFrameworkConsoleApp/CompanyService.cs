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
    
    public partial class CompanyService
    {
        public CompanyService()
        {
            this.MessageChains = new HashSet<MessageChain>();
            this.UserInfoItems = new HashSet<UserInfoItem>();
        }
    
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int ServiceTypeId { get; set; }
        public string Description { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public virtual ICollection<MessageChain> MessageChains { get; set; }
        public virtual ICollection<UserInfoItem> UserInfoItems { get; set; }
    }
}