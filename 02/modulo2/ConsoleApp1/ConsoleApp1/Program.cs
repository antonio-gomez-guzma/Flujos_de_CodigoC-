﻿using System;

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

            // Logical comparisons
            bool higherCoffeeScore = Q1Results.CoffeeScore > Q1Results.FoodScore;
            bool customersRecommend = Q1Results.WouldRecommend >= 7;
            bool noGranolaYesCappucino = Q1Results.LeastFavoriteProduct == "Granola" && Q1Results.FavoriteProduct == "Cappucino";

            Console.WriteLine($"Coffee Score Higher Than Food: {higherCoffeeScore}");
            Console.WriteLine($"Customers Would Recommend Us: {customersRecommend}");
            Console.WriteLine($"Hate Granola, Love Cappucino: {noGranolaYesCappucino}");
        }
    }
}
