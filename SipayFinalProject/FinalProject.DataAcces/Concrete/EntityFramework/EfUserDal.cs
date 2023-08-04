using FinalProject.Core.DataAccess.EntityFramework;
using FinalProject.DataAccess.Abstract;
using FinalProject.DataAccess.Concrete.EntityFramework.Contexts;
using FinalProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataAcces.Concrete.EntityFramework
{
	public class EfUserDal : /*EfEntityRepositoryBase<User, DataContexts>,*/ IUserDal
	{
		public void Add(User entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(User entity)
		{
			throw new NotImplementedException();
		}

		public User Get(Expression<Func<User, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public IList<User> GetList(Expression<Func<User, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public void Update(User entity)
		{
			throw new NotImplementedException();
		}
	}
}
