using System;
using Microsoft.Extensions.DependencyInjection;
using Partyood.Application.Services.Authentication;

namespace Partyood.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}
