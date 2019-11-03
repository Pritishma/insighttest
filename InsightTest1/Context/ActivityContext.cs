using InsightTest1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InsightTest1.Context
{
    public class ActivityContext: DbContext
    {
        public DbSet<Activity> Activity { get; set; }
        public DbSet<Login>Login { get; set; }
    }
}