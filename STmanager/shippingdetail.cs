//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace STmanager
{
    using System;
    using System.Collections.Generic;
    
    public partial class shippingdetail
    {
        public int sd_id { get; set; }
        public Nullable<int> sd_goods_amount { get; set; }
        public int Shipping_ship_id { get; set; }
        public string Shipping_Employee_emp_id { get; set; }
        public int Shipping_Employee_Branch_branch_id { get; set; }
        public int Goods_goods_id { get; set; }
        public int Goods_Model_mod_id { get; set; }
        public int Goods_Model_Brand_brand_id { get; set; }
    
        public virtual good good { get; set; }
        public virtual shipping shipping { get; set; }
    }
}
