﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DatabaseFirtsLib.Database.Entities;

#nullable disable

namespace DatabaseFirtsLib.Database.Contexts
{
    public partial class PeopleDbContext : DbContext
    {
        public PeopleDbContext()
        {
        }

        public PeopleDbContext(DbContextOptions<PeopleDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<RegisteredUser> RegisteredUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("filename=baza.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
