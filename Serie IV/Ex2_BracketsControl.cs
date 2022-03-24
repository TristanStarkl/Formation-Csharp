using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_IV
{
    public static class BracketsControl
    {
        public static bool BracketsControls(string sentence)
        {
            Stack<char> _MyStack = new Stack<char>();
            foreach (char c in sentence)
            {
                if (c == '(' || c == '{' || c == '[')
                    _MyStack.Push(c);
                if (c == ')' || c == '}' || c == ']')
                {
                    char poped = _MyStack.Pop();
                    if ((poped == '(' && c != ')') ||
                        (poped == '{' && c != '}') ||
                        (poped == '[' && c != ']'))
                        return false;
                }
            }
            if (_MyStack.Count() == 0)
                return true;
            return false;
        }
    }
}
