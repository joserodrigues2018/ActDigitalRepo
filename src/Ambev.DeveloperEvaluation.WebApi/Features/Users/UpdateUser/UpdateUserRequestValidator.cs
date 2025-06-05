using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.UpdateUser;

/// <summary>
/// Validator for UpdateUserRequest that defines validation rules for user creation.
/// </summary>
public class UpdateUserRequestValidator : AbstractValidator<UpdateUserIdRequest>
{
    /// <summary>
    /// Initializes a new instance of the UpdateUserRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Email: Must be valid format (using EmailValidator)
    /// - Username: Required, length between 3 and 50 characters
    /// - Password: Must meet security requirements (using PasswordValidator)
    /// - Phone: Must match international format (+X XXXXXXXXXX)
    /// - Status: Cannot be Unknown
    /// - Role: Cannot be None
    /// </remarks>
    public UpdateUserRequestValidator()
    {
        RuleFor(x => x.Id).NotEmpty().WithMessage("User ID is required");
        RuleFor(user => user.Request!.Email).SetValidator(new EmailValidator());
        RuleFor(user => user.Request!.Username).NotEmpty().Length(3, 50);
        RuleFor(user => user.Request!.Password).SetValidator(new PasswordValidator());
        RuleFor(user => user.Request!.Phone).Matches(@"^\+?[1-9]\d{1,14}$");
        RuleFor(user => user.Request!.Status).NotEqual(UserStatus.Unknown);
        RuleFor(user => user.Request!.Role).NotEqual(UserRole.None);
    }
}