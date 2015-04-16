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
            Console.WriteLine(stats.LetterGrade);
            Console.ReadLine();
        }

    
    }



}
