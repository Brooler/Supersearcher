using Supersearcher.Domain.Models.ResultItems;
using System.Collections.Generic;

namespace Supersearcher.Domain.Models
{
    public class SearchResultBase<T> where T : SearchResultItemBase
    {
        public long TotalResultsCount { get; set; }

        public string Query { get; set; }

        public ICollection<T> Results { get; set; }
    }
}
