using System;
using System.Runtime.Serialization;

namespace MoodAnalyzerPracticeProblem
{
    [Serializable]
    internal class MoodAnalyserExcep : Exception
    {
        public MoodAnalyserExcep()
        {
        }

        public MoodAnalyserExcep(string message) : base(message)
        {
        }

        public MoodAnalyserExcep(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MoodAnalyserExcep(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}