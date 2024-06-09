using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Group
    {
        public string GroupNo { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public int Limit { get; set; }

        private List<Student> Students { get; } = new List<Student>();
        private List<Teacher> Teachers { get; } = new List<Teacher>();
        private List<Topic> Topics { get; } = new List<Topic>();

        public Group(string groupNo, DateTime startDate, DateTime endDate)
        {
            GroupNo = groupNo;
            StartDate = startDate;
            EndDate = endDate;
        }

        public void AddStudent(Student student)
        {
            if (Students.Count < Limit)
            {
                Students.Add(student);
            }
            else
            {
                Console.WriteLine("The group is full. Cannot add more students.");
            }
        }

        public void RemoveStudent(Student student)
        {
            if (!Students.Remove(student))
            {
                Console.WriteLine("This student is not in the group.");
            }
        }

        public void GetStudents()
        {
            foreach (var student in Students)
            {
                Console.WriteLine($"Student Name: {student.Name}, Surname: {student.Surname}");
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            if (!Teachers.Remove(teacher))
            {
                Console.WriteLine("This teacher is not in the group.");
            }
        }

        public void GetTeachers()
        {
            foreach (var teacher in Teachers)
            {
                Console.WriteLine($"Teacher Name: {teacher.Name}, Subject: {teacher.Subject}");
            }
        }

        public void AddTopic(Topic topic)
        {
            Topics.Add(topic);
        }

        public void RemoveTopic(Topic topic)
        {
            if (!Topics.Remove(topic))
            {
                Console.WriteLine("This topic is not in the group.");
            }
        }

        public void GetTopics()
        {
            foreach (var topic in Topics)
            {
                Console.WriteLine($"Topic Title: {topic.Title}, Description: {topic.Description}");
            }
        }

        public void GetDetails()
        {
            Console.WriteLine($"GroupNo: {GroupNo}, StartDate: {StartDate.ToString("dd-MM-yyyy")}, EndDate: {EndDate.ToString("dd-MM-yyyy")}, Limit: {Limit}");
        }
    }
}