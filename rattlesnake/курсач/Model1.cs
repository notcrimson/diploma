using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace курсач
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Professional_unit> Professional_units { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<The_Test> The_Test { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Professional_unit>()
                .Property(e => e.Name_of_PU)
                .IsUnicode(false);

            modelBuilder.Entity<Professional_unit>()
                .HasMany(e => e.The_Test)
                .WithRequired(e => e.Professional_units)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.Test_name)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.Question1)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.Answers)
                .IsUnicode(false);

            modelBuilder.Entity<Result>()
                .Property(e => e.Test_name)
                .IsUnicode(false);

            modelBuilder.Entity<Result>()
                .Property(e => e.Answers)
                .IsUnicode(false);

            modelBuilder.Entity<Result>()
                .Property(e => e.Time)
                .HasPrecision(0);

            modelBuilder.Entity<Result>()
                .Property(e => e.Percentage)
                .IsUnicode(false);

            modelBuilder.Entity<The_Test>()
                .Property(e => e.Test_name)
                .IsUnicode(false);

            modelBuilder.Entity<The_Test>()
                .Property(e => e.Name_of_PU)
                .IsUnicode(false);

            modelBuilder.Entity<The_Test>()
                .Property(e => e.Correct_answers)
                .IsUnicode(false);

            modelBuilder.Entity<The_Test>()
                .HasMany(e => e.Questions)
                .WithRequired(e => e.The_Test)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Results)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.StudentID);
        }
    }
}
