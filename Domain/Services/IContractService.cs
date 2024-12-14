

using Core.Models.EntityModels;
using Core.Models.ResultModels;

namespace Core.Services
{
    public interface IContractService
    {
        Task<ResponseModel> GetAll();
        Task<ResponseModel> GetById(int Id);
        Task<ResponseModel> Insert(ContractEntity entry);
        Task<ResponseModel> UpdateById(int Id, ContractEntity entry);


    }
}
