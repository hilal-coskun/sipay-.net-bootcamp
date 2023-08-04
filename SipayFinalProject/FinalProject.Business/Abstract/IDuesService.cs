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
		Dues GetById(int duesId);
		List<Dues> GetList();
		List<Dues> GetListByFlat(int flatId);
		void Add(Dues dues);
		void Update(Dues dues);
		void Delete(Dues dues);
	}
}
