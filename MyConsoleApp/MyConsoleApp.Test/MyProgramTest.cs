using Xunit;

namespace MyConsoleApp.Test
{
    public class MyProgramTest
    {
        [Fact]
        public void VerifyGet()
        {
            const int firstNumber = 19;
            const int secondNumber = 23;
            var objTargetClass = new MyProgram();
            var result = objTargetClass.Add(firstNumber, secondNumber);
            Assert.Equal((firstNumber + secondNumber), result);
        }
    }
}
