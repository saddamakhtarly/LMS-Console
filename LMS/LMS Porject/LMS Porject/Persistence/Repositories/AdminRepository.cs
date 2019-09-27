using ClassLibrary.Core.Domain;
using ClassLibrary.Core.Repositories;
using LMS_Porject;
using System.Data.Entity;
using System.Linq;

namespace ClassLibrary.Persistence.Repositories
{
    public class AdminRepository : Repository<Admin>, IAdminRepository
    {
        public AdminRepository(lmsContext context) : base(context)
        {
        }

       

        public lmsContext lmsContext
        {
            get { return Context as lmsContext; }
        }

        public void Add(Student obj)
        {
            lmsContext.Students.Add(obj);
        }

        public void Add(Teacher obj)
        {
            lmsContext.Teachers.Add(obj);
        }

        public void Add(Course obj)
        {
            lmsContext.Courses.Add(obj);
        }
    }
}