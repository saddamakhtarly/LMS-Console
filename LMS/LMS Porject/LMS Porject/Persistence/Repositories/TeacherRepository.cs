using ClassLibrary.Core.Domain;
using ClassLibrary.Core.Repositories;
using LMS_Porject;
using System.Data.Entity;
using System.Linq;

namespace ClassLibrary.Persistence.Repositories
{
    public class TeacherRepository : Repository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(lmsContext context) : base(context)
        {
        }

        public lmsContext lmsContext
        {
            get { return Context as lmsContext; }
        }
    }
}