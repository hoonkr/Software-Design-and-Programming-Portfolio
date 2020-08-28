namespace QuestionOne
{
    public static class ParserFactoryProducer
    {
        public static IAbstractParserFactory GetFactory(string factoryType)
            //=> myFactory switch
        {
            switch (factoryType)
            {
                case "NYCFactory" : return  new NYParseFactory();
                case "SFFactory" : return new SFParseFactory();
            }
            return null;
        }
    }
}