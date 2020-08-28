using System;

namespace QuestionOne
{
    public class NYErrorXMLParser : IXMLParser
    {
        public string Parse()
        {
            Console.WriteLine("NY Parsing error XML...");
            return "NY Error XML message";
        }
        
    }
}