using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Program
    {
        static double Proc22(double A, double B, int Op)

        {
            double result = 0;
            if (Op == 1)
            {
                result = A - B;
            }
            if (Op == 2)
            {
                result = A * B;
            }
            if (Op == 3)
            {
                result = A / B;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int A, B, Op;
            Console.WriteLine("Введите числа: ");
            string input = Console.ReadLine();
            A = int.Parse(input);
            input = Console.ReadLine();
            B = int.Parse(input);
            input = Console.ReadLine();
            Op = int.Parse(input);

            double result = Proc22(A, B, Op);
            Console.WriteLine(result);
            
        }
        for (int i=1; i<=15; i++)
            {
            bool k = Proc24(num);
            x
        static bool Proc24(int k)

        {
            if (k % 2 == 0)
            {
                return true;
            }
            else return false;
        }
        static string GetNumberDescription(bool isEven)
        {
            if (isEven == true)
            {
                return "Четное";
            }
            else return "Не четное";
        }
    }
}
