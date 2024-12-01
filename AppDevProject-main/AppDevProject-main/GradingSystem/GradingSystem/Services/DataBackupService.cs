using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Services
{
    internal class DataBackupService
    {
        public void BackupTeacherData(List<Teacher> teachers, string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Teacher ID,Teacher Name,Email,Course Name,Student ID,Student Average");

                foreach (var teacher in teachers)
                {
                    foreach (var course in teacher.Courses)
                    {
                        foreach (var studentAverage in course.StudentAverages)
                        {
                            writer.WriteLine($"{teacher.Id},{teacher.Name},{teacher.Email}," +
                                             $"{course.CourseName},{studentAverage.Key},{studentAverage.Value}");
                        }
                    }
                }
            }
            Console.WriteLine("Teacher data backed up successfully.");
        }

        public void BackupStudentData(List<Student> students, string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Student ID,Student Name,Email,Course ID,Grade");

                foreach (var student in students)
                {
                    foreach (var course in student.EnrolledCourses)
                    {
                        if (student.Grades.TryGetValue(course, out double grade))
                        {
                            writer.WriteLine($"{student.Id},{student.Name},{student.Email},{course},{grade}");
                        }
                    }
                }
            }
            Console.WriteLine("Student data backed up successfully.");
        }

        public static bool checkStudent(int Id, string password)
        {
            List<Student> students = DeserializeStudentFile();

            foreach(var student in students)
            {
                if(student.Id == 0 && student.Password.Equals(password))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool checkTeacher(int Id, string password)
        {
            List<Teacher> teachers = DeserializeTeacherFile();

            foreach (var teacher in teachers)
            {
                if (teacher.Id == 0 && teacher.Password.Equals(password))
                {
                    return true;
                }
            }
            return false;
        }


        public static List<Student> DeserializeStudentFile()
        {
            string file = "\\SavedData\\StudentData.csv";
            List<Student> students = new List<Student>();

            if (File.Exists(file))
            {
                using (FileStream stream = new FileStream(file, FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    students = (List<Student>)formatter.Deserialize(stream);
                }
            }
            else
            {
                return null;
            }
            return students;
        }

        public static List<Teacher> DeserializeTeacherFile()
        {
            string file = "\\SavedData\\TeachersData.csv";
            List<Teacher> teachers = new List<Teacher>();

            if (File.Exists(file))
            {
                using (FileStream stream = new FileStream(file, FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    teachers = (List<Teacher>)formatter.Deserialize(stream);
                }
            }
            else
            {
                return null;
            }
            return teachers;
        }
    }
}
