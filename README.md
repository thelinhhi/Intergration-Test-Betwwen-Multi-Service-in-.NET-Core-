# Unit Test And Intergration Test Of Multi Service By NUnit in .NET Core 

# 1. Overview
As developers, we all know the importance of writing test cases for each feature we create. Test cases help us ensure that features work correctly and reliably. To improve my skills in this domain, I completed a few courses. However, I realized that while the courses covered the basics, they didn't provide pratical guidance I needed to apply testing effectively in my projects.
Specifically, I struggled with testing services that involve dependancy injection. To address this challenge, I created this project as a way to learn and implement NUnit for both unit testing and Intergration testing. 
I hope this project can serve as a useful resource for anyone facing similar challenges. If you're looking for pratical examples or inspiration, I believe you'll find somthing interesting here. 

# 2. Table of Contents

# 3. Architecture
To keep things simple, this project follows a 3-tier layer architecture:
- Presentation Layer: This include the project NUnitForMockUnitTestAndIntegrationTest, which represents the user-facing layer
- Application Layer: Handles the business logic
- Infrastructure Layer: Manages data access, external APIs
- Core Layer: Manages interface, unit of work, model, entity

And the project named "NUnitProject" for creating and managing test cases.

# 4. Intergration test with Dependancy injection:
To set up testing services with Dependancy Injection in NUnitProject, we use the ServiceCollection to manage dependancies. Below are the steps and details:
1. Declaration in "BaseIntegrationTestGlobal.cs". In this file, we declare

```bash
private static ServiceCollection _servicesCollection; // For registrating services 
private static ServiceProvider _serviceProvider; // For resolving service with Dependancy Injection
```
2. Base Functions for configuration and Setup
BaseIntegrationTestGlobal.cs contains base functions to configure and initialize the setup:
 - InitConfig(): Binds data from environment-specific appsettings files
 - InitServiceCollection(): initializes the ServiceCollection for dependancies registration
 - GetService<T>: Resolves and provides a service using Dependancy Injection 

To set up the environment and configure services globally for all unit tests, the InitSetupForAllUnitTest.cs file contains the following setup:
```bash
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
```
3. Setting Up for Specific Test Cases
To set up the test environment for a specific service, such as ContractService:
```bash
      private AppSettings _appSettings;
      private IContractService _DIContractService;
      private IContractService _newContractService;
      [SetUp]
      public void Setup()
      {
          _appSettings = BaseIntegrationTestGlobal.GetService<AppSettings>();
          _DIContractService = BaseIntegrationTestGlobal.GetService<IContractService>(); // Service with Dependancy injection
          _newContractService = new ContractService(_appSettings); // Create neu Service 
      }
```
4. Creating a Test Case
Below is an example test case for the GetById method:
```bash
        [Test]
        public async Task GetById()
        {
            var rs1 = await _DIContractService.GetById(2);
            Console.WriteLine(rs1.ToString());

            Assert.Pass();
        }
```
This structure allows you to test services with or without Dependency Injection, ensuring flexibility and proper separation of concerns in your integration tests.
