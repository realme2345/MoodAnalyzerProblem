using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyzerPracticeProblem;

namespace MoodAnlyzerTestCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestingMoodAnlyZer()
        {
            ///Arrange
            string message = "I am in HAPPY mood";
            string expected = "happy";
            MoodAnlyzer moodanalyzer = new MoodAnlyzer(message);

            ///Act
            string actual = moodanalyzer.AnalyseMood();

            ///Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
