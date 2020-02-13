using HelperClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelperClass.Data
{
    public  class DbInitializer
    {
        public static void Initializer(SchoolContext context)
        {
            context.Database.EnsureCreated();

            //look for any students.
            if(context.students.Any())
            {
                return;
            }
            var Students = new Student[]
            {
                new Student{FirstName="Janak",LastName="Mahato",EnrollmentDate=DateTime.Parse("2008-09-01")},
                new Student{FirstName="wachas",LastName="Arya",EnrollmentDate=DateTime.Parse("2008-09-01")},
                new Student{FirstName="Mukesh",LastName="Mahato",EnrollmentDate=DateTime.Parse("2008-09-01")},
                new Student{FirstName="ashesh",LastName="Shrestha",EnrollmentDate=DateTime.Parse("2008-09-01")},

                new Student{FirstName="Rabin",LastName="Raut",EnrollmentDate=DateTime.Parse("2008-09-01")},

                new Student{FirstName="Agam",LastName="Mahato",EnrollmentDate=DateTime.Parse("2008-09-01")},
                new Student{FirstName="Chandra",LastName="Singh",EnrollmentDate=DateTime.Parse("2008-09-01")},


            };
            foreach (Student s in Students)
            {
                context.students.Add(s);
            }
            context.SaveChanges();
            var Courses = new Course[]
                {
                    new Course{CourseID=1050,Title="Chemistry",Credits=3},
                    new Course{CourseID=123,Title="physics",Credits=4},
                    new Course{CourseID=234,Title="Maths",Credits=3},
                    new Course{CourseID=45,Title="Thermal",Credits=4},
                    new Course{CourseID=34,Title="English",Credits=2},
                    new Course{CourseID=55,Title="Nepali",Credits=2},
                    new Course{CourseID=22,Title="Applied Mechanics"}
                };
            foreach (Course course in Courses)
            {
                context.Courses.Add(course);

            }
            context.SaveChanges();
            var Enrollments = new Enrollment[]
                {
                    new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
                    new Enrollment{StudentID=2,CourseID=123,Grade=Grade.A},
                    new Enrollment{StudentID=3,CourseID=234,Grade=Grade.B},
                    new Enrollment{StudentID=3,CourseID=123,Grade=Grade.C},
                    new Enrollment{StudentID=2,CourseID=234,Grade=Grade.F},
                    new Enrollment{StudentID=1,CourseID=45},
                    new Enrollment{StudentID=1,CourseID=22,Grade=Grade.A},
                    new Enrollment{StudentID=2,CourseID=55,Grade=Grade.B},
                    new Enrollment{StudentID=2,CourseID=34,Grade=Grade.D}
                };
            foreach (Enrollment enrollment in Enrollments)
            {
                context.Enrollments.Add(enrollment);

            }
            context.SaveChanges();
        }
    }
}
