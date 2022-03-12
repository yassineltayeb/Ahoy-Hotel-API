namespace Ahoy_Hotel_API.Helpers.Pagination;

/* -------------------------------------------------------------------------- */
/*                                 Paged List                                 */
/* -------------------------------------------------------------------------- */

public class PagedList<T> : List<T>
{
    /* -------------------------------------------------------------------------- */
    /*                                  Variables                                 */
    /* -------------------------------------------------------------------------- */

    public int CurrentPage { get; private set; }
    public int TotalPages { get; private set; }
    public int PageSize { get; private set; }
    public int TotalCount { get; private set; }
    public bool HasPrevious => CurrentPage > 1;
    public bool HasNext => CurrentPage < TotalPages;

    /* -------------------------------------------------------------------------- */
    /*                                 Constructor                                */
    /* -------------------------------------------------------------------------- */

    public PagedList(List<T> items, int count, int pageNumber, int pageSize)
    {
        TotalCount = count;
        PageSize = pageSize;
        CurrentPage = pageNumber;
        TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        AddRange(items);
    }

    /* -------------------------------------------------------------------------- */
    /*                                  Functions                                 */
    /* -------------------------------------------------------------------------- */

    /* --------------------------- To Paged List Async -------------------------- */
    public static PagedList<T> ToPagedList(IList<T> source, int pageNumber, int pageSize)
    {
        var count = source.Count();
        List<T> items;

        if (pageNumber == 0 || pageSize == 0)
            items = source.ToList();
        else
            items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

        return new PagedList<T>(items, count, pageNumber, pageSize);
    }
}
