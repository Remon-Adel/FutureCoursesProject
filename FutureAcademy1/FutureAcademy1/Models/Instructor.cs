using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FutureAcademy1.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public string CourseName { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        //public virtual Course Course { get; set; }
    }
}