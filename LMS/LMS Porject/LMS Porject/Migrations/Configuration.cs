namespace LMS_Porject.Migrations
{
    using ClassLibrary.Core.Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LMS_Porject.lmsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LMS_Porject.lmsContext context)
        {
            #region Demo Data

            //context.Admins.Add(new Admin { Id = 1, Name = "Admin1" });
            //context.Admins.Add(new Admin { Id = 2, Name = "Admin2" });

            //context.Teachers.Add(new Teacher { Id = 1, Name = "Teacher1" });
            //context.Teachers.Add(new Teacher { Id = 2, Name = "Teacher2" });
            //context.Teachers.Add(new Teacher { Id = 3, Name = "Teacher3" });
            //context.Teachers.Add(new Teacher { Id = 4, Name = "Teacher4" });
            //context.Teachers.Add(new Teacher { Id = 5, Name = "Teacher5" });

            //context.Courses.Add(new Course { Id = 1, Name = "Courses1", Marks = 0, Description = "Courses1 Description", });
            //context.Courses.Add(new Course { Id = 2, Name = "Courses2", Marks = 0, Description = "Courses2 Description", });
            //context.Courses.Add(new Course { Id = 3, Name = "Courses3", Marks = 0, Description = "Courses3 Description", });
            //context.Courses.Add(new Course { Id = 4, Name = "Courses4", Marks = 0, Description = "Courses4 Description", });
            //context.Courses.Add(new Course { Id = 5, Name = "Courses5", Marks = 0, Description = "Courses5 Description", });

            //context.Students.Add(new Student { Id = 1, Name = "Student1", });
            //context.Students.Add(new Student { Id = 2, Name = "Student2", });
            //context.Students.Add(new Student { Id = 3, Name = "Student3", });
            //context.Students.Add(new Student { Id = 4, Name = "Student4", });
            //context.Students.Add(new Student { Id = 5, Name = "Student5", });

            #endregion
        }
    }
}
