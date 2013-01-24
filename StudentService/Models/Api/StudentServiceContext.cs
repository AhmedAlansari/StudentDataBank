﻿using System.Data.Entity;

namespace StudentService.Models
{
    public class StudentServiceContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<StudentService.Models.StudentServiceContext>());

        public StudentServiceContext() : base("name=StudentServiceContext")
        {
        }

        public DbSet<Program> Programs { get; set; }

        public DbSet<University> Universities { get; set; }

        public DbSet<ProgramCourse> ProgramCourses { get; set; }

        public DbSet<UniversalCourse> UniversalCourses { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<StudentProgram> StudentPrograms { get; set; }

        public DbSet<StudentLink> StudentLinks { get; set; }

        public DbSet<StudentCourse> StudentCourses { get; set; }

        public DbSet<UniversityCourse> UniversityCourses { get; set; }

        public DbSet<CourseCredited> CourseCrediteds { get; set; }
    }
}
