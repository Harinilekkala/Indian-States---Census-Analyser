namespace IndianStatesAnd_CodeTesting

{
    public class Tests
    {
        [Test]
        public void GivenStatesCensusCSVFile_CheckNumberOfRecordsMatches()
        {
            int expected = 29;
            string filePath = @"D:\.net\Indian-States---Census-Analyser\IndianStates_Codes\IndianStates_Codes\StateCodeData.csv";
            IndianStates_Codes.StatesAnalyser sc = new IndianStates_Codes.StatesAnalyser();
            int actual = sc.DataAnalyser(filePath);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GivenInvalidFile_ShouldThrowInvalidFileException()
        {
            try
            {
                int expected = 29;
                string filePath = @"D:\.net\Indian-States---Census-Analyser\IndianStates_Codes\IndianStates_Codes\StateCodeData.csv";
                IndianStates_Codes.StatesAnalyser getMethod = new IndianStates_Codes.StatesAnalyser();
                int actual = getMethod.DataAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid File", ex.Message);
            }
        }
        [Test]
        public void GivenInvalidFileType_ShouldThrowInvalidFileTypeException()
        {
            try
            {
                int expected = 29;
                string filePath = @"D:\BridgeLabz\IndianStates-CensusAnalyser\IndianStates_Codes\StateCensusData.txt";
                IndianStates_Codes.StatesAnalyser getMethod = new IndianStates_Codes.StatesAnalyser();
                int actual = getMethod.DataAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid File Type", ex.Message);
            }
        }
        [Test]
        public void GivenInvalidDelimiterFile_ShouldThrowInvalidDelimiterFileTypeException()
        {
            try
            {
                int expected = 29;
                string filePath = @"D:\BridgeLabz\IndianStates-CensusAnalyser\IndianStates_Codes\InvalidDelimiterCensusData.csv";
                IndianStates_Codes.StatesAnalyser getMethod = new IndianStates_Codes.StatesAnalyser();
                int actual = getMethod.DataAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Incorrect Delimiter", ex.Message);
            }
        }
        [Test]
        public void GivenIncorrectHeaderFile_ShouldThrowIncorrectHeaderFileTypeException()
        {
            try
            {
                int expected = 29;
                string filePath = @"D:\BridgeLabz\IndianStates-CensusAnalyser\IndianStates_Codes\IncorrectHeaderCensusData.csv";
                IndianStates_Codes.StatesAnalyser getMethod = new IndianStates_Codes.StatesAnalyser();
                int actual = getMethod.DataAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Incorrect Header", ex.Message);
            }
        }
    }
}