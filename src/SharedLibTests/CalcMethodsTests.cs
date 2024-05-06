using SharedLib;
using Shouldly;

namespace SharedLibTests
{
    public class CalcMethodsTests
    {
        [Fact]
        public void TestIterAdd()
        {
            CalcMethods.IterAdd(3, 2, 3).ShouldBe(9);
        }
    }
}