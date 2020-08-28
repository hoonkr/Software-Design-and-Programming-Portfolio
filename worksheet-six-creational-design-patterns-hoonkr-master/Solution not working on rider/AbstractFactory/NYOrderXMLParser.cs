using System;

namespace QuestionOne
{
    public class NYOrderXMLParser : IXMLParser
    {
        public string Parse()
        {
            Console.WriteLine("NY Parsing order XML...");
            return "NY order XML Message";
        }
        
    }
}