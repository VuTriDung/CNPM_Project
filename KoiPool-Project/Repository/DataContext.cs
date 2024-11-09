﻿using KoiPool_Project.Migrations;
using KoiPool_Project.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

public class DataContext : IdentityDbContext<AppUserModel>
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<AppUserModel> AppUsers { get; set; }
    public DbSet<HistoryModel> Histories { get; set; }
    public DbSet<RequestDetailModel> RequestDetails { get; set; }
    public DbSet<RequestModel> Requests { get; set; }
    public DbSet<ServiceModel> Services { get; set; }
    public DbSet<EmployeeModel> Employees { get; set; }
    public DbSet<CustomerModel> Customers { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
}
}