﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class puyuh_airEntities1 : DbContext
{
    public puyuh_airEntities1()
        : base("name=puyuh_airEntities1")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public DbSet<penerbangan> penerbangan { get; set; }
    public DbSet<penumpang> penumpang { get; set; }
    public DbSet<sysdiagrams> sysdiagrams { get; set; }
    public DbSet<tiket> tiket { get; set; }
}
