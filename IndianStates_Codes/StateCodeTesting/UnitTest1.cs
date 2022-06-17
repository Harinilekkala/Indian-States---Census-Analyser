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
        //1.2
        [Test]
        public void GivenInvalidFile_ShouldThrowInvalidFileException()
        {
            try
            {
                int expected = 29;
                string filePath = @"D:\.net\Indian-States---Census-Analyser\IndianStates_Codes\IndianStates_Codes\StateCensusData\StateCensus.csv";
                IndianStates_Codes.StatesAnalyser getMethod = new IndianStates_Codes.StatesAnalyser();
                int actual = getMethod.DataAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid File", ex.Message);
            }
        }
        //1.3
        [Test]
        public void GivenInvalidFileType_ShouldThrowInvalidFileTypeException()
        {
            try
            {
                int expected = 29;
                string filePath = @"D:\.net\Indian-States---Census-Analyser\IndianStates_Codes\IndianStates_Codes\StateCensusData\StateCensusData .txt";
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
                string filePath = @"D:\.net\Indian-States---Census-Analyser\IndianStates_Codes\IndianStates_Codes\Invalid Delimiter StateCensusData.csv";
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
                string filePath = @"D:\.net\Indian-States---Census-Analyser\IndianStates_Codes\IndianStates_Codes\Invalid Delimiter StateCensusData.csv";
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