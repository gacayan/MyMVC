using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMVC.Models;

namespace MyMVC.Data
{
    public class MyMVCContext : DbContext
    {
        public MyMVCContext (DbContextOptions<MyMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MyMVC.Models.UserModel> UserModel { get; set; }
    }
}
