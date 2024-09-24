namespace RelationshipStudent.Entity
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string Name { get; set; }

        // One-to-many relationship with Course
        public ICollection<Course> Courses { get; set; }

        // One-to-one relationship with Office
        public Office Office { get; set; }
    }

}
