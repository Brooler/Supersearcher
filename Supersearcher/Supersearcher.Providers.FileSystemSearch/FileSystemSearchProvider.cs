using Supersearcher.Domain.Interfaces;
using Supersearcher.Domain.Models;
using Supersearcher.Domain.Models.ResultItems;
using System.Threading;
using System.Threading.Tasks;

namespace Supersearcher.Providers.FileSystemSearch
{
    public class FileSystemSearchProvider : IDirectorySearch, IFileSearch
    {
        Task<DirectorySearchResult> ISearch<DirectorySearchResult, DirectorySearchResultItem>.Search(string query, long? maxResultsCount, CancellationToken cancellationToken)
        {
            //TODO: Implement Directory Search
            throw new System.NotImplementedException();
        }

        Task<FileSearchResult> ISearch<FileSearchResult, FileSearchResultItem>.Search(string query, long? maxResultsCount, CancellationToken cancellationToken)
        {
            //TODO: Implement File Search
            throw new System.NotImplementedException();
        }
    }
}
