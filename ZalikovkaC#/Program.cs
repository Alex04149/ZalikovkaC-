
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data.SqlTypes;

namespace Learn
{
    class Program
    {
        static void Main(string[] args)
        {
            const int k_1 = 6, k_2 = 5, k_3 = 4, k_4 = 4, k_5 = 4, k_6 = 3, k_7 = 2, k_8 = 2;
            int higerMath, fiziks, informaticks, history, TCA, ecology, english, PE;
            Console.WriteLine("Enter the rating for vishmat:");
            higerMath = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an assessment in physics:");
            fiziks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an assessment in computer science:");
            informaticks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an estimate from history:");
            history = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the TCA score:");
            TCA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter environmental assessment");
            ecology = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an assessment in English:");
            english = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the assessment in physical education:");
            PE = int.Parse(Console.ReadLine());
            double rating;
            rating = 90.0 * (k_1 * higerMath + k_2 * fiziks + k_3 * informaticks + k_4 * TCA + k_5 * history + k_6 * ecology  + k_7 * english + k_8 * PE)
                 / ((k_1 + k_2 + k_3 + k_4 + k_5 + k_6 + k_7 + k_8) * 100);
            Console.WriteLine("Your rating score =" + rating);
            Console.ReadLine();
        }
    }
}
