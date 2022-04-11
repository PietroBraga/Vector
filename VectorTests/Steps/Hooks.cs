using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using VectorBase.Infrastructure.DriverFactory;
using VectorBase.Infrastructure.TestRunContext;

namespace VectorTests.Steps
{
    [Binding]
    public class Hooks
    {
        public Hooks(TestContext testContext)
        {
            Context.TestContext = testContext;
        }

        [Before]
        public void BeforeScenario()
        {
        }

        [After]
        public void AfterScenario()
        {
            DriverFactory.QuitDriver();
        }
    }
}
