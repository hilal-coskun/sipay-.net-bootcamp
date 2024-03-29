﻿using FinalProject.Core.Entities.Concrete;
using FinalProject.Core.Extensions;
using FinalProject.Core.Utilities.Security.Encryption;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Core.Utilities.Security.Jwt
{
	public class JwtHelper : ITokenHelper
	{
		public IConfiguration Configuration { get; }
		private TokenOptions _tokenOptions;
		private DateTime _accessTokenExpiration;

		public JwtHelper(IConfiguration configuration)
		{
			Configuration = configuration;
			_tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();
			_accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
		}

		public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)
		{
			var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenOptions.SecurityKey));
			var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);
			var jwt = CreateJwtSecuriityToken(_tokenOptions, user, signingCredentials, operationClaims);
			var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
			
			var token = jwtSecurityTokenHandler.WriteToken(jwt);
			return new AccessToken
			{
				Token = token,
				Expiration = _accessTokenExpiration,
			};
		}

		public JwtSecurityToken CreateJwtSecuriityToken(TokenOptions tokenOptions, User user, SigningCredentials signingCredentials,List<OperationClaim> operationClaims)
		{
			var jwt = new JwtSecurityToken(
				issuer : tokenOptions.Issuer,
				audience : tokenOptions.Audience,
				expires : _accessTokenExpiration ,
				notBefore : DateTime.Now,
				claims : SetClaims(user, operationClaims),
				signingCredentials : signingCredentials
			);

			return jwt;
		}

		private IEnumerable<Claim> SetClaims(User user, List<OperationClaim> operationClaims)
		{
			var claims = new List<Claim>();
			claims.Add(new Claim("email",user.Email));
			claims.AddEmail(user.Email);
			claims.AddRoles(operationClaims.Select(x => x.Name).ToArray());

			return claims;
		}
	}
}
