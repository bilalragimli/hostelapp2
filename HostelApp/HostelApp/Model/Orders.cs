//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HostelApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int Id { get; set; }
        public Nullable<int> RoomId { get; set; }
        public Nullable<int> ClientId { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<System.DateTime> BuyDate { get; set; }
        public Nullable<double> TotalSum { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual Rooms Rooms { get; set; }
    }
}