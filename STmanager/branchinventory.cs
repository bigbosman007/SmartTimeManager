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
    
    public partial class branchinventory
    {
        public branchinventory()
        {
            this.saledetails = new HashSet<saledetail>();
        }
    
        public int bi_id { get; set; }
        public Nullable<int> bi_goods_amount { get; set; }
        public int Branch_branch_id { get; set; }
        public int Goods_goods_id { get; set; }
        public int Goods_Model_mod_id { get; set; }
        public int Goods_Model_Brand_brand_id { get; set; }
    
        public virtual branch branch { get; set; }
        public virtual good good { get; set; }
        public virtual ICollection<saledetail> saledetails { get; set; }
    }
}
