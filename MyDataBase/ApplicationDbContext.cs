using Assignment2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assignment2.MyDataBase
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("LinkDb")
        {

        }

        public DbSet<Trainer> Trainers { get; set; }
    }
   
}