//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kontrola_Domowego_Budzetu.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Income
    {
        public int IncomeId { get; set; }
        public Nullable<decimal> Value { get; set; }
        public string Name { get; set; }
        public Nullable<int> PersonId { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual Person Person { get; set; }
    }
}