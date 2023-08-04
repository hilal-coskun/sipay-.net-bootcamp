using FinalProject.Business.Abstract;
using FinalProject.DataAcces.Concrete.EntityFramework;
using FinalProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business.Concrete
{
	public class DuesManager : IDuesService
	{
		private readonly EfDuesDal _efDuesDal;

		public DuesManager(EfDuesDal efDuesDal)
		{
			_efDuesDal = efDuesDal;
		}

		public void Add(Dues dues)
		{
			_efDuesDal.Add(dues);
		}

		public void Delete(Dues dues)
		{
			_efDuesDal.Delete(dues);
		}

		public Dues GetById(int duesId)
		{
			var dues = _efDuesDal.Get(p => p.Id == duesId);
			return dues;
		}

		public List<Dues> GetList()
		{
			var dueses = _efDuesDal.GetList().ToList();
			return dueses;
		}

		public List<Dues> GetListByFlat(int flatId)
		{
			var flats = _efDuesDal.GetList(p => p.FlatId == flatId).ToList();
			return flats;
		}

		public void Update(Dues dues)
		{
			_efDuesDal.Update(dues);
		}
	}
}
