using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_Sharp_fundamentals
{
    class Program
    {

        static void GiveBookAName(GradeBook book)
        {
            book.Name = "The GradeBook";
        }

        static void Main(string[] args)
        {

            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            GiveBookAName(g1);

            Console.WriteLine(g2.Name);
            
            
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
    }



}
