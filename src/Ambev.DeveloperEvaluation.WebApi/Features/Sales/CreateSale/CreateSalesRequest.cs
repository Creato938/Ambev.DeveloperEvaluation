using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSales;

/// <summary>
/// Represents a request to create a new user in the system.
/// </summary>
public class CreateSalesRequest
{
    /// <summary>
    /// Gets or sets the ClientName. Must be only valid characters.
    /// </summary>
    public string ClientName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the ItemList. Must meet security requirements.
    /// </summary>
    public string[] ItemList { get; set; } = { };

    /// <summary>
    /// Gets or sets the phone number in format (XX) XXXXX-XXXX.
    /// </summary>
    public string Phone { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the email address. Must be a valid email format.
    /// </summary>
    public string Email { get; set; } = string.Empty;
}