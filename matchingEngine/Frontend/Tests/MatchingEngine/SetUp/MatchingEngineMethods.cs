using matchingEngine.Frontend.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matchingEngine.Frontend.Tests.MatchingEngine.SetUp
{
    
    public class MatchingEngineMethods : FeGeneralMethods
    {
        public MatchingEngineUtils _matchengineUtils;
        public MatchingEngineMethods() 
        {
            _matchengineUtils = new MatchingEngineUtils();
        }

        public void GoToRepManageModule()
        {
            ClickElement(_matchengineUtils.moduleNav);
            ClickElement(_matchengineUtils.repertoireManagementModuleNav);
        }
    }
}
