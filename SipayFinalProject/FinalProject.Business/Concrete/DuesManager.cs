﻿using FinalProject.Business.Abstract;
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
	public class DuesManager : IDuesService
	{
		private readonly EfDuesDal _efDuesDal;

		public DuesManager(EfDuesDal efDuesDal)
		{
			_efDuesDal = efDuesDal;
		}

		public IResult Add(Dues dues)
		{
			_efDuesDal.Add(dues);
			return new SuccessResult(Messages.DuesAdded);
		}

		public IResult Delete(Dues dues)
		{
			_efDuesDal.Delete(dues);
			return new SuccessResult(Messages.DuesDeleted);
		}

		public IDataResult<Dues> GetById(int duesId)
		{
			var dues = _efDuesDal.Get(p => p.Id == duesId);
			return new SuccessDataResult<Dues>(dues);
		}

		public IDataResult<List<Dues>> GetList()
		{
			var dueses = _efDuesDal.GetList().ToList();
			return new SuccessDataResult<List<Dues>>(dueses);
		}

		public IDataResult<List<Dues>> GetListByFlat(int flatId)
		{
			var flats = _efDuesDal.GetList(p => p.FlatId == flatId).ToList();
			return new SuccessDataResult<List<Dues>>(flats);
		}

		public IResult Update(Dues dues)
		{
			_efDuesDal.Update(dues);
			return new SuccessResult(Messages.DuesUpdated);
		}
	}
}
