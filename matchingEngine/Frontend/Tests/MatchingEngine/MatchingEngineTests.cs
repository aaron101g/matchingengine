using matchingEngine.Frontend.Tests.MatchingEngine.SetUp;

namespace matchingEngine.Frontend.Tests.MatchingEngine
{
    public class MatchingEngine
    {
        public MatchingEngineMethods _matchEngine;

        public MatchingEngine()
        {
            _matchEngine = new MatchingEngineMethods();
        }

        [Fact]
        public void Test1()
        {
            _matchEngine.
            Assert.True(true);
        }
    }
}
