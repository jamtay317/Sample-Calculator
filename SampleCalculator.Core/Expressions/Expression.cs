using System;
using System.Linq;

namespace SampleCalculator.Core.Expressions
{
    public struct Expression:IEquatable<Expression>
    {
       public static implicit operator  Expression (string v)
        {
            //assume that expression looks like expressionType(value to evaluate)
            var expression = new Expression(){_value = v};

            if (expression.Value == null) return expression;

            expression.ExpressionType = GetExpressionType(expression);

            return expression;
        }
        public static Expression operator  +(Expression e, string v)
        {
            var newExpression = new Expression(){_value = $"{e}{v}"};
            newExpression.ExpressionType = GetExpressionType(newExpression);
            return newExpression;
        }

        public Expression(string value)
        {
            _value = value;
            ExpressionType = Constants.Expressions.Basic;
        }

        private static string GetExpressionType(Expression expression)
        {
            if(expression.Value == null) throw  new NullReferenceException();
            var firstPernIndex = expression.Value.IndexOf("(",StringComparison.CurrentCulture);

            var expressionType = (firstPernIndex>0)? 
                expression.Value.Substring(0, firstPernIndex): 
                Constants.Expressions.Basic;

            var actualExpressionType = Constants.Expressions.ExpressionNames.FirstOrDefault(x => x == expressionType);

            if (string.IsNullOrWhiteSpace(actualExpressionType)) throw new NotImplementedException();

            return actualExpressionType;
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