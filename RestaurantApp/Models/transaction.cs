//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class transaction
    {
        public int transactionId { get; set; }
        public int itemId { get; set; }
        public decimal quantity { get; set; }
        public System.DateTime transactionDate { get; set; }
        public Nullable<int> typeId { get; set; }
    }
}