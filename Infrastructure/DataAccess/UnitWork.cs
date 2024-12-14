
using Core.DataAccess;
using Core.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess
{
    public class UnitWork : IUnitWork
    {
        public IDbTransaction DbTransaction { get; private set; }
        public Lazy<IContractRepository> ContractRepository => throw new NotImplementedException();

        Lazy<IContractRepository> IUnitWork.ContractRepository => throw new NotImplementedException();

        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T GetDbConnection<T>()
        {
            throw new NotImplementedException();
        }

        public T GetDbTransaction<T>()
        {
            throw new NotImplementedException();
        }

        public void OpenConnection()
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }
    }
}
