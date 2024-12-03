using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    }
