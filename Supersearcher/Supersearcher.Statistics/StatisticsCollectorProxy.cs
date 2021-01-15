using Supersearcher.Domain.Interfaces;
using Supersearcher.Domain.Models;
using Supersearcher.Domain.Models.ResultItems;
using System.Threading;
using System.Threading.Tasks;

namespace Supersearcher.Statistics
{
    public class StatisticsCollectorProxy<TImplementation, TResult, TItem> : ISearch<TResult, TItem>
        where TItem : SearchResultItemBase
        where TResult : SearchResultBase<TItem>
        where TImplementation : ISearch<TResult, TItem>, new()
        
    {
        public async Task<TResult> Search(string query, long? maxResultsCount = null, CancellationToken cancellationToken = default)
        {
            var provider = new TImplementation();

            var result = await provider.Search(query, maxResultsCount, cancellationToken);

            //TODO: Collect statistics

            return result;
        }
    }
}
