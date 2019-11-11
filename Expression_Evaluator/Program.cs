using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using Evaluator;

namespace Expression_Evaluator
{
    
    class Program
    {
        static void Main(string[] args)
        {

            //int variable = 1;
            //DataTable dt = new DataTable();
            //var result1 = dt.Compute("variable * (2 + 3) - 2 / 8", "+variable+");
            //Console.WriteLine("The result is" + result1);

            //Dictionary<string, double> variables = new Dictionary<string, double>();
            //variables.Add("variable1", 5);
            //variables.Add("var", 4);
            //variables.Add("variable2", 2);
            //variables.Add("variable3", 4.25);
            //string expression = "sin(90) * (variable + 1variable2) - 2 / 8";

            //ExpressionEvaluator expressionEvaluator = new ExpressionEvaluator(variables, expression);

            //double result = expressionEvaluator.Evaluate();

            //Console.WriteLine(result);
            //Console.WriteLine(variables.Count);

            ////String delimiters = "!@#$%^&*()-=_+{}|\\][:\"';?><,./ ";

            String str = "sin(90) * (variable1 + variable2) - 2 / 8+var///variable3";

            string[] spearator = { "+", "-", "/", "*", "(", ")", " ", "sin", "cos", "tan" };

            // using the method 
            String[] strlist = str.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;

            var regex = new Regex(@"^[!@#$%^&A-Za-z_-][\w&\-\!\@\#\$\%\^]*$");
            int value;
            int i = 0;


            foreach (String s in strlist)
            {
                if (variables.ContainsKey(s))
                {
                    count1++;
                }

                if (!int.TryParse(s, out value))
                {
                    count3++;
                }

            }

            string[] word = new string[count3];

            foreach (String a in strlist)
            {
                if (!int.TryParse(a, out value))
                {
                    word[i] = a;
                    i++;
                }

            }
            foreach (String a in word)
            {
                if (regex.IsMatch(a))
                {
                    count2++;
                }
                else
                {
                    Console.WriteLine("Invalid Variable Name");
                }
            }

            Console.WriteLine(count1);
            Console.WriteLine(count2);

            foreach (String s in strlist)
            {
                Console.WriteLine(s);
            }

            //if (count2 != count1)
            //{
            //    Console.WriteLine("Ooooops...Expression has Undefined Variables...!!");
            //}
            //else
            //{
            //    Console.WriteLine("Expression is OK");
            //}







            //double? a = null;
            //Console.WriteLine(a);

            //if (variables.ContainsValue())
            //    Console.WriteLine("Value : India is present.");

            //else
            //    Console.WriteLine("Value : India is not present.");

        }
    }
}
