using FinalProject.Business.Abstract;
using FinalProject.Core.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace FinalProject.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DuesController : ControllerBase
	{
		private IDuesService _duesService;

		public DuesController(IDuesService duesService)
		{
			_duesService = duesService;
		}

		[HttpGet("getAll")]
		[Authorize(Roles = "admin")]
		public IActionResult GetList()
		{
			var result = _duesService.GetList();
			if (result.Success)
			{
				return Ok(result.Data);
			}

			return BadRequest(result.Message);
		}

		[HttpGet("getListByFlats")]
		[Authorize(Roles = "admin,customer")]
		public IActionResult GetListByFlats(int flatId)
		{
			var result = _duesService.GetListByFlat(flatId);
			if (result.Success)
			{
				return Ok(result.Data);
			}

			return BadRequest(result.Message);
		}


		[HttpGet("getById")]
		[Authorize(Roles = "admin,customer")]
		public IActionResult GetById(int id)
		{
			var result = _duesService.GetById(id);
			if (result.Success)
				return Ok(result.Data);

			return BadRequest(result.Message);
		}


		[HttpPost("add")]
		[Authorize(Roles = "admin")]
		public IActionResult Add(Dues dues)
		{
			var result = _duesService.Add(dues);
			if (result.Success)
				return Ok(result.Message);

			return BadRequest(result.Message);
		}

		[HttpPost("update")]
		[Authorize(Roles = "admin")]
		public IActionResult Update(Dues dues)
		{
			var result = _duesService.Update(dues);
			if (result.Success)
				return Ok(result.Message);

			return BadRequest(result.Message);
		}

		[HttpPost("delete")]
		[Authorize(Roles = "admin")]
		public IActionResult Delete(Dues dues)
		{
			var result = _duesService.Delete(dues);
			if (result.Success)
				return Ok(result.Message);

			return BadRequest(result.Message);
		}
	}
}
