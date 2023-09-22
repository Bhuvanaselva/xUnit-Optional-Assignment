using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string nameFirst = "nathaniel";
            string nameLast = "haWthorNe";
            string expected = "#_Hawthorne,Nathaniel(HAWNAT)";
            string actual = optional_assignment1.Assignment1.Formatter(nameFirst,nameLast);
            Assert.Equal(expected, actual);

        }
    }
}