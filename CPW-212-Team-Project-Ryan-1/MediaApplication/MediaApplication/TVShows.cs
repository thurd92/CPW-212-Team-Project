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
    
    public partial class TVShows
    {
        public int TVID { get; set; }
        public string TVName { get; set; }
        public string TVGenre { get; set; }
        public int CastID { get; set; }
        public int AwardsID { get; set; }
    
        public virtual Awards Awards { get; set; }
        public virtual CastList CastList { get; set; }
    }
}
