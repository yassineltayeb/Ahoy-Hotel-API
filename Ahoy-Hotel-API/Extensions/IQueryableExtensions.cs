using Ahoy_Hotel_API.Contracts.Hotel;
using Ahoy_Hotel_API.Helpers.Pagination;
using Ahoy_Hotel_API.Models;
using System.Linq.Expressions;

namespace Ahoy_Hotel_API.Extensions;

/* -------------------------------------------------------------------------- */
/*                            IQueryable Extensions                           */
/* -------------------------------------------------------------------------- */

public static class IQueryableExtensions
{
    /* -------------------------------------------------------------------------- */
    /*                                  Functions                                 */
    /* -------------------------------------------------------------------------- */

    /* ----------------------------- Apply Filtering ---------------------------- */
    public static IQueryable<Hotel> ApplyFiltering(this IQueryable<Hotel> query, HotelFilterDto hotelFilterDto)
    {
        if (hotelFilterDto.Name != null)
            query = query.Where(t => t.Name.Contains(hotelFilterDto.Name));

        if (hotelFilterDto.Address != null)
            query = query.Where(t => t.Address.Contains(hotelFilterDto.Address));

        if (hotelFilterDto.Location != null)
            query = query.Where(t => t.Location.Contains(hotelFilterDto.Location));

        if (hotelFilterDto.Facilities != null)
        {
            var facilities = CovertStringToArray(hotelFilterDto.Facilities);
            query = query.Where(t => t.Facilities.Any(f => facilities.Contains(f.Facility.Name)));
        }

        return query;
    }

    /* ----------------------------- Apply Ordering ----------------------------- */
    public static IQueryable<T> ApplyOrdering<T>(this IQueryable<T> query, QueryStringParameters queryObj, Dictionary<string, Expression<Func<T, object>>> columnsMap)
    {
        if (String.IsNullOrWhiteSpace(queryObj.SortBy) || !columnsMap.ContainsKey(queryObj.SortBy))
            return query;

        if (queryObj.IsSortAscending)
            return query.OrderBy(columnsMap[queryObj.SortBy]);
        else
            return query.OrderByDescending(columnsMap[queryObj.SortBy]);
    }

    /* ------------------------- Covert String To Array ------------------------- */
    public static string[] CovertStringToArray(string fieldName)
    {
        return fieldName.Replace("[", "").Replace("]", "").Split(",");
    }
}
