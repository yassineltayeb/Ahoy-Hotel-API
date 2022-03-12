namespace Ahoy_Hotel_API.Models;

/* -------------------------------------------------------------------------- */
/*                               Request Details                              */
/* -------------------------------------------------------------------------- */

public class RequestDetails
{
    public object Data { get; set; }
    public bool Status { get; set; }
    public int StatusCode { get; set; }
    public string Message { get; set; }
}
