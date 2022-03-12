using FluentValidation;
using Ahoy_Hotel_API.Contracts.Booking;
using Microsoft.Extensions.Localization;
using Ahoy_Hotel_API.Helpers.Common;

namespace Ahoy_Hotel_API.Helpers.Validation.Booking;

/* -------------------------------------------------------------------------- */
/*                          Booking Reserve Validator                         */
/* -------------------------------------------------------------------------- */

public class BookingReserveValidator : AbstractValidator<BookingReserveDto>
{
    /* -------------------------------------------------------------------------- */
    /*                                 Constructor                                */
    /* -------------------------------------------------------------------------- */

    public BookingReserveValidator(IStringLocalizer<BookingReserveDto> localizer)
    {
        RuleFor(p => p.CheckIn)
            .NotEmpty()
            .WithMessage(p => localizer[Helper.Messages.Required]);

        RuleFor(p => p.CheckOut)
            .NotEmpty()
            .WithMessage(p => localizer[Helper.Messages.Required]);

        RuleFor(p => p.PaymentType)
            .NotEmpty()
            .WithMessage(p => localizer[Helper.Messages.Required]);

        RuleFor(p => p.PaymentType)
            .NotEmpty()
            .When(p => p.PaymentType != Helper.PaymentTypes.Card)
            .WithMessage(p => localizer[Helper.Messages.InvalidPaymentType]);

        RuleFor(p => p.IdentificationType)
            .NotEmpty()
            .WithMessage(p => localizer[Helper.Messages.Required]);

        RuleFor(p => p.IdentificationType)
            .NotEmpty()
            .When(p => p.PaymentType != Helper.IdentificationTypes.IDCard && p.PaymentType != Helper.IdentificationTypes.Passport)
            .WithMessage(p => localizer[Helper.Messages.InvalidPaymentType]);


        RuleFor(p => p.IdentificationID)
            .NotEmpty()
            .WithMessage(p => localizer[Helper.Messages.Required]);

        RuleFor(p => p.RoomNo)
            .NotEmpty()
            .WithMessage(p => localizer[Helper.Messages.Required]);
    }
}
