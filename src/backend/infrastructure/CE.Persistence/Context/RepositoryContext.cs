using CE.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace CE.Persistence.Context
{
    public class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options):base(options)
        {
            
        }
        DbSet<Company>  Company { get; set; } 
        DbSet<Employee> Employee { get; set; }
        DbSet<Address> Address { get; set; }
    }
}
