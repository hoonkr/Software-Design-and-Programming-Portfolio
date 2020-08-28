namespace QuestionOne
{
    public class SFParseFactory:IAbstractParserFactory
    {
        public IXMLParser GetParserInstance(string parserType)
        {
            switch (parserType)
            {
                case "SFERROR": return new SFErrorXMLParser();
                case "SFFEEDBACK": return new SFFeedbackXMLParser();
                case "SFORDER":return new SFOrderXMLParser();
                case "SFRESPONSE":return new SFResponseXMLParser();
            }
            return null;
        }
    }
}