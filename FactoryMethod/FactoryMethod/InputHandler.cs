using FactoryMethod.College;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.FactoryMethod
{
    class InputHandler
    {
        public static void CreateField(string line)
        {
            var entity = FactoryMethod.FabrickMethod(line);
            if (entity is Teacher teacher)
            {
                InputHandler inputHandler = new InputHandler();
                Console.WriteLine("Вы можете добавить опыт работы и курсы, который введет преподаватель\n" +
                    "Введите Y, если вы хотите добавить это или нажмите любую другую кнопку, чтобы продолжить");

                if (Console.ReadLine().ToLower() == "y")
               {
                    Console.WriteLine("Введите опыт работы:");
                    int experience = int.Parse(Console.ReadLine());
                    teacher.SetExperience(experience);
                    Console.WriteLine("Введите курс/курсы, которые введет учитель через пробел");
                    string[] courses = Console.ReadLine().Split(' ');
                    teacher.SetCourses(courses);
               }
                string course = "";
                foreach (var cours in teacher.Courses)
                {
                    course += cours.ToString() + ", ";
                }
                string field = $"teacher Id: {teacher.Id}, Teacher Name: {teacher.Name}, Teacher Expirience: {teacher.Experience}, Teacher Courses: {course}";
                
                inputHandler.WriteToFile(field);

            }
            else if (entity is Student student)
            {
                InputHandler inputHandler = new InputHandler();
                Console.WriteLine("Вы можете добавить курсы, на которые ходит студент\n" +
                    "Введите Y, если вы хотите добавить это или нажмите любую другую кнопку, чтобы продолжить");

                if (Console.ReadLine().ToLower() == "y")
                {
                    Console.WriteLine("Введите курс/курсы, на которые ходит студент через пробел");
                    string[] courses = Console.ReadLine().Split(' ');
                    student.SetCourses(courses);
                }
                string course = "";
                foreach (var cours in student.Courses)
                {
                    course += cours.ToString() + ", ";
                }

                string field = $"student ID: {student.Id}, Student Name: {student.Name}, " +
                    $"Student Courses: {course}";

                inputHandler.WriteToFile(field);
            }
            else if (entity is Course course)
            {
                InputHandler inputHandler = new InputHandler();
                Console.WriteLine("Вы можете добавить курсы, на которые ходит студент\n" +
                    "Введите Y, если вы хотите добавить это или нажмите любую другую кнопку, чтобы продолжить");

                if (Console.ReadLine().ToLower() == "y")
                {
                    Console.WriteLine("Введите id Студентов этого курса");
                    course.Student_Id = Console.ReadLine().Split(' ');
                    Console.WriteLine("Введите id Учителей этого курса");
                    course.Teacher_Id = Console.ReadLine().Split(' ');
                }
                
                string field = $"course ID: {course.Id}, Student Name: {course.Name}, " +
                    $"Student_id: {course.Student_Id}, Teacher_id: {course.Teacher_Id}";

                inputHandler.WriteToFile(field);
            }
        }

        void WriteToFile(string line)
        {
            string filePath = "MyDataBase.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(line);
            }
        }

        public static void ReadFile()
        {
            string filePath = "MyDataBase.txt";

            using (StreamReader reader = new StreamReader(filePath ))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                }
            }
        }

        public static void ReadFile(string field)
        {
            string filePath = "MyDataBase.txt";

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith(field)) Console.WriteLine(line);
                }
            }
        }
    }
}
