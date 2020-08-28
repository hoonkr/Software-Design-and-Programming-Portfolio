using System;

namespace QuestionOne
{
    public class NYResponseXMLParser : IXMLParser
    {
        public string Parse()
        {
            Console.WriteLine("NY Parsing response XML...");
            return "NY Response XML Message";
        }
    }
}