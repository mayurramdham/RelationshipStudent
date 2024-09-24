namespace RelationshipStudent.Entity
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        // Foreign key for one-to-many relationship
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }

        // Many-to-many relationship with Student
        public ICollection<Student> Students { get; set; }
    }

}
