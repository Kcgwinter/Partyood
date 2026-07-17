using System;
using Microsoft.Extensions.DependencyInjection;
using Partyood.Application.Services.Authentication;

namespace Partyood.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}
