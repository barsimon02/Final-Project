//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Swim4Life
{
    using System;
    using System.Collections.Generic;
    
    public partial class WorkShop_Tbl
    {
        public int WorkShopId { get; set; }
        public string WorkShopName { get; set; }
        public string WorkShopDate { get; set; }
        public int WorkShopEmployee { get; set; }
        public string WorkShopEmployeeName { get; set; }
    
        public virtual Employees_Tbl Employees_Tbl { get; set; }
    }
}