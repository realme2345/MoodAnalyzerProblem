using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerPracticeProblem
{
    public class MoodAnlyzer
    {
        public string message;
        public MoodAnlyzer(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else if (message.Equals(string.Empty))
                {
                    throw new MoodAnalyzerExcep(MoodAnalyzerExcep.ExceptionType.EMPTY_EXCEPTION, "Message Should not be null");

                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                // return "happy";
                throw new MoodAnalyzerExcep(MoodAnalyzerExcep.ExceptionType.NULL_EXCEPTION, "Message Should not be null");
            }
        }
    }
}
