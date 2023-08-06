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
	public class FlatController : ControllerBase
	{
		private IFlatService _flatService;

		public FlatController(IFlatService flatService)
		{
			_flatService = flatService;
		}


		[HttpGet("getAll")]
		[Authorize(Roles = "admin")]
		public IActionResult GetList()
		{
			var result = _flatService.GetList();
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
			var result = _flatService.GetById(id);
			if (result.Success)
				return Ok(result.Data);

			return BadRequest(result.Message);
		}


		[HttpPost("add")]
		[Authorize(Roles = "admin")]
		public IActionResult Add(Flat flat)
		{
			var result = _flatService.Add(flat);
			if (result.Success)
				return Ok(result.Message);

			return BadRequest(result.Message);
		}

		[HttpPost("update")]
		[Authorize(Roles = "admin")]
		public IActionResult Update(Flat flat)
		{
			var result = _flatService.Update(flat);
			if (result.Success)
				return Ok(result.Message);

			return BadRequest(result.Message);
		}

		[HttpPost("delete")]
		[Authorize(Roles = "admin")]
		public IActionResult Delete(Flat flat)
		{
			var result = _flatService.Delete(flat);
			if (result.Success)
				return Ok(result.Message);

			return BadRequest(result.Message);
		}
	}
}
