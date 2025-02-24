using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FutureAcademy1.Models;

namespace FutureAcademy1.DAL
{
    public class UniversityInitializer:DropCreateDatabaseIfModelChanges<UniversityContext>
    {
        protected override void Seed(UniversityContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstMidName="Ahmed",LastName="Badr",EnrollmentDate=DateTime.Parse("12-10-2018")},
            new Student{FirstMidName="Omar",LastName="AbdElstar",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Tomas",LastName="Girges",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Kyrellos",LastName="Mamodouh",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Fady",LastName="Agban",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Romany",LastName="Saad",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="Martena",LastName="Maher",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Zeyad",LastName="Tarek",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=3,},
            new Course{CourseID=4022,Title="Microeconomics",Credits=3,},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=3,},
            new Course{CourseID=1045,Title="Calculus",Credits=4,},
            new Course{CourseID=3141,Title="Trigonometry",Credits=4,},
            new Course{CourseID=2021,Title="Composition",Credits=3,},
            new Course{CourseID=2042,Title="Literature",Credits=4,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050,},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();


            var Instructors = new List<Instructor>
            {
                new Instructor{FirstName="Mahmoud",LastName="Mounir",CourseName="Chemistry"},
                new Instructor{FirstName="Beshoy",LastName="Samy",CourseName="Microeconomics"},
                new Instructor{FirstName="Mahmoud",LastName="Gazia",CourseName="Macroeconomics"},
                new Instructor{FirstName="Fatma",LastName="Harby",CourseName ="Calculus"},
                new Instructor{FirstName="Mahmoud",LastName="Amer",CourseName="Trigonometry"},
                new Instructor{FirstName="Essam",LastName="Eliwa",CourseName="Composition"},
                new Instructor{FirstName="Said",LastName="Mahmoud",CourseName="Literature"}

            };

            Instructors.ForEach(s => context.Instructors.Add(s));
            context.SaveChanges();


        }
    }
}