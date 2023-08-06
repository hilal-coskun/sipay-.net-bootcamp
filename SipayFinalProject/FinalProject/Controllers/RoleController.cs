using FinalProject.Business.Abstract;
using FinalProject.Core.Entities.Concrete;
using FinalProject.Entities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace FinalProject.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RoleController : ControllerBase
	{

		private readonly IAuthService _authService;
		private readonly IUserOperationClaimsService _userOperationClaimsService;

		public RoleController(IAuthService authService, IUserOperationClaimsService userOperationClaimsService)
		{
			_authService = authService;
			_userOperationClaimsService = userOperationClaimsService;
		}


		[HttpPost("assignmentRole")]
		public ActionResult AssignmentRoleByUser(UserAssignmentRoleDto userAssignmentRoleDto)
		{
			var result = _authService.AssignmentRole(userAssignmentRoleDto.UserId, userAssignmentRoleDto.OperationClaimId);


			if (result.Success)
			{
				return Ok(result);
			}

			return BadRequest(result.Message);
		}

		[Authorize(Roles = "admin")]
		[HttpPost("delete")]
		public IActionResult Delete(UserOperationClaim userOperationClaim)
		{
			var result = _userOperationClaimsService.Delete(userOperationClaim);
			if (result.Success)
				return Ok(result.Message);

			return BadRequest(result.Message);
		}


		[HttpGet("getAll")]
		[Authorize(Roles ="admin")]
		public IActionResult GetList()
		{
			var result = _userOperationClaimsService.GetList();
			if (result.Success)
			{
				return Ok(result.Data);
			}

			return BadRequest(result.Message);
		}

		[Authorize(Roles = "admin")]
		[HttpGet("getById")]
		public IActionResult GetById(int id)
		{
			var result = _userOperationClaimsService.GetById(id);
			if (result.Success)
				return Ok(result.Data);

			return BadRequest(result.Message);
		}
	}
}
