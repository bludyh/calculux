using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculux.Maths;

namespace Calculux {
    static class Parser {

        private static readonly char[] ignoreCharacters;
        private static readonly Stack<Function> stack;

        static Parser() {
            ignoreCharacters = new char[] { ' ', '(', ')', ',' };
            stack = new Stack<Function>();
        }

        public static Function Parse(string input) {
            var value = string.Empty;

            for (var i = input.Length - 1; i >= 0; i--) {
                var token = input[i];
                switch (token) {
                    case 'x':
                        stack.Push(new Variable());
                        break;
                    case char character when (char.IsDigit(character)):
                        value = value.Insert(0, character.ToString());

                        var nextToken = (i > 0) ? input[i - 1] : '\0';
                        if (nextToken == '-') {
                            value = value.Insert(0, nextToken.ToString());
                            i--;
                        }
                        else if (!char.IsDigit(nextToken) && nextToken != '.' && int.TryParse(value, out var n) && n >= 0 && n <= 9) {
                            stack.Push(new NaturalNumber(Convert.ToInt32(value)));
                            value = string.Empty;
                        }
                        break;
                    case '.':
                        value = value.Insert(0, token.ToString());
                        break;
                    case 'n':
                        stack.Push(new NaturalNumber(Convert.ToInt32(value)));
                        value = string.Empty;
                        break;
                    case 'r':
                        stack.Push(new RealNumber(Convert.ToDouble(value)));
                        value = string.Empty;
                        break;
                    case '+':
                        stack.Push(new Addition(stack.Pop(), stack.Pop()));
                        break;
                    case '-':
                        var prevToken = input[i + 1];
                        if (prevToken == '(')
                            stack.Push(new Substraction(stack.Pop(), stack.Pop()));
                        else
                            stack.Push(new Negation(stack.Pop()));
                        break;
                    case '*':
                        stack.Push(new Multiplication(stack.Pop(), stack.Pop()));
                        break;
                    case '/':
                        stack.Push(new Division(stack.Pop(), stack.Pop()));
                        break;
                    case '^':
                        stack.Push(new Power(stack.Pop(), (NaturalNumber)stack.Pop()));
                        break;
                    case 's':
                        stack.Push(new Sine(stack.Pop()));
                        break;
                    case 'c':
                        stack.Push(new Cosine(stack.Pop()));
                        break;
                    case 'e':
                        stack.Push(new Exponentiation(stack.Pop()));
                        break;
                    case 'l':
                        stack.Push(new NaturalLogarithm(stack.Pop()));
                        break;
                    case '!':
                        stack.Push(new Factorial((NaturalNumber)stack.Pop()));
                        break;
                    case 'p':
                        stack.Push(new RealNumber(Math.PI));
                        break;
                    case char charater when (ignoreCharacters.Contains(charater)):
                        break;
                    default:
                        throw new FormatException();
                }
            }

            if (stack.Count > 0)
                return stack.Pop();
            throw new NullReferenceException();
        }

        public static async Task<(Function X, double Result)> ParseAndEvaluate(string input, Func<double, double> f) {
            if (string.IsNullOrWhiteSpace(input))
                throw new Exception("Please enter a value!");

            if (input.Contains('x'))
                throw new Exception("Value cannot contain variable!");

            var x = Parse(input);
            var result = await Task.Run(() => f(x.Evaluate(0)));
            return (X: x, Result: result);
        }

        public static async Task<(Function A, Function B, double Result)> ParseAndEvaluate(string input1, string input2, Func<double, double, double> f) {
            if (string.IsNullOrWhiteSpace(input1) || string.IsNullOrWhiteSpace(input2))
                throw new Exception("Please enter values for both inputs!");

            if (input1.Contains('x') || input2.Contains('x'))
                throw new Exception("Value cannot contain variable!");

            var a = Parse(input1);
            var b = Parse(input2);
            var result = await Task.Run(() => f(a.Evaluate(0), b.Evaluate(0)));
            return (A: a, B: b, Result: result);
        }

    }
}
