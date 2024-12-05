using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GradingSystem.Services
{
    internal class DataBackupService
    {
        private const string SavedDataPath = "SavedData";

        // Backup teacher data to a CSV file
        public void BackupTeacherData(List<Teacher> teachers, string filePath)
        {
            try
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
                                writer.WriteLine($"{teacher.Id},{EscapeCsv(teacher.Name)},{EscapeCsv(teacher.Email)}," +
                                                 $"{EscapeCsv(course.CourseName)},{studentAverage.Key},{studentAverage.Value:F2}");
                            }
                        }
                    }
                }
                Console.WriteLine("Teacher data backed up successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error backing up teacher data: {ex.Message}");
            }
        }

        // Backup student data to a CSV file
        public void BackupStudentData(List<Student> students, string filePath)
        {
            try
            {
                using (var writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Student ID,Student Name,Email,Course ID,Grade");

                    foreach (var student in students)
                    {
                        foreach (var courseId in student.EnrolledCourses)
                        {
                            if (student.Grades.TryGetValue(courseId, out double grade))
                            {
                                writer.WriteLine($"{student.Id},{EscapeCsv(student.Name)},{EscapeCsv(student.Email)},{courseId},{grade:F2}");
                            }
                        }
                    }
                }
                Console.WriteLine("Student data backed up successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error backing up student data: {ex.Message}");
            }
        }

        // Check student credentials
        public static bool CheckStudent(int id, string password)
        {
            var students = DeserializeStudentFile();
            if (students == null) return false;

            return students.Any(student => student.Id == id && student.Password.Equals(password, StringComparison.OrdinalIgnoreCase));
        }

        // Check teacher credentials
        public static bool CheckTeacher(int id, string password)
        {
            var teachers = DeserializeTeacherFile();
            if (teachers == null) return false;

            return teachers.Any(teacher => teacher.Id == id && teacher.Password.Equals(password, StringComparison.OrdinalIgnoreCase));
        }

        // Deserialize student data from CSV
        public static List<Student> DeserializeStudentFile()
        {
            string filePath = Path.Combine(SavedDataPath, "StudentData.csv");
            var students = new List<Student>();

            if (!File.Exists(filePath)) return null;

            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    // Skip the header line
                    reader.ReadLine();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (line == null) continue;

                        var values = ParseCsvLine(line);
                        var student = new Student
                        {
                            Id = int.Parse(values[0]),
                            Name = values[1],
                            Email = values[2],
                            Password = values[3]
                        };
                        students.Add(student);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading student file: {ex.Message}");
            }
            return students;
        }

        // Deserialize teacher data from CSV
        public static List<Teacher> DeserializeTeacherFile()
        {
            string filePath = Path.Combine(SavedDataPath, "TeachersData.csv");
            var teachers = new List<Teacher>();

            if (!File.Exists(filePath)) return null;

            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    // Skip the header line
                    reader.ReadLine();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (line == null) continue;

                        var values = ParseCsvLine(line);
                        var teacher = new Teacher
                        {
                            Id = int.Parse(values[0]),
                            Name = values[1],
                            Email = values[2],
                            Password = values[3]
                        };
                        teachers.Add(teacher);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading teacher file: {ex.Message}");
            }
            return teachers;
        }

        // Helper method to escape CSV values
        private static string EscapeCsv(string value)
        {
            if (value.Contains(",") || value.Contains("\"") || value.Contains("\n"))
            {
                value = $"\"{value.Replace("\"", "\"\"")}\"";
            }
            return value;
        }

        // Helper method to parse a CSV line
        private static string[] ParseCsvLine(string line)
        {
            var values = new List<string>();
            var current = new StringBuilder();
            bool inQuotes = false;

            foreach (char c in line)
            {
                if (c == '"' && !inQuotes)
                {
                    inQuotes = true;
                }
                else if (c == '"' && inQuotes)
                {
                    inQuotes = false;
                }
                else if (c == ',' && !inQuotes)
                {
                    values.Add(current.ToString());
                    current.Clear();
                }
                else
                {
                    current.Append(c);
                }
            }

            values.Add(current.ToString());
            return values.ToArray();
        }
    }
}
