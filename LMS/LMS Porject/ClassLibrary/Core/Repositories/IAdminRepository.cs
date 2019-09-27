using ClassLibrary.Core.Domain;

namespace ClassLibrary.Core.Repositories
{
    public interface IAdminRepository : IRepository<Admin>
    {
        /*
         *  add Teacher
         *  add student
         *  add course
         * 
         */
        void Add(Student obj);
        void Add(Teacher obj);
        void Add(Course obj);


    }
}