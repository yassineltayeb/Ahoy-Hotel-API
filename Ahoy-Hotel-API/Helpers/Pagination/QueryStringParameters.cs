namespace Ahoy_Hotel_API.Helpers.Pagination;

/* -------------------------------------------------------------------------- */
/*                           Query String Parameters                          */
/* -------------------------------------------------------------------------- */

public abstract class QueryStringParameters : QueryStringSortParameters
{
    const int maxPageSize = 100;
    public int PageNumber { get; set; } = 1;
    private int _pageSize = 10;
    public int PageSize
    {
        get
        {
            return _pageSize;
        }
        set
        {
            _pageSize = value > maxPageSize ? maxPageSize : value;
        }
    }
}

/* -------------------------------------------------------------------------- */
/*                        Query String Sort Parameters                        */
/* -------------------------------------------------------------------------- */

public abstract class QueryStringSortParameters
{
    public string SortBy { get; set; }
    public bool IsSortAscending { get; set; }
}
