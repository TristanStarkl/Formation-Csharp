using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class ElementaryOperations
    {
        public static void BasicOperation(int a, int b, char operation)
        {

            string res = $"{a} {operation} {b} = ";
            switch (operation)
            {
                case '+':
                    Console.WriteLine(res + (a + b));
                    break;
                case '-':
                    Console.WriteLine(res + (a - b));

                    break;
                case '/':
                    {
                        if (b != 0)
                            Console.WriteLine(res + (a / b));
                        else
                            Console.WriteLine(res + "Opération invalide");
                        break;
                    }
                case '*':
                    Console.WriteLine(res + (a * b));
                    break;

                default:
                    Console.WriteLine(res + "Opération invalide");
                    break;
            }
        }

        public static void IntegerDivision(int a, int b)
        {
            // a = qb + r
            // find r and q
            if (b == 0)
            {
                Console.WriteLine($"{a} : {b} = Opération invalide");
                return;
            }
            int q = a / b;
            int r = a % b;
            if (r != 0)
                Console.WriteLine($"{a} = {q} * {b} + {r}");
            else
                Console.WriteLine($"{a} = {q} * {b}");
        }

        public static void Pow(int a, int b)
        {
            if (b < 0)
            {
                Console.WriteLine($"{a} ^ {b} = Opération invalide");
                return;
            }
            if (b == 0)
            {
                Console.WriteLine($"{a} ^ {b} = 1");
                return;
            }
            int temp = a;
            for (int i = 0; i < b; i++)
            {
                temp *= a;
            }
            Console.WriteLine($"{a} ^ {b} = {temp}");
        }
    }
}
