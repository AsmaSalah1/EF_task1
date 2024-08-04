using EF_task1.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_task1.contex
{
    internal class ApplecationDBContex:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-43Q1A7I\\MSSQLSERVER01;Database=EF_Task1;Trusted_Connection=True;TrustServerCertificate=True");

        }
        public DbSet<product> products { get; set; }
    }
}
