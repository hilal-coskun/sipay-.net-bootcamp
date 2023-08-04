using FinalProject.Business.Abstract;
using FinalProject.Business.Contants;
using FinalProject.Core.Utilities.Results;
using FinalProject.DataAcces.Concrete.EntityFramework;
using FinalProject.DataAccess.Abstract;
using FinalProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business.Concrete
{
	public class UserManager : IUserService
	{
		private readonly IUserDal _UserDal;

		public UserManager(IUserDal efUserDal)
		{
			_UserDal = efUserDal;
		}

		public IResult Add(User user)
		{
			//Business Code
			_UserDal.Add(user);
			return new SuccessResult(Messages.UserAdded);
		}

		public IResult Delete(User user)
		{
			_UserDal.Delete(user);
			return new SuccessResult(Messages.UserDeleted);
		}

		public IDataResult<User> GetById(int userId)
		{
			var user = _UserDal.Get(p => p.Id == userId);
			return new SuccessDataResult<User>(user);
		}

		public IDataResult<List<User>> GetList()
		{
			var users = _UserDal.GetList().ToList();
			return new SuccessDataResult<List<User>>(users);	
		}

		public IDataResult<List<User>> GetUserListByFlat(int flatId)
		{
			var flats = _UserDal.GetList(p => p.FlatId == flatId).ToList();
			return new SuccessDataResult<List<User>>(flats);
		}

		public IResult Update(User user)
		{
			_UserDal.Update(user);
			return new SuccessResult(Messages.UserUpdated);
		}
	}
}
