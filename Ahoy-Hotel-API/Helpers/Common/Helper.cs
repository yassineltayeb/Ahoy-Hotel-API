namespace Ahoy_Hotel_API.Helpers.Common;

/* -------------------------------------------------------------------------- */
/*                                   Helper                                   */
/* -------------------------------------------------------------------------- */

public class Helper
{
    /* -------------------------------- Messages -------------------------------- */
    public class Messages
    {
        public static readonly string Success = "Success";
        public static readonly string Update = "Updated Successfully";
        public static readonly string Delete = "Deleted Successfully";
        public static readonly string Error = "Error";
        public static readonly string Required = "This field is required";
        public static readonly string InvalidEmail = "Please enter a valid email";
        public static readonly string PasswordsMismatch = "Password Mismatch";
        public static readonly string InvalidPaymentType = "Invalid Payment Type";
        public static readonly string InvalidIdentificationType = "Invalid Identification Type";
    }

    /* ------------------------------ Payment Types ----------------------------- */
    public class PaymentTypes
    {
        public static readonly string Card = "Card";
        public static readonly string Cash = "Cash";
    }

    /* -------------------------- Identification Types -------------------------- */
    public class IdentificationTypes
    {
        public static readonly string IDCard = "ID Card";
        public static readonly string Passport = "Passport";
    }
}
