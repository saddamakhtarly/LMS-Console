using ClassLibrary.Core.Domain;
using System;

namespace LMS_Porject
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new lmsContext()))
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("0. Close Application");
                    Console.WriteLine("1. Admin Portal");
                    Console.WriteLine("2. Teacher Portal");
                    Console.WriteLine("3. Student Portal");
                    int a = int.Parse(Console.ReadLine());
                    if (a == 0)
                    {
                        break;
                    }
                    switch (a)
                    {
                        case 1:
                            AdminPortal();
                            break;
                        case 2:
                            TeacherPortal();
                            break;
                        case 3:
                            StudentProtal();
                            break;
                        default:
                            Console.WriteLine("Wrong Input");
                            break;
                    }
                    
                } while (true);
                
            }
            //Console.WriteLine("Press Enter To Exit");
            //Console.ReadLine();
        }
        static void AdminPortal()
        {
            
            do
            {
                Console.Clear();
                Console.WriteLine("This is Admin Portal");
                Console.WriteLine("0. Main Menue");
                Console.WriteLine("1. Manage Courses");
                Console.WriteLine("2. Manage Teachers");
                Console.WriteLine("3. Manage Students");
                int b = int.Parse(Console.ReadLine());
                if (b == 0)
                {
                    break;
                }
                switch (b)
                {
                    case 1:
                        CoursesMenue();
                        break;
                    case 2:
                        TeacherMenue();
                        break;
                    case 3:
                        StudentMenue();
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
                

            } while (true);
            
        }

        static void CoursesMenue()
        {
            do
            {
                Console.WriteLine("This is Course Menue");
                Console.WriteLine("0. Admin Portal");
                Console.WriteLine("1. Add Course");
                Console.WriteLine("2. Edit Course");
                Console.WriteLine("3. Delete Course");
                Console.WriteLine("4. Assign Course To Teacher");
                Console.WriteLine("5. Enrol Student In Course");
                int b = int.Parse(Console.ReadLine());
                if (b == 0)
                {
                    break;
                }
                switch (b)
                {
                    case 1:
                        AddCourse();
                        break;
                    case 2:
                        UpdateCourse();
                        break;
                    case 3:
                        DeleteCourse();
                        break;
                    case 4:
                        AssignCourseToTeacher();
                        break;
                    case 5:
                        EnrolStudentInCourse();
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            } while (true);
            
        }
        static void AddCourse()
        {
            using (var unitOfWork = new UnitOfWork(new lmsContext()))
            {
                Console.WriteLine("Enter Course Name");
                string CourseName = Console.ReadLine();
                Console.WriteLine("Enter Course Description");
                string CourseDescription = Console.ReadLine();
                unitOfWork.Admins.Add(new Course { Name = CourseName, Description = CourseDescription, Marks = 0 });
                unitOfWork.Complete();
                Console.WriteLine("Course Added");
            }
        }
        static void UpdateCourse()
        {
            using (var unitOfWork = new UnitOfWork(new lmsContext()))
            {
                var lcourse = unitOfWork.Courses.GetAll();
                Console.WriteLine("List of Courses");
                foreach (var item in lcourse)
                {
                    Console.WriteLine($"id= {item.Id} name= {item.Name} ");
                }
                Console.WriteLine("Enter Course Id");
                int cid = int.Parse(Console.ReadLine());
                var crec = unitOfWork.Courses.Get(cid);


                Console.WriteLine("Enter Course Name");
                crec.Name = Console.ReadLine();
                Console.WriteLine("Enter Course Description");
                crec.Description = Console.ReadLine();
                unitOfWork.Complete();
                Console.WriteLine("Course Updated");
            }
        }
        static void DeleteCourse()
        {
            using (var unitOfWork = new UnitOfWork(new lmsContext()))
            {
                var lcourse = unitOfWork.Courses.GetAll();
                Console.WriteLine("List of Courses");
                foreach (var item in lcourse)
                {
                    Console.WriteLine($"id= {item.Id} name= {item.Name} ");
                }
                Console.WriteLine("Enter Course Id To Delete");
                int cid = int.Parse(Console.ReadLine());
                var crec = unitOfWork.Courses.Get(cid);
                unitOfWork.Courses.Remove(crec);
                unitOfWork.Complete();
                Console.WriteLine("Course Deleted");
            }
        }

        static void TeacherMenue()
        {
            do
            {
                Console.WriteLine("This is Teacher Menue");
                Console.WriteLine("0. Admin Portal");
                Console.WriteLine("1. Add Teacher");
                Console.WriteLine("2. Edit Teacher");
                Console.WriteLine("3. Delete Teacher");
                Console.WriteLine("4. Assign Course");
                int b = int.Parse(Console.ReadLine());
                if (b == 0)
                {
                    break;
                }
                switch (b)
                {
                    case 1:
                        AddTeacher();
                        break;
                    case 2:
                        EditTeacher();
                        break;
                    case 3:
                        DeleteTeacher();
                        break;
                    case 4:
                        AssignCourseToTeacher();
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            } while (true);
            
        }
        static void AddTeacher()
        {
            using (var unitOfWork = new UnitOfWork(new lmsContext()))
            {
                Console.WriteLine("Enter Teacher Name");
                string TeacherName = Console.ReadLine();
                unitOfWork.Admins.Add(new Teacher { Name = TeacherName });
                unitOfWork.Complete();
                Console.WriteLine("Teacher Added");
            }
        }
        static void EditTeacher()
        {
            using (var unitOfWork = new UnitOfWork(new lmsContext()))
            {
                var lcourse = unitOfWork.Teachers.GetAll();
                Console.WriteLine("List of Teacher");
                foreach (var item in lcourse)
                {
                    Console.WriteLine($"id= {item.Id} name= {item.Name} ");
                }
                Console.WriteLine("Enter Teacher Id");
                int cid = int.Parse(Console.ReadLine());
                var crec = unitOfWork.Teachers.Get(cid);
                Console.WriteLine("Enter Teacher Name");
                crec.Name = Console.ReadLine();
                unitOfWork.Complete();
                Console.WriteLine("Teacher Updated");
            }
        }
        static void DeleteTeacher()
        {
            using (var unitOfWork = new UnitOfWork(new lmsContext()))
            {
                var lcourse = unitOfWork.Teachers.GetAll();
                Console.WriteLine("List of Teachers");
                foreach (var item in lcourse)
                {
                    Console.WriteLine($"id= {item.Id} name= {item.Name} ");
                }
                Console.WriteLine("Enter Teacher Id To Delete");
                int cid = int.Parse(Console.ReadLine());
                var crec = unitOfWork.Courses.Get(cid);
                unitOfWork.Courses.Remove(crec);
                unitOfWork.Complete();
                Console.WriteLine("Teacher Deleted");
            }
        }

        static void StudentMenue()
        {
            do
            {
                Console.WriteLine("This is Student Menue");
                Console.WriteLine("0. Admin Portal");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Edit Student");
                Console.WriteLine("3. Delete Student");
                Console.WriteLine("4. Enrol Course");
                int b = int.Parse(Console.ReadLine());
                if (b == 0)
                {
                    break;
                }
                switch (b)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        EditStudent();
                        break;
                    case 3:
                        DeleteStudent();
                        break;
                    case 4:
                        EnrolStudentInCourse();
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            } while (true);
            
        }
        static void AddStudent()
        {
            using (var unitOfWork = new UnitOfWork(new lmsContext()))
            {
                Console.WriteLine("Enter Student Name");
                string StudentName = Console.ReadLine();
                unitOfWork.Admins.Add(new Student { Name = StudentName });
                unitOfWork.Complete();
                Console.WriteLine("Student Added");
            }
        }
        static void EditStudent()
        {
            using (var unitOfWork = new UnitOfWork(new lmsContext()))
            {
                var lcourse = unitOfWork.Students.GetAll();
                Console.WriteLine("List of Student");
                foreach (var item in lcourse)
                {
                    Console.WriteLine($"id= {item.Id} name= {item.Name} ");
                }
                Console.WriteLine("Enter Student Id");
                int cid = int.Parse(Console.ReadLine());
                var crec = unitOfWork.Teachers.Get(cid);
                Console.WriteLine("Enter Teacher Name");
                crec.Name = Console.ReadLine();
                unitOfWork.Complete();
                Console.WriteLine("Student Updated");
            }
        }
        static void DeleteStudent()
        {
            using (var unitOfWork = new UnitOfWork(new lmsContext()))
            {
                var lcourse = unitOfWork.Students.GetAll();
                Console.WriteLine("List of Teachers");
                foreach (var item in lcourse)
                {
                    Console.WriteLine($"id= {item.Id} name= {item.Name} ");
                }
                Console.WriteLine("Enter Student Id To Delete");
                int cid = int.Parse(Console.ReadLine());
                var crec = unitOfWork.Students.Get(cid);
                unitOfWork.Students.Remove(crec);
                unitOfWork.Complete();
                Console.WriteLine("Student Deleted");
            }
        }


        static void AssignCourseToTeacher()
        {
            using (var unitOfWork = new UnitOfWork(new lmsContext()))
            {
                var lteacher = unitOfWork.Teachers.GetAll();
                Console.WriteLine("List of Teachers");
                foreach (var item in lteacher)
                {
                    Console.WriteLine($"id= {item.Id} name= {item.Name} ");
                }
                var lcourse = unitOfWork.Courses.GetAll();
                Console.WriteLine("List of Courses");
                foreach (var item in lcourse)
                {
                    Console.WriteLine($"id= {item.Id} name= {item.Name} ");
                }
                Console.WriteLine("Enter Teacher Id");
                int tid = int.Parse(Console.ReadLine());
                var trec = unitOfWork.Teachers.Get(tid);
                Console.WriteLine("Enter Course Id");
                int cid = int.Parse(Console.ReadLine());
                var crec = unitOfWork.Courses.Get(cid);
                crec.Teacher = trec;
                Console.WriteLine($"Assign {crec.Name} Course To{trec.Name} Teacher");
                unitOfWork.Complete();
            }
        }
        static void EnrolStudentInCourse()
        {
            using (var unitOfWork = new UnitOfWork(new lmsContext()))
            {
                var lstudent = unitOfWork.Students.GetAll();
                Console.WriteLine("List of Teachers");
                foreach (var item in lstudent)
                {
                    Console.WriteLine($"id= {item.Id} name= {item.Name} ");
                }
                var lcourse = unitOfWork.Courses.GetAll();
                Console.WriteLine("List of Courses");
                foreach (var item in lcourse)
                {
                    Console.WriteLine($"id= {item.Id} name= {item.Name} ");
                }
                Console.WriteLine("Enter Student Id");
                int sid = int.Parse(Console.ReadLine());
                var srec = unitOfWork.Students.Get(sid);
                Console.WriteLine("Enter Course Id");
                int cid = int.Parse(Console.ReadLine());
                var crec = unitOfWork.Courses.Get(cid);
                crec.Student = srec;
                unitOfWork.Complete();
                Console.WriteLine($"Enrol {crec.Name} Course To{srec.Name} Teacher");
            }
        }



        static void TeacherPortal()
        {
            Console.WriteLine("This is Teacher Menue");
            Console.WriteLine("1. Add Student Marks");
            int t = int.Parse(Console.ReadLine());
            switch (t)
            {
                case 1:
                    AddStudentMarks();
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
        }
        static void AddStudentMarks()
        {
            using (var unitOfWork = new UnitOfWork(new lmsContext()))
            {
                Console.WriteLine("Enter Student ID");
                int sid = int.Parse(Console.ReadLine());
                var lcourse = unitOfWork.Students.StudentCourse(sid);
                
                
                foreach (var item in lcourse)
                {
                  
                    Console.WriteLine($"id= {item.Id} name= {item.Name} Marks= {item.Marks} ");
                }
                Console.WriteLine("Enter Course ID");
                int cid = int.Parse(Console.ReadLine());
                var crs = unitOfWork.Courses.Get(1);
                Console.WriteLine("Enter Course Marks");
                crs.Marks = int.Parse(Console.ReadLine());
                unitOfWork.Complete();
            }
        }


        static void StudentProtal()
        {
            Console.WriteLine("This is Student Menue");
            Console.WriteLine("1. View Marks");
            int s = int.Parse(Console.ReadLine());
            switch (s)
            {
                case 1:
                    ViewStudentMarks();
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
        }
        static void ViewStudentMarks()
        {
            using (var unitOfWork = new UnitOfWork(new lmsContext()))
            {
                Console.WriteLine("Enter Student ID");
                int sid = int.Parse(Console.ReadLine());
                var lcourse = unitOfWork.Students.StudentCourse(sid);
                foreach (var item in lcourse)
                {
                    Console.WriteLine($"id= {item.Id} name= {item.Name} Marks= {item.Marks} ");
                }
                Console.ReadLine();
            }
        }

    }
}
