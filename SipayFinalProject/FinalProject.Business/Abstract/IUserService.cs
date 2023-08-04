using FinalProject.Core.Utilities.Results;
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
		IDataResult<User> GetById(int userId);
		IDataResult<List<User>> GetList();
		IDataResult<List<User>> GetUserListByFlat(int flatId);
		IResult Add(User user);
		IResult Update(User user);
		IResult Delete(User user);

	}
}
