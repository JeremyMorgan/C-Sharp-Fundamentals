using System;
using System.Collections.Generic;

namespace C_Sharp_fundamentals
{
    public class GradeBook
    {
        public static float MinimumGrade = 0;
        public static float MaximumGrade = 100;
        private string _name;
        public NameChangedDelegate NameChanged;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    var oldValue = _name;
                    _name = value;

                    if (NameChanged != null)
                    {
                        NameChanged(oldValue, value);
                    }            
                }                
             
            }

        }

        public List<float> grades;

        public GradeBook(string name = "There is no name")
        {
            Name = name;
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

        
    }
}
