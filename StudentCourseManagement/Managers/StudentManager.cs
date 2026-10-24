using StudentCourseManagement.Models;


namespace StudentCourseManagement.Managers
{
    public class StudentManager
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);

            Console.WriteLine("Student added successfully!");
        }

        public void ListStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            Console.WriteLine("\n--- Student List ---");

            foreach (Student student in students)
            {
                Console.WriteLine(
                    $"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Course ID: {student.CourseId}"
                );
            }
        }
    }
}