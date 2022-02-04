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
            MoodAnlyzer moodanalyzer = new MoodAnlyzer(message); //creating object for a class
            ///Act
            string actual = moodanalyzer.AnalyseMood();//hear we check the mood of user is happy or sad
            ///Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("Sad Mood")]
        public void GivenSadMessageReturnsSadMood() //this method for user has a Sad mood
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
