using Ambev.DeveloperEvaluation.Application.Sales.CreateSales;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Enums;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSales;

/// <summary>
/// Command for creating a new user.
/// </summary>
/// <remarks>
/// This command is used to capture the required data for creating a user, 
/// including username, password, phone number, email, status, and role. 
/// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
/// that returns a <see cref="CreateUserResult"/>.
/// 
/// The data provided in this command is validated using the 
/// <see cref="CreateUserCommandValidator"/> which extends 
/// <see cref="AbstractValidator{T}"/> to ensure that the fields are correctly 
/// populated and follow the required rules.
/// </remarks>
public class AddSaleCommand : IRequest<CreateSalesResult>
{  /// <summary>
   /// Gets or sets the ClientName. Must be only valid characters.
   /// </summary>
    public string ClientName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the ItemList
    /// </summary>
    public string[] ItemList { get; set; } = { };

    /// <summary>
    /// Gets or sets the Quantities of each prodduct
    /// </summary>
    public string[] Quantities { get; set; } = { };

    /// <summary>
    /// Gets or sets the Total Amount of each prodduct
    /// </summary>
    public float[] TotalAmountPerItem { get; set; } = { };

    /// <summary>
    /// Gets or sets the phone number in format (XX) XXXXX-XXXX.
    /// </summary>
    public string Phone { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the email address. Must be a valid email format.
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the branch where it was sold.
    /// </summary>
    public string Branch { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the Discounts.
    /// </summary>
    public float Discounts { get; set; } = 0;

    /// <summary>
    /// Gets or sets the Total sales value.
    /// </summary>
    public float TotalSalesValue { get; set; } = 0;

    /// <summary>
    /// Gets or sets if the sales in cancelled.
    /// </summary>
    public Boolean CancelledSale { get; set; } = false;

    public ValidationResultDetail Validate()
    {
        var validator = new CreateSalesCommandValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }
}