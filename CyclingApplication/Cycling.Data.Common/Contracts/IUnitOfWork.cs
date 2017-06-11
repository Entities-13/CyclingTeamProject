using System;

namespace Cycling.Data.Common.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
