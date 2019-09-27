using ClassLibrary.Core;
using ClassLibrary.Core.Repositories;
using ClassLibrary.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Porject
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly lmsContext _context;

        public UnitOfWork(lmsContext context)
        {
            _context = context;
            Courses = new CourseRepository(_context);
            Teachers = new TeacherRepository(_context);
            Students = new StudentRepository(_context);
            Admins = new AdminRepository(_context);
        }

        public ICourseRepository Courses { get; private set; }
        public ITeacherRepository Teachers { get; private set; }

        public IStudentRepository Students { get; private set; }

        public IAdminRepository Admins { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
