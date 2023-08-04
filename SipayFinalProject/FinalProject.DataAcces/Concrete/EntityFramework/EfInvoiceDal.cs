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
	public class EfInvoiceDal : /*EfEntityRepositoryBase<Invoice, DataContexts>,*/ IInvoiceDal
	{
		public void Add(Invoice entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(Invoice entity)
		{
			throw new NotImplementedException();
		}

		public Invoice Get(Expression<Func<Invoice, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public IList<Invoice> GetList(Expression<Func<Invoice, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public void Update(Invoice entity)
		{
			throw new NotImplementedException();
		}
	}
}
