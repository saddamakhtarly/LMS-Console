using ClassLibrary.Core.Domain;
using ClassLibrary.Core.Repositories;
using LMS_Porject;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ClassLibrary.Persistence.Repositories
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(lmsContext context): base(context)
        {
        }





        public lmsContext lmsContext
        {
            get { return Context as lmsContext; }
        }
    }
}