using System;
using System.Collections.Generic;

namespace C_Sharp_fundamentals
{
    class GradeBook
    {
        public static float MinimumGrade = 0;
        public static float MaximumGrade = 100;

        public GradeBook()
        {
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            stats.HighestGrade = 0;
            float sum = 0f;


            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;

            }

            if (grades.Count != 0)
            {
                stats.AverageGrade = sum / grades.Count;
            }

            return stats;

        }

        public List<float> grades;
    }
}
