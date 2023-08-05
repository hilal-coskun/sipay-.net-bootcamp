using FinalProject.Core.Utilities.Security.Jwt;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Core.Utilities.Security.Encryption
{
	public class SecurityKeyHelper
	{
		public static SecurityKey CreateSecurityKey(string securityKey)
		{
			return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
		}
	}
}
