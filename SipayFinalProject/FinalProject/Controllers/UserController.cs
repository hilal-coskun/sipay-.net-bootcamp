﻿using FinalProject.Business.Abstract;
using FinalProject.Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private IUserService _userService;

		public UserController(IUserService userService)
		{
			_userService = userService;
		}

		[HttpGet("getAll")]
		public IActionResult GetList()
		{
			var result = _userService.GetList();
			if (result.Success)
			{
				return Ok(result.Data);
			}

			return BadRequest(result.Message);
		}

		[HttpGet("getListByFlats")]
		public IActionResult GetListByFlats(int flatId)
		{
			var result = _userService.GetUserListByFlat(flatId);
			if (result.Success)
			{
				return Ok(result.Data);
			}

			return BadRequest(result.Message);
		}


		[HttpGet("getById")]
		public IActionResult GetById(int id)
		{
			var result = _userService.GetById(id);
			if (result.Success)
				return Ok(result.Data);

			return BadRequest(result.Message);
		}


		[HttpPost("add")]
		public IActionResult Add(User user)
		{
			var result = _userService.Add(user);
			if (result.Success)
				return Ok(result.Message);

			return BadRequest(result.Message);
        }

		[HttpPost("update")]
		public IActionResult Update(User user)
		{
			var result = _userService.Update(user);
			if (result.Success)
				return Ok(result.Message);

			return BadRequest(result.Message);
		}

		[HttpPost("delete")]
		public IActionResult Delete(User user)
		{
			var result = _userService.Delete(user);
			if (result.Success)
				return Ok(result.Message);

			return BadRequest(result.Message);
		}
	}
}
