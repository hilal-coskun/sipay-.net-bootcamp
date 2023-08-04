using FinalProject.Business.Abstract;
using FinalProject.Business.Contants;
using FinalProject.Core.Utilities.Results;
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

		public IResult Add(Flat flat)
		{
			_efFlatDal.Add(flat);
			return new SuccessResult(Messages.UserAdded);
		}

		public IResult Delete(Flat flat)
		{
			_efFlatDal.Delete(flat);
			return new SuccessResult(Messages.UserAdded);
		}

		public IDataResult<Flat> GetById(int flatId)
		{
			var flat = _efFlatDal.Get(p => p.Id == flatId);
			return new SuccessDataResult<Flat>(flat);
		}

		public IDataResult<List<Flat>> GetList()
		{
			var flats = _efFlatDal.GetList().ToList();
			return new SuccessDataResult<List<Flat>>(flats);
		}

		public IDataResult<List<Flat>> GetListByUser(int userId)
		{
			var flats = _efFlatDal.GetList(p => p.UserId == userId).ToList();
			return new SuccessDataResult<List<Flat>>(flats);
		}

		public IResult Update(Flat flat)
		{
			_efFlatDal.Update(flat);
			return new SuccessResult(Messages.UserAdded);
		}
	}
}
