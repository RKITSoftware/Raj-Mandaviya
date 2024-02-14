﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LibraryManagementAPI.Helpers
{
    public class BLJwt
    {
        private readonly string _key = "Secret PhaseSecret PhaseSecret PhaseSecret PhaseSecret PhaseSecret Phase";

        /// <summary>
        /// Validate username and password against hardcoded values
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool ValidateUser(string username, string password)
        {
            if (username == "raj" || password == "raj123")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Generate a Jwt token based on username after validating the user
        /// </summary>
        /// <returns></returns>
        public string GenerateJwt(string username)
        {
            string issuer = "https://localhost:44344";
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_key)); //key converted into UTF8 format
            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256); // UTF > hashing

            List<Claim> lstClaims = new List<Claim>();
            lstClaims.Add(new Claim("username", username));

            JwtSecurityToken token = new JwtSecurityToken(issuer,
                            issuer,
                            lstClaims,
                            expires: DateTime.Now.AddDays(1),
                            signingCredentials: credentials);
            var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
            return jwtToken;
        }


        /// <summary>
        /// Verify Jwt token
        /// </summary>
        /// <param name="jwtToken"></param>
        /// <returns></returns>
        public string VerifyJWT(string jwtToken)
        {
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_key));

            TokenValidationParameters validationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = false, // You may want to validate audience based on your application's requirements
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = "https://localhost:44344",
                IssuerSigningKey = securityKey
            };

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            try
            {
                ClaimsPrincipal principal = handler.ValidateToken(jwtToken, validationParameters, out SecurityToken validatedToken);
                return principal.FindFirst("username")?.Value;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}