using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Student
    {
        public int ID { get; set; }
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}