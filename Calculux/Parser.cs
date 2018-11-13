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
            string value = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--) {
                char token = input[i];
                switch (token) {
                    case 'x':
                        stack.Push(new Variable(token));
                        break;
                    case char character when (char.IsDigit(character)):
                        value = value.Insert(0, character.ToString());

                        char nextToken = input[i - 1];
                        if (nextToken == '-') {
                            i--;
                            value = value.Insert(0, nextToken.ToString());
                        }
                        else if (!char.IsDigit(nextToken) && nextToken != '.' && int.TryParse(value, out int n) && n >= 0 && n <= 9) {
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
                        stack.Push(new Substraction(stack.Pop(), stack.Pop()));
                        break;
                    case '*':
                        stack.Push(new Multiplication(stack.Pop(), stack.Pop()));
                        break;
                    case '/':
                        stack.Push(new Division(stack.Pop(), stack.Pop()));
                        break;
                    case '^':
                        stack.Push(new Power(stack.Pop(), stack.Pop()));
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
                        stack.Push(new Factorial(stack.Pop()));
                        break;
                    case 'p':
                        stack.Push(new RealNumber(Math.PI));
                        break;
                    case char charater when (ignoreCharacters.Contains(charater)):
                        break;
                    default:
                        throw new InvalidNotationException("Input contained invalid notation. Please check and try again!");
                }
            }

            if (stack.Count > 0)
                return stack.Pop();
            return null;
        }

    }
}
