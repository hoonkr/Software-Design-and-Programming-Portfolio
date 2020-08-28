using System;

namespace QuestionOne
{
    public class NYFeedbackXMLParser : IXMLParser
    {
        public string Parse()
        {
            Console.WriteLine("NYC Parsing feedback XML...");
            return "NYC Feedback XML Message";
        }
    }
}