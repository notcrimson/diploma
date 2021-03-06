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

        public virtual DbSet<Professional_units> Professional_units { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<Result> Result { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<The_Test> The_Test { get; set; }
        public virtual DbSet<User_Log> User_Log { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Vocabulary> Vocabulary { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Professional_units>()
                .Property(e => e.Name_of_PU)
                .IsUnicode(false);

            modelBuilder.Entity<Professional_units>()
                .HasMany(e => e.The_Test)
                .WithRequired(e => e.Professional_units)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Professional_units>()
                .HasMany(e => e.Vocabulary)
                .WithOptional(e => e.Professional_units)
                .HasForeignKey(e => e.PU_Name);

            modelBuilder.Entity<Questions>()
                .Property(e => e.Test_name)
                .IsUnicode(false);

            modelBuilder.Entity<Questions>()
                .Property(e => e.Question)
                .IsUnicode(false);

            modelBuilder.Entity<Questions>()
                .Property(e => e.Answers)
                .IsUnicode(false);

            modelBuilder.Entity<Questions>()
                .Property(e => e.Correct_Answer)
                .IsUnicode(false);

            modelBuilder.Entity<Result>()
                .Property(e => e.Test_name)
                .IsUnicode(false);

            modelBuilder.Entity<Result>()
                .Property(e => e.Answers)
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

            modelBuilder.Entity<User_Log>()
                .Property(e => e.LastFormUsed)
                .IsUnicode(false);

            modelBuilder.Entity<User_Log>()
                .Property(e => e.Coordinate)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Result)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.StudentID);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.User_Log)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vocabulary>()
                .Property(e => e.PU_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Vocabulary>()
                .Property(e => e.Word)
                .IsUnicode(false);

            modelBuilder.Entity<Vocabulary>()
                .Property(e => e.Definition)
                .IsUnicode(false);
        }
    }
}
