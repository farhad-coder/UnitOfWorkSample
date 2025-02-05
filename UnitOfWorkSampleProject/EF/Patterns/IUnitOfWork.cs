using UnitOfWorkSampleProject.EF.Models;
using UnitOfWorkSampleProject.EF.Repositories;

namespace UnitOfWorkSampleProject.EF.Patterns
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Product> Products { get; }
        Task<int> CompleteAsync();
    }
}
