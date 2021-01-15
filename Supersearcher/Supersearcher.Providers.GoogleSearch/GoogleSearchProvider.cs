using Supersearcher.Domain.Interfaces;
using Supersearcher.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Supersearcher.Providers.GoogleSearch
{
    public class GoogleSearchProvider : IWebSearch
    {
        public Task<WebSearchResult> Search(string query, long? maxResultsCount = null, CancellationToken cancellationToken = default)
        {
            //TODO: Implement Google Search
            throw new System.NotImplementedException();
        }
    }
}
