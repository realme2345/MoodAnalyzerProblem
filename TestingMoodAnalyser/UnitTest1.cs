using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyzerPracticeProblem;

namespace TestingMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class TestingAnalyzer
        {
            [TestMethod]
            [TestCategory("Happy Mood")]
            public void TestMethodHappy()
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
            [TestMethod]
            [TestCategory("Null Mood")]
            public void GivenNullMessageReturnsHappyMood()
            {
                ///Arrange
                string message = null;
                string expected = "happy";
                MoodAnlyzer moodanalyzer = new MoodAnlyzer(message);

                ///Act
                string actual = moodanalyzer.AnalyseMood();

                ///Assert
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            [TestCategory("Custom Exception")]
            public void GivenNullMessageReturnsCustomException()
            {
                string message = null;
                string expected = "Message Should not be null";
                try
                {
                    ///Arrange


                    MoodAnlyzer moodanalyzer = new MoodAnlyzer(message);

                    ///Act
                    string actual = moodanalyzer.AnalyseMood();


                }
                catch (MoodAnalyserExcep ex)
                {
                    ///Assert
                    Assert.AreEqual(expected, ex.Message);
                }

            }
        }
    }
}
