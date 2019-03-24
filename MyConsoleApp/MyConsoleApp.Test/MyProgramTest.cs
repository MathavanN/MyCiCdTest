using Xunit;

namespace MyConsoleApp.Test
{
    public class MyProgramTest
    {
        [Fact]
        public void VerifyGet()
        {
            const int intFirstNumber = 19;
            const int intsecondNumber = 23;
            var objTargetClass = new MyProgram();
            var result = objTargetClass.Get(intFirstNumber, intsecondNumber);
            Assert.Equal("42", result);
        }
    }
}
