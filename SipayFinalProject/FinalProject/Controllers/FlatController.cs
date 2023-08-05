using FinalProject.Business.Abstract;
using FinalProject.Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
		public IActionResult GetById(int id)
		{
			var result = _flatService.GetById(id);
			if (result.Success)
				return Ok(result.Data);

			return BadRequest(result.Message);
		}


		[HttpPost("add")]
		public IActionResult Add(Flat flat)
		{
			var result = _flatService.Add(flat);
			if (result.Success)
				return Ok(result.Message);

			return BadRequest(result.Message);
		}

		[HttpPost("update")]
		public IActionResult Update(Flat flat)
		{
			var result = _flatService.Update(flat);
			if (result.Success)
				return Ok(result.Message);

			return BadRequest(result.Message);
		}

		[HttpPost("delete")]
		public IActionResult Delete(Flat flat)
		{
			var result = _flatService.Delete(flat);
			if (result.Success)
				return Ok(result.Message);

			return BadRequest(result.Message);
		}
	}
}
