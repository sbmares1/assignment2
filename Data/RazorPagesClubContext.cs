using System;
using Microsoft.EntityFrameworkCore;
using RazorPagesClub.Models;

namespace RazorPagesClub.Data{
    public class RazorPagesClubContext : DbContext
    {
        public RazorPagesClubContext(DbContextOptions<RazorPagesClubContext> options) : base(options)
        {

        }
    
    public DbSet<Client> Clients{get; set;}
    public DbSet<RazorPagesClub.Models.Member> Member{get;set;}
    public DbSet<Project> Projects{get;set;}
    public DbSet<Team> Teams{get;set;}
    }
}