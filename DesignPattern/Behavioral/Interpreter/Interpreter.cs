using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Interpreter
{
    // AbstractExpression
    public interface IExpression
    {
        void Interpret(Context context);
    }

    // TerminalExpression
    public class NumberExpression : IExpression
    {
        private int number;

        public NumberExpression(int number)
        {
            this.number = number;
        }

        public NumberExpression(string number)
        {
            this.number = int.Parse(number);
        }

        public void Interpret(Context context)
        {
            context.Output = number;
        }
    }

    // NonterminalExpression
    public class PlusExpression : IExpression
    {
        private IExpression leftExpression;
        private IExpression rightExpression;

        public PlusExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }

        public void Interpret(Context context)
        {
            leftExpression.Interpret(context);
            int left = context.Output;
            rightExpression.Interpret(context);
            int right = context.Output;
            context.Output = left + right;
        }
    }
}
