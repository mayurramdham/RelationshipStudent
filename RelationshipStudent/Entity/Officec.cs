namespace RelationshipStudent.Entity
{
    public class Office
    {
        public int OfficeId { get; set; }
        public string Location { get; set; }

        // Foreign key for one-to-one relationship with Instructor
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
    }

}
