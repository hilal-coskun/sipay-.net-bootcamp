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
	public class FlatManager : IFlatService
	{
		private readonly EfFlatDal _efFlatDal;

		public FlatManager(EfFlatDal efFlatDal)
		{
			_efFlatDal = efFlatDal;
		}

		public void Add(Flat flat)
		{
			_efFlatDal.Add(flat);
		}

		public void Delete(Flat flat)
		{
			_efFlatDal.Delete(flat);
		}

		public Flat GetById(int flatId)
		{
			var flat = _efFlatDal.Get(p => p.Id == flatId);
			return flat;
		}

		public List<Flat> GetList()
		{
			var flats = _efFlatDal.GetList().ToList();
			return flats;
		}

		public List<Flat> GetListByUser(int userId)
		{
			var flats = _efFlatDal.GetList(p => p.UserId == userId).ToList();
			return flats;
		}

		public void Update(Flat flat)
		{
			_efFlatDal.Update(flat);
		}
	}
}
