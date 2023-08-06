using Azure.Core;
using FinalProject.Business.Abstract;
using FinalProject.Business.Contants;
using FinalProject.Core.Entities.Concrete;
using FinalProject.Core.Utilities.Results;
using FinalProject.Core.Utilities.Security.Hashing;
using FinalProject.Core.Utilities.Security.Jwt;
using FinalProject.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AccessToken = FinalProject.Core.Utilities.Security.Jwt.AccessToken;

namespace FinalProject.Business.Concrete
{
	public class AuthManager : IAuthService
	{

		private IUserService _userService;
		private ITokenHelper _tokenHelper;
		private IUserOperationClaimsService _userOperationClaimsService;

		public AuthManager(IUserService userService, ITokenHelper tokenHelper, IUserOperationClaimsService userOperationClaimsService)
		{
			_userService = userService;
			_tokenHelper = tokenHelper;
			_userOperationClaimsService = userOperationClaimsService;
		}

		public IResult AssignmentRole(int userId, int operationClaimId)
		{
			var existingUser = _userService.GetById(userId);
			if (existingUser == null)
			{
				return new ErrorResult(Messages.UserNotExist);
			}

			var existingRole = new List<UserOperationClaim>();

			var newClaim = new UserOperationClaim
			{
				UserId = userId,
				OperationClaimId = operationClaimId
			};

			existingRole.Add(newClaim);
			_userOperationClaimsService.Add(newClaim);
			return existingUser;

		}

		public IDataResult<AccessToken> CreateAccessToken(User user)
		{
			var claims = _userService.GetClaims(user);
			var accessToken = _tokenHelper.CreateToken(user, claims);
			return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
		}

		public IDataResult<User> Login(UserForLoginDto userForLoginDto)
		{
			var userToCheck = _userService.GetByMail(userForLoginDto.Email);
			if (userToCheck == null)
			{
				return new ErrorDataResult<User>(Messages.UserNotFound);
			}

			if(!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
			{
				return new ErrorDataResult<User>(Messages.PasswordError);
			}

			return new SuccessDataResult<User>(userToCheck, Messages.SuccessfulLogin);
		}

		public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
		{
			byte[] passwordHash, passwordSalt;
			HashingHelper.CreatePassswordHash(password,out passwordHash, out passwordSalt);
			var user = new User
			{
				Email = userForRegisterDto.Email,
				Name = userForRegisterDto.FirstName,
				Surname = userForRegisterDto.LastName,
				PasswordHash = passwordHash,
				PasswordSalt = passwordSalt,
				Status = true,
				CarInfo = userForRegisterDto.CarInfo,
				PhoneNumber = userForRegisterDto.PhoneNumber,
				TCNumber = userForRegisterDto.TCNumber,
			};

			_userService.Add(user);
			return new SuccessDataResult<User>(user, Messages.UserRegistered);
		}

		public IResult UserExists(string email)
		{
			if (_userService.GetByMail(email) != null)
			{
				return new ErrorResult(Messages.UseAlreadyResult);
			}

			return new SuccessResult();
		}
	}
}
