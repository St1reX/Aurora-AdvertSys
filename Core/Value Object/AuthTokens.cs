﻿namespace Core.ValueObjects
{
    public class AuthTokens
    {
        public string Token { get; set; } = default!;
        public string RefreshToken { get; set; } = default!;
    }
}
