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
    
    public partial class Order
    {
        public Order()
        {
            this.GoodsPositions = new HashSet<GoodsPosition>();
        }
    
        public int Id { get; set; }
        public Nullable<int> InternalNumber { get; set; }
        public string ExternalNumber { get; set; }
        public int CustomerId { get; set; }
        public System.DateTime Date { get; set; }
        public int OrderStatus { get; set; }
        public int ManagerId { get; set; }
        public int CourierType { get; set; }
        public Nullable<int> WarehouseId { get; set; }
        public string Comments { get; set; }
        public string CustomerComments { get; set; }
        public double DeliveryPrice { get; set; }
        public double Discount { get; set; }
        public int PostStatus { get; set; }
        public string PostNumber { get; set; }
        public double RealPrepay { get; set; }
        public Nullable<int> PaymentTypeId { get; set; }
        public string PrepayComments { get; set; }
        public string Number { get; set; }
        public Nullable<int> AxiomusRequestType { get; set; }
        public string Name { get; set; }
        public string Contacts { get; set; }
        public string AxiomusComments { get; set; }
        public Nullable<int> City { get; set; }
        public Nullable<double> FromMkad { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public Nullable<System.DateTime> BeginTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<bool> Cash { get; set; }
        public Nullable<bool> Payments { get; set; }
        public Nullable<bool> SelSize { get; set; }
        public Nullable<int> Office { get; set; }
        public Nullable<System.DateTime> BeginDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<bool> Cheque { get; set; }
        public string Indexx { get; set; }
        public string Region { get; set; }
        public string Area { get; set; }
        public Nullable<int> PostType { get; set; }
        public Nullable<bool> Cod { get; set; }
        public Nullable<System.DateTime> SendDate { get; set; }
        public Nullable<bool> Fragile { get; set; }
        public Nullable<bool> Valuation { get; set; }
        public Nullable<System.DateTime> PrepayDate { get; set; }
        public Nullable<bool> IsCourier { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Flat { get; set; }
        public Nullable<int> AxiomusRegionRequestsRegionId { get; set; }
        public Nullable<int> AxiomusRegionRequestsAddressId { get; set; }
        public Nullable<int> AxiomusRegionRequestsAreaId { get; set; }
        public Nullable<int> AxiomusDPDRequestType { get; set; }
        public string Building { get; set; }
        public Nullable<int> SendManagerId { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Client Client1 { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<GoodsPosition> GoodsPositions { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
