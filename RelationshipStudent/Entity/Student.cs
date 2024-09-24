namespace RelationshipStudent.Entity
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        // Many-to-many relationship with Course
        public ICollection<Course> Courses { get; set; }
    }

}
