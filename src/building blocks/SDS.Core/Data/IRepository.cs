using SDS.Core.DomainObjects;

namespace SDS.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {

    }
}
