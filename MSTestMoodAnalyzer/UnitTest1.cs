using MoodAnalyserProblem;
namespace MSTestMoodAnalyzer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodForHappyMood()
        {
            Mood moodAnalyser = new Mood("I am in happy Mood");
            string expected = "happy";
            string actual = moodAnalyser.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodForSadMood()
        {
            Mood moodAnalyser = new Mood("I am in sad Mood");
            string expected = "sad";
            string actual = moodAnalyser.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }
    }
}