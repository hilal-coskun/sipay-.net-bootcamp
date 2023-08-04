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
		Flat GetById(int flatId);
		List<Flat> GetList();
		List<Flat> GetListByUser(int userId);
		void Add(Flat flat);
		void Update(Flat flat);
		void Delete(Flat flat);
	}
}
