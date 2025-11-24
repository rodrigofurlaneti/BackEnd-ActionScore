namespace FSI.ActionScore.Application.Common
{
    public sealed class PagedResult<T>
    {
        public IEnumerable<T> Items { get; set; } = new List<T>();
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages => (int)Math.Ceiling((double)TotalItems / PageSize);

        public static PagedResult<T> Create(IEnumerable<T> items, int total, int page, int pageSize)
            => new()
            {
                Items = items,
                Page = page,
                PageSize = pageSize,
                TotalItems = total
            };
    }
}
