using ClassLibrary.Core.Domain;
using ClassLibrary.Core.Repositories;
using LMS_Porject;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ClassLibrary.Persistence.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(lmsContext context) : base(context)
        {
        }
        public IEnumerable<Course> StudentCourse(int id)
        {
            return lmsContext.Courses.Where<Course>(x => x.Student.Id == id);
        }

        public lmsContext lmsContext
        {
            get { return Context as lmsContext; }
        }
    }
}