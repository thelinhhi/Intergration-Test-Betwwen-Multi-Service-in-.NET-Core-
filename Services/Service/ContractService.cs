

using Core.Models.EntityModels;
using Core.Models.ResultModels;
using Core.Models.SettingModels;
using Core.Services;
using System.Dynamic;


namespace Application.Service
{
    public class ContractService : IContractService
    {
        public AppSettings  _appSettings { get; set; }
        public ContractService (AppSettings appSettings) {
            _appSettings = appSettings;
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
            if (!Validate())
            {
                return new ResponseModel()
                {
                    Code = 200,
                    Data = 1
                };
            }

            return new ResponseModel()
            {
                Code = 200,
                Data = 1
            };
        }

        public Task<ResponseModel> UpdateById(int Id, ContractEntity entry)
        {
            throw new NotImplementedException();
        }

        public virtual bool Validate()
        {
            return false;
                
        }
    }
}
