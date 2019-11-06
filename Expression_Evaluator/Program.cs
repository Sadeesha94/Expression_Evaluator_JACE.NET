using System;
using System.Collections.Generic;
using Evaluator;

namespace Expression_Evaluator
{
    
    class Program
    {
        static void Main(string[] args)
        {
            ExpressionEvaluator expressionEvaluator = new ExpressionEvaluator();
            

            Dictionary<string, double> variables = new Dictionary<string, double>();
            variables.Add("variable1", -1);
            variables.Add("variable2", 2);
            variables.Add("Variable3", 4.25);

            double result = expressionEvaluator.Evaluate(variables, "sin(90) * (variable1 + Variable2) - 2 * Variable3 / 8");

            Console.WriteLine(result);
        }
    }
}
