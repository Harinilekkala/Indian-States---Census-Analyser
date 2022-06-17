namespace IndianStatesAndCode_Testing
{
    public class Tests
    {
        //1.1
        [Test]
        public void GivenStatesCensusCSVFile_CheckNumberOfRecordsMatches()
        {
            int expected = 29;
            string filePath = @"D:\.net\Indian-States---Census-Analyser\IndianStates_Codes\IndianStates_Codes\StateCensusData\StateCensusData.csv";
            IndianStates_Codes.StatesAnalyser getMethod = new IndianStates_Codes.StatesAnalyser();
            int actual = getMethod.DataAnalyser(filePath);
            Assert.AreEqual(expected, actual);
        }
        
    }
}