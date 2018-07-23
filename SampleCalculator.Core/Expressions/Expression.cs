namespace SampleCalculator.Core.Expressions
{
    public struct Expression
    {
       public static implicit operator  Expression (string v)
        {
            return new Expression(){_value = v};
        }
        public static Expression operator  +(Expression e, string v)
        {
            return new Expression(){_value = $"{e}{v}"};
        }

        public Expression(string value)
        {
            _value = value;
            ExpressionType = Constants.Expressions.Basic;
        }

        private string _value;
        public string Value => _value;

        public string ExpressionType { get; set; }

        public Expression AddExpression(string expressionName)
        {
            _value = $"{expressionName}({_value})";
            return this;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}