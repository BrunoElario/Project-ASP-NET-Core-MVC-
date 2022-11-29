﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectSales.Models;

namespace ProjectSales.Data
{
    public class ProjectSalesContext : DbContext
    {
        public ProjectSalesContext (DbContextOptions<ProjectSalesContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectSales.Models.Department> Department { get; set; }
    }
}