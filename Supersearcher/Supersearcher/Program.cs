using Supersearcher.Domain.Models;
using Supersearcher.Domain.Models.ResultItems;
using Supersearcher.Factories;
using Supersearcher.Providers.FileSystemSearch;
using Supersearcher.Providers.GoogleSearch;
using System;
using System.Threading.Tasks;

namespace Supersearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var query = Console.ReadLine();
            Console.WriteLine(query);

            var webSearch = SearchFactory.Create(new SearchCreateOptions<GoogleSearchProvider, WebSearchResult, WebSearchResultItem>(true));
            var filesSearch = SearchFactory.Create(new SearchCreateOptions<FileSystemSearchProvider, FileSearchResult, FileSearchResultItem>());
            var directorySearch = SearchFactory.Create(new SearchCreateOptions<FileSystemSearchProvider, DirectorySearchResult, DirectorySearchResultItem>());

            Task.Run(() => webSearch.Search(query)).ContinueWith(result =>
            {
                //handle results
            });

            Task.Run(() => filesSearch.Search(query)).ContinueWith(result =>
            {
                //handle results
            });

            Task.Run(() => directorySearch.Search(query)).ContinueWith(result =>
            {
                //handle results
            });

            Console.ReadKey();
        }
    }
}
