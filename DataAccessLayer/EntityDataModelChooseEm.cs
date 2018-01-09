namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntityDataModelChooseEm : DbContext
    {
        public EntityDataModelChooseEm()
            : base("name=EntityDataModelChooseEm")
        {
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlacklistTable>()
                .Property(e => e.songID)
                .IsFixedLength();

            modelBuilder.Entity<PartyTable>()
                .HasMany(e => e.BlacklistTables)
                .WithRequired(e => e.PartyTable)
                .HasForeignKey(e => e.partyID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PartyTable>()
                .HasMany(e => e.SongsForPartyTables)
                .WithRequired(e => e.PartyTable)
                .HasForeignKey(e => e.partyID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PartyTable>()
                .HasMany(e => e.UsersAtParties)
                .WithRequired(e => e.PartyTable)
                .HasForeignKey(e => e.partyID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SongRatingFromPartyTable>()
                .Property(e => e.songID)
                .IsFixedLength();

            modelBuilder.Entity<SongsForPartyTable>()
                .Property(e => e.songID)
                .IsFixedLength();

            modelBuilder.Entity<SongsForPartyTable>()
                .HasMany(e => e.SongRatingFromPartyTables)
                .WithRequired(e => e.SongsForPartyTable)
                .HasForeignKey(e => new { e.partyID, e.songID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserTable>()
                .Property(e => e.firstName)
                .IsFixedLength();

            modelBuilder.Entity<UserTable>()
                .Property(e => e.lastName)
                .IsFixedLength();

            modelBuilder.Entity<UserTable>()
                .Property(e => e.zip)
                .IsFixedLength();

            modelBuilder.Entity<UserTable>()
                .HasMany(e => e.PartyTables)
                .WithRequired(e => e.UserTable)
                .HasForeignKey(e => e.ownerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserTable>()
                .HasMany(e => e.SongRatingFromPartyTables)
                .WithRequired(e => e.UserTable)
                .HasForeignKey(e => e.userID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserTable>()
                .HasMany(e => e.UserLoginTables)
                .WithRequired(e => e.UserTable)
                .HasForeignKey(e => e.userID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserTable>()
                .HasMany(e => e.UsersAtParties)
                .WithRequired(e => e.UserTable)
                .HasForeignKey(e => e.userID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ZIPTable>()
                .Property(e => e.zip)
                .IsFixedLength();

            modelBuilder.Entity<ZIPTable>()
                .Property(e => e.city)
                .IsFixedLength();

            modelBuilder.Entity<ZIPTable>()
                .HasMany(e => e.UserTables)
                .WithRequired(e => e.ZIPTable)
                .WillCascadeOnDelete(false);
        }
    }
}
