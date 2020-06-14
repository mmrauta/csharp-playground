using Algorithms.Miscellaneous;
using Xunit;

namespace csharp_playground.AlgorithmsTests
{
    public class RobotReturningHomeTest
    {
        [Fact]
        public void ConfirmsRobotReturning()
        {
            var input = "LLLUDRRR";
            var hasReturned = RobotReturningHome.HasReturned(input);
            Assert.True(hasReturned);
        }

        [Fact]
        public void ConfirmsRobotNotReturning()
        {
            var input = "LLLUDRURR";
            var hasReturned = RobotReturningHome.HasReturned(input);
            Assert.False(hasReturned);
        }
    }
}
