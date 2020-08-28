using System;

namespace Flyweight
{
    public class Code
    {
        public String _Code { get; set; }
        public Code(string code)
        {
            _Code = code;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}