// See https://aka.ms/new-console-template for more information

using System;

namespace IndianStates_Codes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StatesAnalyser getMethod = new StatesAnalyser();
            Console.WriteLine("1 for State Census Analyser\n2 for State Code Analyser\nEnter a Number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    {
                        string filePath = @"D:\.net\Indian-States---Census-Analyser\IndianStates_Codes\IndianStates_Codes\StateCensusData.csv";
                        getMethod.DataAnalyser(filePath);
                        break;
                    }
                case 2:
                    {
                        string filePath = @"D:\.net\Indian-States---Census-Analyser\IndianStates_Codes\IndianStates_Codes\StateCode.csv";
                        getMethod.StateCodeAnalyser(filePath);
                        break;
                    }
            }

        }
    }
}