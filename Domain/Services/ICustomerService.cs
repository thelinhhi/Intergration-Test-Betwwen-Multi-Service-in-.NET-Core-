using Core.Models.EntityModels;
using Core.Models.ResultModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface ICustomerService
    {
        Task<ResponseModel> GetAll();
        Task<ResponseModel> GetById(int Id);
        Task<ResponseModel> Insert(ContractEntity entry);
        Task<ResponseModel> UpdateById(int Id, ContractEntity entry);


    }
}
