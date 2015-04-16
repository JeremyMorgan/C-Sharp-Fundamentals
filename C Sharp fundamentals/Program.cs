using System;


namespace C_Sharp_fundamentals
{
    class Program
    {
        private static void WriteBytes(float value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            WriteByteArray(bytes);
        }

        private static void WriteBytes(int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            WriteByteArray(bytes);
        }

        private static void WriteNames(params string[] names)
        {

            foreach (string name in names)
            {
                Console.Write(name);
            }
        }

        private static void WriteByteArray(byte[] bytes)
        {
            foreach (byte b in bytes)
            {
                Console.Write("0x{0:X} {1} {2} ", b, "1", "2");

            }
        }


        static void Main(string[] args)
        {

            GradeBook book = new GradeBook();
            book.AddGrade(91f);
            book.AddGrade(89.1f);
            book.AddGrade(75f);

            GradeStatistics stats = book.ComputeStatistics();

            WriteBytes(stats.AverageGrade);
            WriteNames("Jeremy", "test", "cool", "yeah");

            //Console.WriteLine(stats.AverageGrade);
            //Console.WriteLine(stats.HighestGrade);
            //Console.WriteLine(stats.LowestGrade);


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
