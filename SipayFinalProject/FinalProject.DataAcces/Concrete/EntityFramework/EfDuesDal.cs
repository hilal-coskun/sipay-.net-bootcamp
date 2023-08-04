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
	public class EfDuesDal : /*EfEntityRepositoryBase<Dues, DataContexts>,*/ IDuesDal
	{
		public void Add(Dues entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(Dues entity)
		{
			throw new NotImplementedException();
		}

		public Dues Get(Expression<Func<Dues, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public IList<Dues> GetList(Expression<Func<Dues, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public void Update(Dues entity)
		{
			throw new NotImplementedException();
		}
	}
}
