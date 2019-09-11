using System;

namespace Library.Common.Api.RequestModels
{
    public class AuthorSearchQuery : BaseSearchQuery
    {
        public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Genre { get; set; }
		public DateTime? DateOfbirthFrom { get; set; }
		public DateTime? DateOfbirthTo { get; set; }
    }
}
