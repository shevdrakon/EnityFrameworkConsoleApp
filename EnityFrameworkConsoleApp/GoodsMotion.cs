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
    
    public partial class GoodsMotion
    {
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public int GoodsMotionType { get; set; }
        public int WarehouseId { get; set; }
        public int GoodsId { get; set; }
        public int GoodsSizeId { get; set; }
        public int Quantity { get; set; }
        public string Comments { get; set; }
    
        public virtual Good Good { get; set; }
        public virtual GoodsSize GoodsSize { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
