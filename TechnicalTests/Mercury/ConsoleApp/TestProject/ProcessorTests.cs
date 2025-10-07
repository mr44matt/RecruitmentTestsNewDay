using ConsoleApp;

namespace TestProject
{
    public class ProcessorTests
    {
        [Fact]
        public void Given1ProcessorReturns2()
        {
            var x = 1;
            Processor.Process(x);
            Assert.Equal(2, Processor.Process(x));
        }
    }
}