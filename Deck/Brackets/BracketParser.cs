using System;
using System.Collections.Generic;
using System.Linq;

namespace Brackets
{
    public static class BracketParser
    {
        public static bool IsleftBracket(char bracket)
        {
            return '(' == bracket || '[' == bracket || '{' == bracket;
        }

        public static char ReverseBracket(char bracket)
        {
            if (bracket == '{')
                return '}';
            if (bracket == '}')
                return '{';
            if (bracket == '(')
                return ')';
            if (bracket == ')')
                return '(';
            if (bracket == '[')
                return ']';
            if (bracket == ']')
                return '[';
            throw new ArgumentException("illegal argument");
        }

        public static bool IsClosed(char firstBracket, char secondBracket)
        {
            return (firstBracket == '(' && secondBracket == ')') || (firstBracket == '[' && secondBracket == ']') || (firstBracket == '{' && secondBracket == '}');
        }

        public static string IsGood(string input)
        {
            var brackets = input.ToCharArray();
            var bracketStack = new Stack<char>();
            foreach (var bracket in brackets)
            {
                if (IsleftBracket(bracket))
                {
                    bracketStack.Push(bracket);
                }
                else if(bracketStack.Any() && IsClosed(bracketStack.Peek(), bracket))
                {
                    bracketStack.Pop();
                }
                else
                {
                    bracketStack.Push(bracket);
                }
            }
            if (!bracketStack.Any())
                return input;
            var closed = false;
            var broken = false;
            var rightPart = string.Empty;
            var leftpart = string.Empty;
            var reversedStack = bracketStack.Reverse();
            foreach (var bracket in reversedStack)
            {
                if (IsleftBracket(bracket))
                {
                    closed = true;
                    rightPart = ReverseBracket(bracket) + rightPart;
                }
                else
                {
                    if (closed)
                    {
                        return "IMPOSSIBLE";
                    }
                    leftpart = ReverseBracket(bracket) + leftpart;
                }
            }
            return leftpart + input + rightPart;
        }
    }
}
