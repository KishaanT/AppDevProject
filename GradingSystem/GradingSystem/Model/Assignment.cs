using System;
using System.Collections.Generic;

namespace GradingSystem
{
     [Serializable]
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
        public Dictionary<int, double> StudentGrades { get; set; }

       
        // Constructor
        public Assignment(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        // Add or update a student's grade
        public void AddOrUpdateStudentGrade(int studentID, double grade)
        {
            if (grade < 0 || grade > 100)
            {
                throw new ArgumentException("Grade must be between 0 and 100.");
            }

            if (StudentGrades.ContainsKey(studentID))
            {
                StudentGrades[studentID] = grade;
                Console.WriteLine($"Updated grade for Student {studentID} to {grade}.");
            }
            else
            {
                StudentGrades.Add(studentID, grade);
                Console.WriteLine($"Added grade for Student {studentID}: {grade}.");
            }
        }

        // Remove a student's grade
        public void RemoveStudentGrade(int studentID)
        {
            if (StudentGrades.Remove(studentID))
            {
                Console.WriteLine($"Removed grade for Student {studentID}.");
            }
            else
            {
                Console.WriteLine($"No grade found for Student {studentID} to remove.");
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
        public bool HasGrade(int studentID)
        {
            return StudentGrades.ContainsKey(studentID);
        }
    }
}
