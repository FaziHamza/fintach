using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public partial class AscentContext : DbContext
    {
        public AscentContext() : base()
        {
        }
        public AscentContext(DbContextOptions options)
           : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=Ascent;Trusted_Connection=True;MultipleActiveResultSets=true;Connection Timeout=60");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblContactInfoAccountDetails>().HasOne(b => b.tblUser).WithOne(i => i.tblContactInfoAccountDetails).HasForeignKey<tblContactInfoAccountDetails>(b => b.UserId);
            modelBuilder.Entity<tblContactInfoBusiness>().HasOne(b => b.tblUser).WithOne(i => i.tblContactInfoBusiness).HasForeignKey<tblContactInfoBusiness>(b => b.UserId);
            modelBuilder.Entity<tblIdentifiaction>().HasOne(b => b.tblUser).WithOne(i => i.tblIdentifiaction).HasForeignKey<tblIdentifiaction>(b => b.UserId);
            modelBuilder.Entity<tblLegalInfo>().HasOne(b => b.tblUser).WithOne(i => i.tblLegalInfo).HasForeignKey<tblLegalInfo>(b => b.UserId);
            modelBuilder.Entity<tblResidence>().HasOne(b => b.tblUser).WithOne(i => i.tblResidence).HasForeignKey<tblResidence>(b => b.UserId);
            modelBuilder.Entity<tblSecure>().HasOne(b => b.tblUser).WithOne(i => i.tblSecure).HasForeignKey<tblSecure>(b => b.UserId);
        }
        public virtual DbSet<tblUser> tblUser { get; set; }
        public virtual DbSet<tblContactInfoAccountDetails> tblContactInfoAccountDetails { get; set; }
        public virtual DbSet<tblContactInfoBusiness> tblContactInfoBusiness { get; set; }
        public virtual DbSet<tblIdentifiaction> tblIdentifiaction { get; set; }
        public virtual DbSet<tblSecure> tblSecure { get; set; }
        public virtual DbSet<tblLegalInfo> tblLegalInfo { get; set; }
        public virtual DbSet<tblResidence> tblResidence { get; set; }
    }
}
