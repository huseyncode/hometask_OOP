using Students;

class Program
{
    static void Main(string[] args)
    {
        var student1 = new Student { Name = "John", Surname = "Doe" };
        var student2 = new Student { Name = "Jane", Surname = "Doe" };

        var teacher1 = new Teacher { Name = "Mr. Smith", Subject = "Math" };
        var teacher2 = new Teacher { Name = "Mrs. Johnson", Subject = "English" };

        var topic1 = new Topic { Title = "Algebra", Description = "Study of mathematical symbols" };
        var topic2 = new Topic { Title = "Grammar", Description = "Study of the structure of language" };

        var group = new Group("G1", new DateTime(2024, 3, 30), new DateTime(2025, 2, 12));
        group.Limit = 10;
        group.AddStudent(student1);
        group.AddStudent(student2);
        group.AddTeacher(teacher1);
        group.AddTeacher(teacher2);
        group.AddTopic(topic1);
        group.AddTopic(topic2);

        group.GetDetails();

        Console.WriteLine("Students:");
        group.GetStudents();

        Console.WriteLine("Teachers:");
        group.GetTeachers();

        Console.WriteLine("Topics:");
        group.GetTopics();

        group.RemoveStudent(student1);

        Console.WriteLine("Students after removing a student:");
        group.GetStudents();
    }
}
