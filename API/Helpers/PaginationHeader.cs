namespace API.Helpers
{
    public class PaginationHeader
    {
        public PaginationHeader(int currentPage, int itemsPerPages, int totalItems, int totalPages)
        {
            this.CurrentPage = currentPage;
            this.ItemsPerPages = itemsPerPages;
            this.TotalItems = totalItems;
            this.TotalPages = totalPages;
        }

        public int CurrentPage { get; set; }
        public int ItemsPerPages { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
    }
}