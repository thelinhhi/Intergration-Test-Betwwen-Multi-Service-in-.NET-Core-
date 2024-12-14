using Application.Service;
using Core.Models.EntityModels;
using Core.Models.SettingModels;
using Core.Services;
using Moq;
using System.Threading;

namespace NUnitProject
{
    public class Tests
    {
        private AppSettings _appSettings;
        private IContractService _DIContractService;
        private IContractService _newContractService;
        private Mock<AppSettings> _mockAppSettings;
        private Mock<IContractService> _mockContractService;
        private CustomerService _mockDICustomerService;
        [SetUp]
        public void Setup()
        {
            _appSettings = BaseIntegrationTestGlobal.GetService<AppSettings>();
            _DIContractService = BaseIntegrationTestGlobal.GetService<IContractService>();
            _newContractService = new ContractService(_appSettings);

            _mockAppSettings = new Mock<AppSettings>();
            _mockContractService = new Mock<IContractService>();
            _mockDICustomerService = new CustomerService(_mockAppSettings.Object, _mockContractService.Object);
        }

        [Test]
        public async Task GetById()
        {
            var rs1 = await _DIContractService.GetById(2);
            Console.WriteLine(rs1.ToString());

            Assert.Pass();
        }

        [Test]
        public async Task GetAll()
        {
            var rs1 = await _DIContractService.GetAll();
            Console.WriteLine(rs1.ToString());

            Assert.Pass();
        }

        //[Test]
        //public async Task MockTest_Insert()
        //{
        //    _mockContractService.Setup(mock => mock.Validate()).Returns(false);

        //    var rs1 = _mockContractService.Object.Validate();

        //    Assert.That(!rs1);
        //}

        [Test]
        public async Task MockTestDI_Insert()
        {
            _mockContractService.Setup(mock => mock.Insert(It.IsAny<ContractEntity>())).Throws(new Exception());
            var rs1 = await _mockDICustomerService.Insert( new Core.Models.EntityModels.ContractEntity());

            Assert.That(rs1.Code == 500);
        }
        //[Test]
        //public async Task GetAll()
        //{
        //    var rs1 = await _DIContractService.GetAll();
        //    Console.WriteLine(rs1.ToString());

        //    Assert.Pass();
        //}
    }
}