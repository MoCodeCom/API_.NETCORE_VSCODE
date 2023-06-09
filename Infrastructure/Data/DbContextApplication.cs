using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.Model;


namespace Infrastructure.Data
{
    public class DbContextApplication:DbContext
    {
        public DbContextApplication(DbContextOptions options):base(options)
        {}

        public DbSet<EmployeeModel> employee{get; set;}
    }
}