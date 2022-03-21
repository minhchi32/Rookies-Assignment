namespace eCommerce.Backend.Common
{
    public static class DataPagerExtension
    {
        public static async Task<PagedModelDTO<TModel>> PaginateAsync<TModel>(this IQueryable<TModel> query, PagedResultBase criteriaDTO) where TModel : class
        {

            var paged = new PagedModelDTO<TModel>();

            paged.PageIndex = (criteriaDTO.PageIndex < 0) ? 1 : criteriaDTO.PageIndex;
            paged.PageSize = criteriaDTO.PageSize;

            if (!string.IsNullOrEmpty(criteriaDTO.SortOrder.ToString()) &&
                !string.IsNullOrEmpty(criteriaDTO.SortColumn))
            {
                var sortOrder = criteriaDTO.SortOrder == SortOrder.Accsending ?
                                    PagingSortingConstants.ASC :
                                    PagingSortingConstants.DESC;
                var orderString = $"{criteriaDTO.SortColumn} {sortOrder}";
                query = query.OrderBy(orderString);
            }

            var startRow = (paged.PageIndex - 1) * paged.PageSize;

            paged.Items = await query
                        .Skip(startRow)
                        .Take(paged.PageSize)
                        .ToListAsync();

            paged.TotalRecord = await query.CountAsync();
            // paged.PageCount = (int)Math.Ceiling(paged.TotalRecord / (double)paged.PageSize);

            return paged;
        }
    }
}