using System;

namespace O.AlMamoon.Mobile.APP.API.Exceptions;

/* -------------------------------------------------------------------------- */
/*                        Unauthorized Action Exception                       */
/* -------------------------------------------------------------------------- */

public class UnauthorizedActionException : UnauthorizedAccessException
{
    /* -------------------------------------------------------------------------- */
    /*                                  Functions                                 */
    /* -------------------------------------------------------------------------- */

    /* ---------------------- Unauthorized Action Exception --------------------- */
    public UnauthorizedActionException(string message) : base(message)
    { }
}
