using System;
using System.Collections.Generic;


namespace UniversityRegistrar.Models
{
  public class Student
  {
    public Student()
    {
      this.JoinEntities = new HashSet<Enrollment>();
    }

    public int StudentId { get; set; }
    public string Name { get; set; }
    public string EnrollmentDate { get; set; }

    public virtual ICollection<Enrollment> JoinEntities { get; }
  }
}