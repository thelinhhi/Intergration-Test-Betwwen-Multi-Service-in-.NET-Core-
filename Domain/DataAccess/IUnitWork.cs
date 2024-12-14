using Core.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IUnitWork 
    {
        void BeginTransaction();
        void Commit();
        void OpenConnection();
        void Rollback();
        void Dispose();
        T GetDbTransaction<T>();
        T GetDbConnection<T>();
        Lazy<IContractRepository> ContractRepository { get; }

    }
}
