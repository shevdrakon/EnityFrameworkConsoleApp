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
    
    public partial class InvitationRole
    {
        public int Id { get; set; }
        public int InvitationId { get; set; }
        public int RoleId { get; set; }
    
        public virtual Invitation Invitation { get; set; }
        public virtual Role Role { get; set; }
    }
}
