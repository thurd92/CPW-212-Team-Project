//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MediaApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class CastList
    {
        public int MovieID { get; set; }
        public string CastList1 { get; set; }
    
        public virtual Movies Movies { get; set; }
    }
}
