using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C_Sharp_fundamentals;

namespace Grades.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculatesHighestGrade()
        {

            GradeBook book = new GradeBook();
            book.AddGrade(90f);
            book.AddGrade(50f);

            GradeStatistics stats = book.ComputeStatistics();

            Assert.AreEqual(90f, stats.HighestGrade);

        }

        [TestMethod]

        public void PassByValue()
        {
            GradeBook book = new GradeBook();
            book.Name = "Not set";
            SetName(book);

            Assert.AreEqual("Not set", book.Name);
            
        }

        void SetName(GradeBook book)
        {
            book.Name = "Name set";
        }

    }
}
