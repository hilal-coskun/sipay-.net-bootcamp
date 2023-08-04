using FinalProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business.Abstract
{
	public interface IUserService
	{
		User GetById(int userId);
		List<User> GetList();
		List<User> GetUserListByFlat(int flatId);
		void Add(User user);
		void Update(User user);
		void Delete(User user);

	}
}
