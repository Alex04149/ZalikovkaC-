using System;
using System.Collections.Generic;

namespace Record_book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double maxAssessmentOfDiscipline = 90.0;
            const int maxAssessmentOfRating = 100;
            int semester;
            int sumScoreAndCoefficient = 0;
            int sumCoefficient = 0;
            double rating;
            try
            {
                Console.WriteLine("Enter your semester");
                semester = int.Parse(Console.ReadLine());
                List<Subject> subjects = Subject.getSubject(semester);
                try
                {
                    for (int i = 0; i < subjects.Count - 1; i++)
                    {
                        Console.WriteLine("Enter score by " + subjects[i].name);
                        subjects[i].Score = int.Parse(Console.ReadLine());
                    }
                    for (int i = 0; i < subjects.Count - 1; i++)
                    {
                        int temp;
                        temp = subjects[i].Score * subjects[i].Coefficient;
                        sumScoreAndCoefficient += temp;
                        sumCoefficient += subjects[i].Coefficient;
                    }
                    rating = (maxAssessmentOfDiscipline * sumScoreAndCoefficient) / (sumCoefficient * maxAssessmentOfRating);
                    if (rating > 0 && rating < 100)
                    {
                        Console.WriteLine("Your rating score = " + rating);
                    }
                    else
                    {
                        Console.WriteLine("ERROR!");
                    }
                    Console.ReadLine();
                }
                catch { Console.WriteLine("Enter right score"); }
            }
            catch { Console.WriteLine("Enter right semester"); }

        }

    }
}