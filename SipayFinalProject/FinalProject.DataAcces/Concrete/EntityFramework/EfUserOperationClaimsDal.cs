using FinalProject.Core.DataAccess.EntityFramework;
using FinalProject.Core.Entities.Concrete;
using FinalProject.DataAcces.Abstract;
using FinalProject.DataAccess.Abstract;
using FinalProject.DataAccess.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataAcces.Concrete.EntityFramework
{
	public class EfUserOperationClaimsDal : EfEntityRepositoryBase<UserOperationClaim, DataContexts>, IUserOperationClaimDal
	{
	}
}
