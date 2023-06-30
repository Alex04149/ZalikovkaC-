
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
            int higherMath, physics, informatics, history, TDA, ecology, english, PE;
            Console.WriteLine("Enter the rating for higher math:");
            higherMath = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an assessment in physics:");
            physics = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an assessment in computer science:");
            informatics = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an estimate from history:");
            history = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the TDA score:");
            TDA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter environmental assessment");
            ecology = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an assessment in English:");
            english = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the assessment in physical education:");
            PE = int.Parse(Console.ReadLine());
            double numeral = (Coeficients.higherMath * higherMath + Coeficients.physics * physics + Coeficients.informatics * informatics
                + Coeficients.history * history + Coeficients.TDA * TDA +Coeficients.english*english
                + Coeficients.ecology * ecology + Coeficients.PE * PE);   
            double rating;
            const double maxAssessmentOfDiscipline = 90;
            const int maxAssessmentOfRating = 100;
            rating = (maxAssessmentOfDiscipline * numeral)/ (Coeficients.sum * maxAssessmentOfRating);
            Console.WriteLine("Your rating score =" + rating);
            Console.ReadLine();
        }
    }
}
