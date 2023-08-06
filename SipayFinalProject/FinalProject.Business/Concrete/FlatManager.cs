using FinalProject.Business.Abstract;
using FinalProject.Business.Contants;
using FinalProject.Core.Entities.Concrete;
using FinalProject.Core.Utilities.Results;
using FinalProject.DataAcces.Concrete.EntityFramework;
using FinalProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business.Concrete
{
	public class FlatManager : IFlatService
	{
		private readonly IFlatDal _flatDal;

		public FlatManager(IFlatDal flatDal)
		{
			_flatDal = flatDal;
		}

		public IResult Add(Flat flat)
		{
			_flatDal.Add(flat);
			return new SuccessResult(Messages.UserAdded);
		}

		public IResult Delete(Flat flat)
		{
			_flatDal.Delete(flat);
			return new SuccessResult(Messages.UserAdded);
		}

		public IDataResult<Flat> GetById(int flatId)
		{
			var flat = _flatDal.Get(p => p.Id == flatId);
			return new SuccessDataResult<Flat>(flat);
		}

		public IDataResult<List<Flat>> GetList()
		{
			var flats = _flatDal.GetList().ToList();
			return new SuccessDataResult<List<Flat>>(flats);
		}

		public IDataResult<List<Flat>> GetListByUser(int userId)
		{
			var flats = _flatDal.GetList(p => p.OwnerId == userId).ToList();
			return new SuccessDataResult<List<Flat>>(flats);
		}

		public IResult Update(Flat flat)
		{
			_flatDal.Update(flat);
			return new SuccessResult(Messages.UserAdded);
		}
	}
}
