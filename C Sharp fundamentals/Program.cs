using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_Sharp_fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GradeBook book = new GradeBook();

            book.AddGrade(91);
            book.AddGrade(23);
            book.AddGrade(88);
            book.AddGrade(92);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine("Average Grade: " + stats.AverageGrade);
            Console.WriteLine("Lowest Grade: " + stats.LowestGrade);
            Console.WriteLine("Highest Grade: " + stats.HighestGrade);


            Console.ReadLine();


        }
    }

    

}
