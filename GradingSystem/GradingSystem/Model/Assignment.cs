using System;
using System.Collections.Generic;

namespace GradingSystem
{
    internal class Assignment
    {
        public string Name { get; set; } // The name of the assignment
        private double weight; // The weight of the assignment (percentage of total grade)
        public double Weight
        {
            get => weight;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Weight must be between 0 and 100.");
                }
                weight = value;
            }
        }
        public double Grade { get; set; } // The grade assigned to the assignment (if applicable)
        public Dictionary<int, double> StudentGrades { get; set; } = new Dictionary<int, double>();

        // Constructor
        public Assignment(string name, double weight, double grade)
        {
            Name = name;
            Weight = weight;
            Grade = grade;
        }

        // Add or update a student's grade
        public void AddOrUpdateStudentGrade(int studentId, double grade)
        {
            if (grade < 0 || grade > 100)
            {
                throw new ArgumentException("Grade must be between 0 and 100.");
            }

            if (StudentGrades.ContainsKey(studentId))
            {
                StudentGrades[studentId] = grade;
                Console.WriteLine($"Updated grade for Student {studentId} to {grade}.");
            }
            else
            {
                StudentGrades.Add(studentId, grade);
                Console.WriteLine($"Added grade for Student {studentId}: {grade}.");
            }
        }

        // Remove a student's grade
        public void RemoveStudentGrade(int studentId)
        {
            if (StudentGrades.Remove(studentId))
            {
                Console.WriteLine($"Removed grade for Student {studentId}.");
            }
            else
            {
                Console.WriteLine($"No grade found for Student {studentId} to remove.");
            }
        }

        // Calculate the average grade for the assignment
        public double CalculateAverageGrade()
        {
            if (StudentGrades.Count == 0) return 0;

            double totalGrades = 0;
            foreach (var grade in StudentGrades.Values)
            {
                totalGrades += grade;
            }
            return totalGrades / StudentGrades.Count;
        }

        // Check if a student has a grade for the assignment
        public bool HasGrade(int studentId)
        {
            return StudentGrades.ContainsKey(studentId);
        }
    }
}
