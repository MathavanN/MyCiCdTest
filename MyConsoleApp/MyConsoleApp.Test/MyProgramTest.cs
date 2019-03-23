using Xunit;

namespace MyConsoleApp.Test
{
    public class MyProgramTest
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("42", new MyProgram().Get(19, 23));
        }
    }
}
