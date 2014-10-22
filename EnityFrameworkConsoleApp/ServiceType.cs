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
    
    public partial class ServiceType
    {
        public ServiceType()
        {
            this.Agreements = new HashSet<Agreement>();
            this.CompanyServices = new HashSet<CompanyService>();
            this.NewsBlockMessageFilters = new HashSet<NewsBlockMessageFilter>();
        }
    
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public string Description { get; set; }
        public string ExternalCode { get; set; }
    
        public virtual ICollection<Agreement> Agreements { get; set; }
        public virtual ICollection<CompanyService> CompanyServices { get; set; }
        public virtual ICollection<NewsBlockMessageFilter> NewsBlockMessageFilters { get; set; }
    }
}
