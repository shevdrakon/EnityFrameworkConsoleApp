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
    
    public partial class Phras
    {
        public Phras()
        {
            this.Phrases1 = new HashSet<Phras>();
        }
    
        public int Id { get; set; }
        public int ShopId { get; set; }
        public int Number { get; set; }
        public int PhraseType { get; set; }
        public string PhraseView { get; set; }
        public string Text { get; set; }
        public Nullable<int> ParentId { get; set; }
    
        public virtual ICollection<Phras> Phrases1 { get; set; }
        public virtual Phras Phras1 { get; set; }
        public virtual Shop Shop { get; set; }
    }
}
