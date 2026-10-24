using StudentCourseManagement.Models;

namespace StudentCourseManagement.Managers
{
    public class CourseManager
    {
        private List<Course> courses = new List<Course>();

        public void AddCourse(Course course)
        {
            courses.Add(course);

            Console.WriteLine("Course added successfully!");
        }

        public void ListCourses()
        {
            if (courses.Count == 0)
            {
                Console.WriteLine("No courses found.");
                return;
            }

            Console.WriteLine("\n--- Course List ---");

            foreach (Course course in courses)
            {
                Console.WriteLine(
                    $"Course ID: {course.CourseId}, Course Name: {course.CourseName}"
                );
            }
        }
    }
}