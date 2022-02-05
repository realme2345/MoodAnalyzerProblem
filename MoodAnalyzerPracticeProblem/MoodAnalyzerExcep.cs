using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerPracticeProblem
{
    class MoodAnalyzerExcep:Exception //Creting custom Exception for user understanding
    {
        public ExceptionType type;
        public enum ExceptionType //declaring the Exception by using the Enum
        {
            NULL_EXCEPTION,
            EMPTY_EXCEPTION
        }
        public MoodAnalyzerExcep(ExceptionType type, string message):base(message) //this method using for catching the Exception
        {
            this.type = type;
        }
    }
}

