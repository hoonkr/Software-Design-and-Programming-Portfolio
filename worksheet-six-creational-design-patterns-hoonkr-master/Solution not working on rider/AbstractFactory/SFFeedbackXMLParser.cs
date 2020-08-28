using System;

namespace QuestionOne
{
    public class SFFeedbackXMLParser: IXMLParser
    {
        public string Parse()
        {
            Console.WriteLine("SF Parsing feedback XML");
            return "SF Feedback XML Message";
        }
    }
}