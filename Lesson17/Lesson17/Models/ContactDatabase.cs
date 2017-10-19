using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lesson16.Models
{
    public class ContactDatabase : DbContext
    {
        public DbSet<ContactLog> ContactLogs { get; set; }
    }
}