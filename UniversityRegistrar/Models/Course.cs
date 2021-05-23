using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Course
  {
    public Course()
    {
      this.JoinEntities = new HashSet<Enrollment>();
    }

    public int CourseId { get; set; }
    public string Name { get; set; }

    public virtual ICollection<Enrollment> JoinEntities { get;}
  }
}