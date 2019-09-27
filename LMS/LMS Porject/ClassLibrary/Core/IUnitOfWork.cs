using ClassLibrary.Core.Repositories;
using System;

namespace ClassLibrary.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; }
        ITeacherRepository Teachers { get; }
        IStudentRepository Students { get; }
        IAdminRepository Admins { get; }
        int Complete();
    }
}