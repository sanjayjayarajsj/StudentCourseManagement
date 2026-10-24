
using StudentCourseManagement.Models;
using StudentCourseManagement.Managers;

class Program
{
    static void Main()
    {
        StudentManager studentManager = new StudentManager();
        CourseManager courseManager = new CourseManager();

        courseManager.AddCourse(new Course
        {
            CourseId = 101,
            CourseName = "Angular"
        });

        courseManager.AddCourse(new Course
        {
            CourseId = 102,
            CourseName = "Dot Net"
        });
        studentManager.AddStudent(new Student
        {
            Id = 1,
            Name = "Sanjay",
            Age = 22,
            CourseId = 101
        });

        studentManager.AddStudent(new Student
        {
            Id = 2,
            Name = "Rahul",
            Age = 21,
            CourseId = 102
        });
        courseManager.ListCourses();
        studentManager.ListStudents();

        Console.ReadLine();
    }
}