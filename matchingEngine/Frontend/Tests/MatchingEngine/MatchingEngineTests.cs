using matchingEngine.Frontend.Tests.MatchingEngine.SetUp;

namespace matchingEngine.Frontend.Tests.MatchingEngine
{
    public class MatchingEngine : IDisposable
    {
        public MatchingEngineMethods _matchEngine;
        public string _url;

        public MatchingEngine()
        {
            _matchEngine = new MatchingEngineMethods();
            _url = _matchEngine._matchengineUtils.url;
        }

        public void Dispose()
        {
            _matchEngine.Driver.Quit();
            _matchEngine.Driver.Dispose();
        }


        [Fact]
        public void ProductSupportTitleTest()
        {
            string expectedText = "There are several types of Product Supported:";

            _matchEngine.InitializeFE(_url);
            _matchEngine.GoToRepManageModule(); //could add an assert to verify correct url in browser or page title
            _matchEngine.ScrollToElement(_matchEngine._matchengineUtils.additionalFeaturesHeading);
            _matchEngine.ClickElement(_matchEngine._matchengineUtils.productsSupportedNav);

            Assert.Equal(expectedText, _matchEngine._matchengineUtils.productsSupportedAssertionText);
        }

        
    }
}
