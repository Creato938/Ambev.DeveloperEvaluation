using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Sales.CreateSales.Users.CreateUser;

/// <summary>
/// API response model for CreateUser operation
/// </summary>
public class CreateSalesResponse
{
    /// <summary>
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
}
