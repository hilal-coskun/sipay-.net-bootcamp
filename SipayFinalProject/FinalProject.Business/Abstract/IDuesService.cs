using FinalProject.Core.Utilities.Results;
using FinalProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business.Abstract
{
	public interface IDuesService
	{
		IDataResult<Dues> GetById(int duesId);
		IDataResult<List<Dues>> GetList();
		IDataResult<List<Dues>> GetListByFlat(int flatId);
		IResult Add(Dues dues);
		IResult Update(Dues dues);
		IResult Delete(Dues dues);
	}
}
