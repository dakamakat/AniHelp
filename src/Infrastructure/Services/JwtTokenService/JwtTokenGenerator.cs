using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Infrastructure.Identity;
using Microsoft.IdentityModel.Tokens;

namespace Infrastructure.Services.JWTTokenService
{
    ///TODO: Refactor this class
    public static class JwtTokenGenerator
    {
        public static string GenerateJwtToken(ApplicationUser user)
        {
            var identity = GetIdentity(user);
            if (identity == null)
            {
                ///TODO: Refactor this exception
                throw new Exception("user not found");
            }

            var now = DateTime.UtcNow;

            // Jwt tocen creation
            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    notBefore: now,
                    claims: identity.Claims,
                    expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);



            return encodedJwt;
        }

        private static ClaimsIdentity GetIdentity(ApplicationUser user)
        {
            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, user.UserName),
                };
                ClaimsIdentity claimsIdentity =
                new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                    ClaimsIdentity.DefaultRoleClaimType);
                return claimsIdentity;
            }

            //TODO : throw an error instead of returning null
            return null;
        }
    }
}
