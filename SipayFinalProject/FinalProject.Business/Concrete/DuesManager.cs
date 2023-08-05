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
	public class DuesManager : IDuesService
	{
		private readonly IDuesDal _duesDal;

		public DuesManager(IDuesDal duesDal)
		{
			_duesDal = duesDal;
		}

		public IResult Add(Dues dues)
		{
			_duesDal.Add(dues);
			return new SuccessResult(Messages.DuesAdded);
		}

		public IResult Delete(Dues dues)
		{
			_duesDal.Delete(dues);
			return new SuccessResult(Messages.DuesDeleted);
		}

		public IDataResult<Dues> GetById(int duesId)
		{
			var dues = _duesDal.Get(p => p.Id == duesId);
			return new SuccessDataResult<Dues>(dues);
		}

		public IDataResult<List<Dues>> GetList()
		{
			var dueses = _duesDal.GetList().ToList();
			return new SuccessDataResult<List<Dues>>(dueses);
		}

		public IDataResult<List<Dues>> GetListByFlat(int flatId)
		{
			var flats = _duesDal.GetList(p => p.FlatId == flatId).ToList();
			return new SuccessDataResult<List<Dues>>(flats);
		}

		public IResult Update(Dues dues)
		{
			_duesDal.Update(dues);
			return new SuccessResult(Messages.DuesUpdated);
		}
	}
}
