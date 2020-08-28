using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionOne
{
    class NYParseFactory: IAbstractParserFactory
    {
        public IXMLParser GetParserInstance(string parserType)
        {
            switch (parserType)
            {
                case "NYCERROR":return new NYErrorXMLParser();
                case "NYCFEEDBACK":return new NYFeedbackXMLParser();
                case "NYCORDER": return new NYOrderXMLParser();
                case "NYCRESPONSE": return new NYResponseXMLParser();
            }

            return null;
        }
       
    }
}
