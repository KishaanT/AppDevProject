using GradingSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GradingSystem.Services
{
    internal class DataBackupService
    {
        private const string SavedDataPath = "..\\..\\SavedData";
        private BinaryFormatter formatter = new BinaryFormatter();
        private FileStream output;

        // Backup Teacher data to a SER file
        public static  void BackupTeacherData(List<Teacher> teachers)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream stream = new FileStream(Path.Combine(SavedDataPath, "TeachersData.ser"), FileMode.Create, FileAccess.Write))
                {
                    formatter.Serialize(stream, teachers);
                }

                Console.WriteLine("Teacher data backed up successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error backing up teacher data: {ex.Message}");
            }
        }

        // Backup student data to a SER file
        public static void BackupStudentData(List<Student> students)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream stream = new FileStream(Path.Combine(SavedDataPath, "StudentsData.ser"), FileMode.Create, FileAccess.Write))
                {
                    formatter.Serialize(stream, students);
                }

                Console.WriteLine("Student data backed up successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error backing up student data: {ex.Message}");
            }
        }

        // Backup courses data to a SER file
        public static void BackupCoursesData(List<Course> courses)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream stream = new FileStream(Path.Combine(SavedDataPath, "CoursesData.ser"), FileMode.Create, FileAccess.Write))
                {
                    formatter.Serialize(stream, courses);
                }

                Console.WriteLine("Courses data backed up successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error backing up Courses data: {ex.Message}");
            }
        }

        // Backup Assignments data to a SER file
        public static void BackupAssignmentData(List<Assignment> assignments)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream stream = new FileStream(Path.Combine(SavedDataPath, "AssignmentsData.ser"), FileMode.Create, FileAccess.Write))
                {
                    formatter.Serialize(stream, assignments);
                }

                Console.WriteLine("Assignments data backed up successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error backing up Assignments data: {ex.Message}");
            }
        }


        // Check student credentials
        public static bool CheckStudent(int id, string password)
        {
            var students = RestoreStudentData();
            if (students == null) return false;

            return students.Any(student => student.Id == id && student.Password.Equals(password, StringComparison.OrdinalIgnoreCase));
        }



        // Check teacher credentials
        public static bool CheckTeacher(int id, string password)
        {
            var teachers = RestoreTeacherData();
            if (teachers == null) return false;

            return teachers.Any(teacher => teacher.Id == id && teacher.Password.Equals(password, StringComparison.OrdinalIgnoreCase));
        }

        // Deserialize student data from SER
        public static List<Student> RestoreStudentData()
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream stream = new FileStream(Path.Combine(SavedDataPath, "StudentsData.ser"), FileMode.Open, FileAccess.Read))
                {
                    return (List<Student>)formatter.Deserialize(stream);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error restoring student data: {ex.Message}");
                return null;
            }
        }

        // Deserialize Teacher data from SER
        public static List<Teacher> RestoreTeacherData()
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                List<Teacher> teachers;

                using (FileStream stream = new FileStream(Path.Combine(SavedDataPath, "TeachersData.ser"), FileMode.Open, FileAccess.Read))
                {

                    teachers = (List<Teacher>)formatter.Deserialize(stream);
                }

                Console.WriteLine("Teacher data restored successfully.");
                return teachers;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error restoring teacher data: {ex.Message}");
                return null;
            }
        }

            // Deserialize Courses data from SER
            public static List<Course> RestoreCourseData()
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    List<Course> courses;

                    using (FileStream stream = new FileStream(Path.Combine(SavedDataPath, "CoursesData.ser"), FileMode.Open, FileAccess.Read))
                    {
                    courses = (List<Course>)formatter.Deserialize(stream);
                    }

                    Console.WriteLine("Courses data restored successfully.");
                    return courses;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error restoring Courses data: {ex.Message}");
                    return null;
                }
            }
        // Deserialize Assignments data from SER

        public static List<Assignment> RestoreAssignmentsData()
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                List<Assignment> assignments;

                using (FileStream stream = new FileStream(Path.Combine(SavedDataPath, "AssignmentsData.ser"), FileMode.Open, FileAccess.Read))
                {
  
                        assignments = (List<Assignment>)formatter.Deserialize(stream); 
                }

                Console.WriteLine("Assignment data restored successfully.");
                return assignments;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error restoring Assignment data: {ex.Message}");
                return new List<Assignment>();
            }
        }
    }
}





    

    

