using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyzerPracticeProblem;

namespace TestingMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodHappy()
        {
            ///Arrange
            string message = "I am in happy mood";
            string expected = "happy";
            MoodAnlyzer moodanalyzer = new MoodAnlyzer(message);
            ///Act
            string actual = moodanalyzer.AnalyseMood();
            ///Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("Sad Mood")]
        public void GivenSadMessageReturnsSadMood()
        {
            ///Arrange
            string message = "I am in sad mood";
            string expected = "sad";
            MoodAnlyzer moodanalyzer = new MoodAnlyzer(message);

            ///Act
            string actual = moodanalyzer.AnalyseMood();

            ///Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
