using FinalProject.Core.Utilities.Results;
using FinalProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business.Abstract
{
	public interface IFlatService
	{
		IDataResult<Flat> GetById(int flatId);
		IDataResult<List<Flat>> GetList();
		IDataResult<List<Flat>> GetListByUser(int userId);
		IResult Add(Flat flat);
		IResult Update(Flat flat);
		IResult Delete(Flat flat);
	}
}
