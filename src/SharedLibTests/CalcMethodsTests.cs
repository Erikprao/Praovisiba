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

        [Fact]
        public void Test()
        {
            CalcMethods.IterAdd(5, 8, 11).ShouldBe(93);
        }

        [Fact]
        public void TestIterAdd2()
        {
            CalcMethods.SmartAdd(3, 2, 3).ShouldBe(9);
        }

        [Fact]
        public void Test2()
        {
            CalcMethods.SmartAdd(5, 8, 11).ShouldBe(93);
        }

    }
}