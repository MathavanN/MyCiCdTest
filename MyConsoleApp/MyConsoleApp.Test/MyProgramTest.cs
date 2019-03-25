using Xunit;

namespace MyConsoleApp.Test
{
    public class MyProgramTest
    {
        [Fact]
        public void Adding_4_And_3_Should_Return_7()
        {
            const int firstNumber = 4;
            const int secondNumber = 3;
            var objTargetClass = new MyProgram();
            var result = objTargetClass.Add(firstNumber, secondNumber);
            Assert.Equal(7, result);
        }

        [Fact]
        public void Adding_Negative_10_And_3_Should_Return_7()
        {
            const int firstNumber = -10;
            const int secondNumber = 3;
            var objTargetClass = new MyProgram();
            var result = objTargetClass.Add(firstNumber, secondNumber);
            Assert.Equal(-7, result);
        }
    }
}
