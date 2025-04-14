using AutoMapper;
using MediatR;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Common.Security;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSales;

/// <summary>
/// Handler for processing CreateSalesCommand requests
/// </summary>
public class CreateSalesHandler : IRequestHandler<AddSaleCommand, CreateSalesResult>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
    private readonly IPasswordHasher _passwordHasher;

    /// <summary>
    /// Initializes a new instance of CreateSalesHandler
    /// </summary>
    /// <param name="userRepository">The user repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    /// <param name="validator">The validator for CreateSalesCommand</param>
    public CreateSalesHandler(IUserRepository userRepository, IMapper mapper, IPasswordHasher passwordHasher)
    {
        _userRepository = userRepository;
        _mapper = mapper;
        _passwordHasher = passwordHasher;
    }

    /// <summary>
    /// Handles the CreateSalesCommand request
    /// </summary>
    /// <param name="command">The CreateSales command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created sales details</returns>
    public async Task<CreateSalesResult> Handle(AddSaleCommand command, CancellationToken cancellationToken)
    {
        var validator = new CreateSalesCommandValidator();
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        var result = _mapper.Map<CreateSalesResult>(validationResult);
        return result;
    }
}
