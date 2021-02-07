using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OptikaRihoskova.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OptikaRihoskova.DAL
{
    public class OptometricsContext : DbContext
    {
        public OptometricsContext() : base("OptometricsContext")
        {

        }

        public DbSet<Appointment> Appointments { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}