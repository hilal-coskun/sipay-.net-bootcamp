using FinalProject.Core.DataAccess.EntityFramework;
using FinalProject.Core.Entities.Concrete;
using FinalProject.DataAccess.Abstract;
using FinalProject.DataAccess.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataAcces.Concrete.EntityFramework
{
	public class EfUserDal : EfEntityRepositoryBase<User, DataContexts>, IUserDal
	{
		public List<OperationClaim> GetClaims(User user)
		{
			using(var context = new DataContexts())
			{
				var result = from operationClaim in context.OperationClaims
							 join userOperationClaim in context.UserOperationClaims
							 on operationClaim.Id equals userOperationClaim.OperationClaimId
							 where userOperationClaim.UserId == user.Id
							 select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
				return result.ToList();
			}
		}
	}
}
