using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace jb213215_MIS4200.DAL
{
    public class Context : DbContext
    {
        public Context() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, jb213215_MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }

        public System.Data.Entity.DbSet<jb213215_MIS4200.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<jb213215_MIS4200.Models.Courses> Courses { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<jb213215_MIS4200.Models.Instructors> Instructors { get; set; }

        public System.Data.Entity.DbSet<jb213215_MIS4200.Models.CourseDetails> CourseDetails { get; set; }

        public System.Data.Entity.DbSet<jb213215_MIS4200.Models.UserDetails> UserDetails { get; set; }
    }
}