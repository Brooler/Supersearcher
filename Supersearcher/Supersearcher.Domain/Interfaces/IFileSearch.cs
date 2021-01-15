using Supersearcher.Domain.Models;
using Supersearcher.Domain.Models.ResultItems;

namespace Supersearcher.Domain.Interfaces
{
    public interface IFileSearch : ISearch<FileSearchResult, FileSearchResultItem>
    {
    }
}
