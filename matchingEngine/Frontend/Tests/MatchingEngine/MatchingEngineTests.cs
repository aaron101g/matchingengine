using matchingEngine.Frontend.Tests.MatchingEngine.SetUp;

namespace matchingEngine.Frontend.Tests.MatchingEngine
{
    public class MatchingEngine
    {
        public MatchingEngineMethods _matchEngine;
        public string _url;

        public MatchingEngine()
        {
            _matchEngine = new MatchingEngineMethods();
            _url = _matchEngine._matchengineUtils.url;
        }

        [Fact]
        public void Test1()
        {
            _matchEngine.InitializeFE(_url);
            _matchEngine.GoToRepManageModule(); //could add an assert to verify correct url in browser or page title
            _matchEngine.ScrollToElement(_matchEngine._matchengineUtils.additionalFeaturesHeading);
            _matchEngine.ClickElement(_matchEngine._matchengineUtils.productsSupportedNav);
            Assert.True(true);
        }
    }
}
