﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntitiesChooseEm : DbContext
    {
        public EntitiesChooseEm()
            : base("name=EntitiesChooseEm")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BlacklistTable> BlacklistTables { get; set; }
        public virtual DbSet<PartyTable> PartyTables { get; set; }
        public virtual DbSet<SongRatingFromPartyTable> SongRatingFromPartyTables { get; set; }
        public virtual DbSet<SongsForPartyTable> SongsForPartyTables { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UserLoginTable> UserLoginTables { get; set; }
        public virtual DbSet<UsersAtParty> UsersAtParties { get; set; }
        public virtual DbSet<UserTable> UserTables { get; set; }
        public virtual DbSet<ZIPTable> ZIPTables { get; set; }
        public virtual DbSet<FriendTable> FriendTables { get; set; }
    }
}
