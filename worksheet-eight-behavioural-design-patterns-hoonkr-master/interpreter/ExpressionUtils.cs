namespace interpreter
{
    public sealed class ExpressionUtils
    {
        public static bool IsOperator(string s)
        {
            if (s.Equals("+") || s.Equals("-") || s.Equals("*"))
                return true;
            else
                return false;
        }

        public static IExpression GetOperator(string s, IExpression left, IExpression right)
        {
            switch (s)
            {case "+":
                return new Add(left,right);
            case "-":
                return new Subtract(left,right);
            case"*":
                return new Product(left,right);

            }

            return null;
        }
    }
}