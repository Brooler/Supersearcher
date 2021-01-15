using Supersearcher.Domain.Models;
using Supersearcher.Domain.Models.ResultItems;

namespace Supersearcher.Domain.Interfaces
{
    public interface IWebSearch : ISearch<WebSearchResult, WebSearchResultItem>
    {
    }
}
