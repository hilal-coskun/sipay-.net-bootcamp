using FinalProject.Business.Abstract;
using FinalProject.Business.Contants;
using FinalProject.Core.Entities.Concrete;
using FinalProject.Core.Utilities.Results;
using FinalProject.DataAcces.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business.Concrete
{
	public class UserOperationClaimsManager : IUserOperationClaimsService
	{
		private readonly IUserOperationClaimDal _userOperationClaimDal;

		public UserOperationClaimsManager(IUserOperationClaimDal userOperationClaimDal)
		{
			_userOperationClaimDal = userOperationClaimDal;
		}

		IResult IUserOperationClaimsService.Add(UserOperationClaim userOperationClaim)
		{
			_userOperationClaimDal.Add(userOperationClaim);
			return new SuccessResult(Messages.UserOperationClaimAdded);
		}

		IResult IUserOperationClaimsService.Delete(UserOperationClaim userOperationClaim)
		{
			_userOperationClaimDal.Delete(userOperationClaim);
			return new SuccessResult(Messages.UserOperationClaimDeleted);
		}

		IDataResult<UserOperationClaim> IUserOperationClaimsService.GetById(int userOperationClaimId)
		{
			var userOperationClaim = _userOperationClaimDal.Get(p => p.Id == userOperationClaimId);
			return new SuccessDataResult<UserOperationClaim>(userOperationClaim);
		}

		IDataResult<List<UserOperationClaim>> IUserOperationClaimsService.GetList()
		{
			var userOperationClaims = _userOperationClaimDal.GetList().ToList();
			return new SuccessDataResult<List<UserOperationClaim>>(userOperationClaims);
		}
	}
}
