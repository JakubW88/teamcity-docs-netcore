using System;
using System.Threading;
using Xunit;

namespace tests
{
    public class UnitTests
    {
        [Fact]
        public void Test1()
        {
            // does nothing, the best type of test!
        }

        [Fact]
        public void SlowTestForTestResultsOnTheFly()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }
    }
}
