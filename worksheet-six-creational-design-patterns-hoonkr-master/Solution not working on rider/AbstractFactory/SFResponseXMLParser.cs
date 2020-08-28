using System;

namespace QuestionOne
{
    public class SFResponseXMLParser:IXMLParser
    {
        public string Parse()
        {
            Console.WriteLine("SF Parsing response XML...");
            return "SF Response XML Message";
        }
    }
}