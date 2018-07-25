using System;

namespace SampleCalculator.Core.Expressions
{
    public struct Expression:IEquatable<Expression>
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
        
        public override string ToString()
        {
            return Value;
        }

        public bool Equals(Expression other)
        {
            return string.Equals(_value, other._value) && string.Equals(ExpressionType, other.ExpressionType);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Expression && Equals((Expression) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((_value != null ? _value.GetHashCode() : 0) * 397) ^ (ExpressionType != null ? ExpressionType.GetHashCode() : 0);
            }
        }
    }
}