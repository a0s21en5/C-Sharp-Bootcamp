using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Number = new int[5000];

            double case_A = 0;
            double case_B = 0;
            double case_C = 0;
            double case_D = 0;
            double case_E = 0;
            double case_F = 0;
            double case_G = 0;
            double case_H = 0;
            double case_I = 0;


            Random random = new Random();

            for (int j = 0; j < 5000; j++)
            {
                Number[j] = random.Next(798, 906);

                if (Number[j] % 2 == 0)
                {
                    case_B++;
                }
                else
                {
                    case_I++;
                }

                if (Number[j] >= 799 && Number[j] <= 852)
                {
                    case_C++;
                }

                if (Number[j] >= 835 && Number[j]<=870)
                {
                    case_D++;
                }

                if (Number[j] >= 799 && Number[j] <= 834)
                {
                    case_E++;
                }

                if (Number[j] >= 853 && Number[j] <= 906)
                {
                    case_F++;
                }

                if (Number[j] >= 871 && Number[j] <= 906)
                {
                    case_G++;
                }

                if (Number[j] == 798)
                {
                    case_H++;
                }
            }

            Console.WriteLine($"Even Case B : {case_B}/5000 = {(case_B/5000)*100}\n");

            Console.WriteLine($"Case C 799 to 852 = {(case_C / 5000) * 100}\n");

            Console.WriteLine($"Case D 835 to 870 = {(case_D / 5000) * 100}\n");

            Console.WriteLine($"Case E 799 to 834 = {(case_E / 5000) * 100}\n");

            Console.WriteLine($"Case F 853 to 906 = {(case_F / 5000) * 100}\n");

            Console.WriteLine($"Case G 871 to 906 = {(case_G / 5000) * 100}\n");

            Console.WriteLine($"Case H 798 = {(case_H / 5000) * 100}\n");

            Console.WriteLine($"Odd Case I : {case_I}/5000 = {(case_I / 5000) * 100}\n");

            Console.ReadLine();
        }
    }
}
