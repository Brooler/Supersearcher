using Supersearcher.Domain.Models;
using Supersearcher.Domain.Models.ResultItems;
using System.Threading;
using System.Threading.Tasks;

namespace Supersearcher.Domain.Interfaces
{
    public interface ISearch<TResult, TItem> where TItem : SearchResultItemBase
                                             where TResult : SearchResultBase<TItem>
    {
        Task<TResult> Search(string query, long? maxResultsCount = default, CancellationToken cancellationToken = default);
    }
}
