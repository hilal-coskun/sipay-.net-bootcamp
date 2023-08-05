﻿using FinalProject.Core.Entities.Concrete;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Core.Utilities.Security.Jwt
{
	public interface ITokenHelper
	{
		AccessToken CreateToken(User user, List<OperationClaim> operationClaims);

	}
}
