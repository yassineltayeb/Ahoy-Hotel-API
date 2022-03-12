namespace Ahoy_Hotel_API.Models;

/* -------------------------------------------------------------------------- */
/*                                 Base Entity                                */
/* -------------------------------------------------------------------------- */

public abstract class BaseEntity
{

    /* -------------------------------------------------------------------------- */
    /*                                 Constructor                                */
    /* -------------------------------------------------------------------------- */

    public BaseEntity()
    {
        CreatedOn = DateTime.Now;
        UpdatedOn = DateTime.Now;
        IsDeleted = false;
    }

    public int Id { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime UpdatedOn { get; set; }
}
