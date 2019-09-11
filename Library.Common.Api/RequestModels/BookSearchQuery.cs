using System;

namespace Library.Common.Api.RequestModels
{
    public class BookSearchQuery : BaseSearchQuery
    {
        public string Title { get; set; }
		public string Description { get; set; }
    }
}
