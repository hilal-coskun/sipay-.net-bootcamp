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
	public class EfFlatDal : IFlatDal
	{
		public void Add(Flat entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(Flat entity)
		{
			throw new NotImplementedException();
		}

		public Flat Get(Expression<Func<Flat, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public IList<Flat> GetList(Expression<Func<Flat, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public void Update(Flat entity)
		{
			throw new NotImplementedException();
		}
	}
}
