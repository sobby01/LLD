using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Interpreter
{
    internal class InterpreterProcess
    {
        internal void CheckInterpreter()
        {

            string tokenString = "2 3 + 5 +";
            List<IExpression> tree = new List<IExpression>();
            string[] tokens = tokenString.Split(' ');
            for (int i = 0; i < tokens.Length; i++)
            {
                if (tokens[i] == "+")
                {
                    if (i + 1 >= tokens.Length)  // Check if there is a next token
                    {
                        Console.WriteLine("Error: Malformed expression.");
                        return;
                    }

                    // it's a nonterminal expression
                    if (tree.Count == 0)
                    {
                        Console.WriteLine("Error: Malformed expression. No left operand for '+'");
                        return;
                    }

                    IExpression left = tree.Last();
                    tree.RemoveAt(tree.Count - 1);
                    IExpression right = new NumberExpression(tokens[++i]);  // Move to the next token safely
                    IExpression subExpression = new PlusExpression(left, right);
                    tree.Add(subExpression);
                }
                else
                {
                    // it's a terminal expression
                    tree.Add(new NumberExpression(tokens[i]));
                }
            }

            if (tree.Count != 1)
            {
                Console.WriteLine("Error: Malformed expression. The input does not form a single valid expression.");
                return;
            }

            Context context = new Context();
            tree.Last().Interpret(context);
            Console.WriteLine($"The result is: {context.Output}");
        }
    }
}
