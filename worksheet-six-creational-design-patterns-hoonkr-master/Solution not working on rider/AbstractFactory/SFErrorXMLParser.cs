using System;

namespace QuestionOne
{
    public class SFErrorXMLParser: IXMLParser
    {
        public string Parse()
        {
            Console.WriteLine("SF Parsing error XML...");
            return "SF Error XML Message";
        }
    }
}