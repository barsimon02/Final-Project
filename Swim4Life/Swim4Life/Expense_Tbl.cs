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
    
    public partial class Expense_Tbl
    {
        public int ExpenseId { get; set; }
        public string ExpenseDate { get; set; }
        public int ExpenseProductId { get; set; }
        public int ExpenseAmount { get; set; }
        public int ExpenseSum { get; set; }
        public string ExpenseProductName { get; set; }
    
        public virtual Product_tbl Product_tbl { get; set; }
    }
}
