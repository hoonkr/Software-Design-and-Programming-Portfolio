namespace interpreter
{
    public class Subtract : IExpression
    {
        private IExpression leftExpression;
        private IExpression rightExpression;
        
        public Subtract(IExpression leftExpression, IExpression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }
        public int Interpret() => leftExpression.Interpret() - rightExpression.Interpret();
    }
}