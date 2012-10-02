using System;
using System.Linq;

namespace NWhatApi.Model
{
    class SearchQuery
    {
        public int Page { get; set; }
        public string SearchString { get; set; }

        public SearchQuery(string searchString)
        {
            this.Page = 1;
            this.SearchString = searchString;
        }
    }
}
