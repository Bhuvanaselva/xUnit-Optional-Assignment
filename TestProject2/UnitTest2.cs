namespace TestProject2
{
    public class UnitTest2
    {
        [Fact]
        public void Test1()
        {
            string nameFirst = "ELisabeth";
            string nameLast = "GEorge";
            string expected = "#_George,Elisabeth(GEOELI)";
            string actual = optional_assignment1.Assignment2.Formatter2(nameFirst, nameLast);  
            Assert.Equal(expected, actual);

        }
    }
}