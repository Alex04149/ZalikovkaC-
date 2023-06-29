
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
            double numeral = (Coeficients.higherMath * higerMath + Coeficients.fiziks * fiziks + Coeficients.informaticks * informaticks
                + Coeficients.history * history + Coeficients.tca * TCA +Coeficients.english*english
                + Coeficients.ecology * ecology + Coeficients.PE * PE);   
            double rating;
            rating = (90.0 * numeral)/ (Coeficients.sum * 100);
            Console.WriteLine("Your rating score =" + rating);
            Console.ReadLine();
        }
    }
}
