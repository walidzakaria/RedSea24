//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RedSea24
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblDesignation
    {
        public tblDesignation()
        {
            this.tblFTEs = new HashSet<tblFTE>();
        }
    
        public int Id { get; set; }
        public string Designation { get; set; }
    
        public virtual ICollection<tblFTE> tblFTEs { get; set; }
    }
}
