using NUnit.Framework;

namespace NUnitProject
{
    /// <summary>
    /// IMPORTANT: Init Setup only apply for same namespace
    /// </summary>
    [SetUpFixture]
    public class InitSetupForAllUnitTest
    {
        [OneTimeSetUp]
        public void Setup()
        {
            // DO NOT EDIT THIS INIT FUNCTION
            BaseIntegrationTestGlobal.SetEnvironment("Local");
            BaseIntegrationTestGlobal.InitConfig();
            BaseIntegrationTestGlobal.InitServiceCollection();

            // CODE FROM HERE IF YOU WANT TO GLOBAL INIT


        }
    }
}
