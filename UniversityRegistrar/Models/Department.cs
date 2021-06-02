using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Department
  {
    public Department()
    {
      this.Courses = new HashSet<Course>();
    }
    public int DepartmentId { get; set; }
    public string Name { get; set; }

    //public string Date { get; set; }
    public virtual ICollection<Course> Courses { get; set; }
  }
}