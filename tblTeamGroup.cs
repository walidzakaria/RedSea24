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
    
    public partial class tblTeamGroup
    {
        public tblTeamGroup()
        {
            this.tblTeams = new HashSet<tblTeam>();
        }
    
        public int Id { get; set; }
        public string TeamGroup { get; set; }
        public byte[] Logo { get; set; }
    
        public virtual ICollection<tblTeam> tblTeams { get; set; }
    }
}
