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
        }

        private string _value;
        public string Value => _value;

        public override string ToString()
        {
            return Value;
        }
    }
}