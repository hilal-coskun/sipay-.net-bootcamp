using FinalProject.Core.Entities.Concrete;
using FinalProject.Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business.Abstract
{
	public interface IUserOperationClaimsService
	{
		IDataResult<UserOperationClaim> GetById(int userOperationClaimId);
		IDataResult<List<UserOperationClaim>> GetList();
		IResult Add(UserOperationClaim userOperationClaim);
		IResult Delete(UserOperationClaim userOperationClaim);
	}
}
