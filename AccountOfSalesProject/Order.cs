//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccountOfSalesProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int Order_Id { get; set; }
        public int ClientClient_Id { get; set; }
        public int ProductProduct_Id { get; set; }
        public int ManagerManager_Id { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Product Product { get; set; }
        public virtual Manager Manager { get; set; }
    }
}
