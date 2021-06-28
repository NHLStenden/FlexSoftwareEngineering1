using NUnit.Framework;
using System;

namespace InDeHaak
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckParentheses("(:)");
            CheckParentheses("):");
            CheckParentheses(")((:))(");
            CheckParentheses("()()(:)(:)(:)()()()()()()()()()()(())");
            CheckParentheses("(()())");
            CheckParentheses("(()(()()))");
            CheckParentheses("(()((((()))((()))(((((()))))))()()))");
            CheckParentheses("((((((((((((((((((((((((()))))))))))))))))))))))))");
        }

        [TestCase("", true)]
        [TestCase("(:)", true)]
        [TestCase("):", false)]
        [TestCase(")((:))(", false)]
        [TestCase("()()(:)(:)(:)()()()()()()()()()()(())", true)]
        [TestCase("(()())", true)]
        [TestCase("(()((((()))((()))(((((()))))))()()))", true)]
        [TestCase("((((((((((((((((((((((((()))))))))))))))))))))))))", true)]
        [TestCase("((((((((((((((((((((((((())))))))))))))))))))))))", false)]
        static public void TestRecursie(string input, bool result)
        {
            Assert.AreEqual(result, CheckParentheses(input));
        }
        
        static bool CheckParentheses(string expr)
        {
            bool result;
            if (expr == "") { return true; }
            if (expr[0] == ')')
            {
                result = false;
            }
            else
            {
                result = CheckParenthesesRecursive(expr) == 0;
            }

            Console.WriteLine("{0} is {1}balanced" , expr, result ? "":"not ");
            return result;
        }
        
        static int CheckParenthesesRecursive(string expr)
        {
            if (expr == "")
            {
                return 0; 
            }

            char first = expr[0];
            string rest = expr.Substring(1);
            if (first == '(')
            {
                return 1 + CheckParenthesesRecursive(rest);
            }
            else if (first == ')')
            {
                return -1 + CheckParenthesesRecursive(rest);
            }
            else 
            {
                return CheckParenthesesRecursive(rest);
            }
        }
        
    }
}