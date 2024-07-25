﻿
using SIGA.Application.DTO;
using SIGA.Application.DTO.Account;
using SIGA.Application.Handles.Interfaces;

namespace SIGA.API.Endpoints.Accounts;

public class RegisterAccountEndpoint : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app)
        => app.MapPost("/Register", HandleAsync)
                .WithName("Accounts: Register")
                .WithSummary("Registra uma nova conta")
                .WithDescription("Cria uma nova conta de usuário")
                .WithOrder(1)
                .Produces<Response<RegisterResponse?>>();

    private static async Task<IResult> HandleAsync(
        IAccountHandler handler,
        RegisterRequest request)
    {
        var result = await handler.RegisterAsync(request);

        return result.IsSuccess
            ? TypedResults.Created($"/{result.Data?.Id}", result)
            : TypedResults.Problem();
    }
}