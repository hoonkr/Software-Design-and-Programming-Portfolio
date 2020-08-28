using System;

namespace QuestionOne
{
    public class SFOrderXMLParser:IXMLParser
    {
        public string Parse()
        {
            Console.WriteLine("SF Parsing order XML...");
            return "SF Order XML Message";
        }
    }
}