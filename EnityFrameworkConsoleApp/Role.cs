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
    
    public partial class Role
    {
        public Role()
        {
            this.InvitationRoles = new HashSet<InvitationRole>();
            this.Clients = new HashSet<Client>();
            this.MessageChains = new HashSet<MessageChain>();
            this.Permissions = new HashSet<Permission>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<InvitationRole> InvitationRoles { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<MessageChain> MessageChains { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}