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
    
    public partial class SaleDetail
    {
        public string sd_id { get; set; }
        public Nullable<int> sd_goods_amount { get; set; }
        public int BranchInventory_bi_id { get; set; }
        public int BranchInventory_Branch_branch_id { get; set; }
        public int BranchInventory_Goods_goods_id { get; set; }
        public int BranchInventory_Goods_Model_mod_id { get; set; }
        public int BranchInventory_Goods_Model_Brand_brand_id { get; set; }
        public string Sale_sale_id { get; set; }
        public string Sale_Employee_emp_id { get; set; }
        public int Sale_Employee_Branch_branch_id { get; set; }
    
        public virtual BranchInventory branchinventory { get; set; }
        public virtual Sale sale { get; set; }
    }
}
