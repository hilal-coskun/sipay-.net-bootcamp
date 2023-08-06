using FinalProject.Core.DataAccess;
using FinalProject.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataAcces.Abstract
{
	public interface IUserOperationClaimDal : IEntityRepository<UserOperationClaim>
	{
	}
}
