// See https://aka.ms/new-console-template for more information

using System;

namespace IndianStates_Codes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string filePath = @"D:\.net\Indian-States---Census-Analyser\IndianStates_Codes\IndianStates_Codes\StateCodeData\StateCensusData.csv";
            IndianStates_Codes.StatesAnalyser  sc = new IndianStates_Codes.StatesAnalyser();

            int obj = sc.DataAnalyser(filePath);
        }
    }
}