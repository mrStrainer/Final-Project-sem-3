//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsersAtParty
    {
        public long userID { get; set; }
        public long partyID { get; set; }
        public bool adminPrivileges { get; set; }
        public short status { get; set; }
    
        public virtual PartyTable PartyTable { get; set; }
        public virtual UserTable UserTable { get; set; }
    }
}
