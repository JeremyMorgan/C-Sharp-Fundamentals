using System;


namespace C_Sharp_fundamentals
{
    class Program
    {

        static void Main(string[] args)
        {

            GradeBook book = new GradeBook();
            book.AddGrade(91f);
            book.AddGrade(89.1f);
            book.AddGrade(75f);

            GradeStatistics stats = book.ComputeStatistics();



            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);


            //Arrays();



            /*
             * 
            const int numberOfStudents = 4;

            int[] scores = new int[numberOfStudents];

            int totalScore = 0;

            scores[0] = 3;
            scores[1] = 7;
            scores[2] = 21;
            scores[3] = 33;


            foreach (int score in scores)
            {

                totalScore += score;
            }

            double averageScore = (double)totalScore / scores.Length;

            Console.WriteLine("Average: " + averageScore);

            //Immutable();

            /*
            string name = " Jeremy ";
            
            name = name.Trim();

            DateTime date = new DateTime(2002,1,1);

            date.AddHours(25);
            
            
            Console.WriteLine(date);




            /*
            DateTime date = new DateTime(2014, 9, 11);

            date.AddDays(3);

            Console.WriteLine(date);



            PassByValueAndRef();
            
            /*
            int x1 = 4;
            int x2 = x1;

            x1 = 100;

            Console.WriteLine("value of x " + x2);

            /*
            GradeBook book = new GradeBook();

            book.AddGrade(91);
            book.AddGrade(23);
            book.AddGrade(88);
            book.AddGrade(92);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine("Average Grade: " + stats.AverageGrade);
            Console.WriteLine("Lowest Grade: " + stats.LowestGrade);
            Console.WriteLine("Highest Grade: " + stats.HighestGrade);

            */

            Console.ReadLine();


        }

        static void GiveBookAName(GradeBook book)
        {
            book.Name = "The GradeBook";
        }

        static void IncrementNumber(ref int number)
        {
            number += 1;
        }

        private static void Immutable()
        {
      
        }

        private static void Arrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            foreach (float grade in grades)
            {
                Console.WriteLine(grade);

            }

        }

        private static void AddGrades(float[] grades)
        {
            grades[0] = 91f;
            grades[1] = 89.1f;
            grades[2] = 75f;

        }


       

      
     

        private static void PassByValueAndRef()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            GiveBookAName(g1);

            Console.WriteLine(g2.Name);
        }
    }



}
