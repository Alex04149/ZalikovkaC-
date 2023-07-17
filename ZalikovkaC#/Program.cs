using System;

namespace Learn
{
    class Program
    {
        static void Main(string[] args)
        {
            double rating;
            const double maxAssessmentOfDiscipline = 90;
            const int maxAssessmentOfRating = 100;
            int higherMathScore = 0, physicsScore = 0, informaticsScore = 0, historyScore = 0, TheoryOfDigitalAutomataScore = 0, ecologyScore = 0, englishScore = 0, physicalEducationScore = 0;
            try
            {
                Console.WriteLine("Enter the rating for higher math:");
                    higherMathScore = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter an assessment in physics:");
                    physicsScore = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter an assessment in computer science:");
                    informaticsScore = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter an estimate from history:");
                    historyScore = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the TDA score:");
                    TheoryOfDigitalAutomataScore = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter environmental assessment");
                    ecologyScore = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter an assessment in English:");
                    englishScore = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the assessment in physical education:");
                    physicalEducationScore = int.Parse(Console.ReadLine());
                double numeral = (Coefficients.higherMath * higherMathScore + Coefficients.physics * physicsScore + Coefficients.informatics * informaticsScore
                + Coefficients.history * historyScore + Coefficients.TDA * TheoryOfDigitalAutomataScore + Coefficients.english * englishScore
                + Coefficients.ecology * ecologyScore + Coefficients.PE * physicalEducationScore);
                     rating = (maxAssessmentOfDiscipline * numeral) / (Coefficients.sum * maxAssessmentOfRating);
                Console.WriteLine("Your rating score =" + rating);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("ERROR!PLEASE ENTER RIGHT SCORE!");
            }
        }
    }
}
