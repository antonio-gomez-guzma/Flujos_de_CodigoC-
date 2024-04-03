using System;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculated values
            double responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed; 
            double unanweredCount = Q1Results.NumberSurveyed - Q1Results.NumberResponded;

            double overallScore = (Q1Results.ServiceScore + Q1Results.CoffeeScore + Q1Results.PriceScore + Q1Results.FoodScore) / 4;





            Console.WriteLine($"Response Percentage: {responseRate}");
            Console.WriteLine($"Unanswered Surveys: {unanweredCount}");
            Console.WriteLine($"Overall Score: {overallScore}");


        }
    }
}
