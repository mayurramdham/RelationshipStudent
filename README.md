# RelationshipStudent
This will create and apply the necessary schema changes for the relationships.

6. Resulting Database Structure
One-to-One: Instructor and Office tables will have a one-to-one relationship.
One-to-Many: Instructor and Course tables will have a one-to-many relationship (one instructor teaches many courses).
Many-to-Many: Student and Course tables will have a many-to-many relationship, managed by an automatically generated join table (StudentCourse).
Summary of Relationships:
One-to-One: Each Instructor has one Office.
One-to-Many: Each Instructor can teach many Courses.
Many-to-Many: Each Student can enroll in multiple Courses, and each Course can have multiple Students.
This code will allow you to define and manage these relationships using Entity Framework Core.

/////******************//////////
you have to add all the packges otherwise throughing its error
