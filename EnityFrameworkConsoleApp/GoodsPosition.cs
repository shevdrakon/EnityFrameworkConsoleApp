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
    
    public partial class GoodsPosition
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int GoodsId { get; set; }
        public int GoodsSizeId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    
        public virtual Good Good { get; set; }
        public virtual GoodsSize GoodsSize { get; set; }
        public virtual Order Order { get; set; }
    }
}
