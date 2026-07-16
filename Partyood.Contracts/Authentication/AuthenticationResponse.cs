using System;

namespace Partyood.Contracts.Authentication;

public class AuthenticationResponse(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token
);
