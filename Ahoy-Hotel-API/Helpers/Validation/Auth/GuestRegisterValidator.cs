using Ahoy_Hotel_API.Contracts.Guest;
using Ahoy_Hotel_API.Helpers.Common;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Ahoy_Hotel_API.Helpers.Validation.Auth;

/* -------------------------------------------------------------------------- */
/*                               Guest Validator                              */
/* -------------------------------------------------------------------------- */

public class GuestRegisterValidator : AbstractValidator<GuestRegisterDto>
{
    /* -------------------------------------------------------------------------- */
    /*                                 Constructor                                */
    /* -------------------------------------------------------------------------- */

    public GuestRegisterValidator(IStringLocalizer<GuestRegisterDto> localizer)
    {
        RuleFor(p => p.FullName)
            .NotEmpty()
            .WithMessage(p => localizer[Helper.Messages.Required]);

        RuleFor(p => p.Email)
            .NotEmpty()
            .WithMessage(p => localizer[Helper.Messages.Required]);


        RuleFor(p => p.Password)
            .NotEmpty()
            .WithMessage(p => localizer[Helper.Messages.Required]);

        RuleFor(p => p.ConfirmPassword)
            .NotEmpty()
            .WithMessage(p => localizer[Helper.Messages.Required]);

        RuleFor(p => p.Password)
            .Equal(p => p.ConfirmPassword)
            .WithMessage(p => localizer[Helper.Messages.PasswordsMismatch]);
    }
}