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
    
    public partial class Employee
    {
        public Employee()
        {
            this.eventlogs = new HashSet<EventLog>();
            this.sales = new HashSet<Sale>();
            this.shippings = new HashSet<Shipping>();
        }
    
        public string emp_id { get; set; }
        public string emp_name { get; set; }
        public string emp_last { get; set; }
        public string emp_tel { get; set; }
        public int Branch_branch_id { get; set; }
        //public virtual int emp_position { get; set; }
        public virtual Branch branch { get; set; }
        public virtual ICollection<EventLog> eventlogs { get; set; }
        public virtual ICollection<Sale> sales { get; set; }
        public virtual ICollection<Shipping> shippings { get; set; }
    }
}
