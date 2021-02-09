using System;

namespace CSharp_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string countryName = "United States";

            int numberOfStates = 50;

            char a = default;
            char firstLetter = a;

            bool bestNation = true;

            double yearFounded = 1776;

            decimal nationalDeficit = 3100000000;

            Console.WriteLine($"The {countryName} was founded in {yearFounded}. " +
                $"The {countryName} consists of {numberOfStates} unified states." +
                $"Even though the national deficit is {nationalDeficit} The {countryName} is still " +
                $"the greatest nation on Earth.");
        }
    }
}
