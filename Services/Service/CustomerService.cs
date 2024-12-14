

using Core.Models.EntityModels;
using Core.Models.ResultModels;
using Core.Models.SettingModels;
using Core.Services;
using System.Dynamic;


namespace Application.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly IContractService _contractService;
        private readonly AppSettings _appSettings;
        public CustomerService(AppSettings appSettings, IContractService contractService) {
            _appSettings = appSettings;
            _contractService = contractService;
        }

        public Task<ResponseModel> GetAll()
        {
            var rs = new ResponseModel()
            {
                Data = new ExpandoObject() 
            };
            rs.Data = _appSettings;
            return Task.FromResult(rs);
        }

        public async  Task<ResponseModel> GetById(int Id)
        {
            return new ResponseModel()
            {
                Data = Id
            };
        }

        public async Task<ResponseModel> Insert(ContractEntity entry)
        {
            try
            {
                await _contractService.Insert( new ContractEntity());

                return new ResponseModel() { Code = 200 };
            }
            catch (Exception ex)
            {
                return new ResponseModel() { Code = 500};
            }
        }

        public Task<ResponseModel> UpdateById(int Id, ContractEntity entry)
        {
            throw new NotImplementedException();
        }

    }
}
