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
    
    public partial class shipping
    {
        public shipping()
        {
            this.shippingdetails = new HashSet<shippingdetail>();
        }
    
        public int ship_id { get; set; }
        public string ship_date { get; set; }
        public string Employee_emp_id { get; set; }
        public int Employee_Branch_branch_id { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual ICollection<shippingdetail> shippingdetails { get; set; }
    }
}
