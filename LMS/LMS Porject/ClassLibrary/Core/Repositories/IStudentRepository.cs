using ClassLibrary.Core.Domain;
using System.Collections.Generic;

namespace ClassLibrary.Core.Repositories
{
    public interface IStudentRepository : IRepository<Student>
    {
        /**
         * 
         * only can view
         * 
         */
        IEnumerable<Course> StudentCourse(int id);
    }
}