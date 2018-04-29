using System.Threading.Tasks;

namespace vega.core
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}