using Core.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Repositories
{
    public interface IContractRepository
    {
        Task<IEnumerable<ContractEntity>> GetAll();
        Task<ContractEntity> GetById(int Id);
        public int Insert(ContractEntity entry);
        public int UpdateById(int Id, ContractEntity entry);
    }
}
