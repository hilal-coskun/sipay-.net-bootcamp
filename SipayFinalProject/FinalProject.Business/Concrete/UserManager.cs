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
	public class UserManager : IUserService
	{
		private readonly EfUserDal _efUserDal;

		public UserManager(EfUserDal efUserDal)
		{
			_efUserDal = efUserDal;
		}

		public void Add(User user)
		{
			//Business Code
			_efUserDal.Add(user);
		}

		public void Delete(User user)
		{
			_efUserDal.Delete(user);
		}

		public User GetById(int userId)
		{
			var user = _efUserDal.Get(p => p.Id == userId);
			return user;
		}

		public List<User> GetList()
		{
			var users = _efUserDal.GetList().ToList();
			return users;	
		}

		public List<User> GetUserListByFlat(int flatId)
		{
			var flats = _efUserDal.GetList(p => p.FlatId == flatId).ToList();
			return flats;
		}

		public void Update(User user)
		{
			_efUserDal.Update(user);
		}
	}
}
