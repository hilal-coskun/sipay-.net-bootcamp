using FinalProject.Business.Abstract;
using FinalProject.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class InvoiceController : ControllerBase
	{
		private IInvoiceService _invoiceService;

		public InvoiceController(IInvoiceService invoiceService)
		{
			_invoiceService = invoiceService;
		}

		[HttpGet("getAll")]
		public IActionResult GetList()
		{
			var result = _invoiceService.GetList();
			if (result.Success)
			{
				return Ok(result.Data);
			}

			return BadRequest(result.Message);
		}

		[HttpGet("getListByFlats")]
		public IActionResult GetListByFlats(int flatId)
		{
			var result = _invoiceService.GetListByFlat(flatId);
			if (result.Success)
			{
				return Ok(result.Data);
			}

			return BadRequest(result.Message);
		}


		[HttpGet("getById")]
		public IActionResult GetById(int id)
		{
			var result = _invoiceService.GetById(id);
			if (result.Success)
				return Ok(result.Data);

			return BadRequest(result.Message);
		}


		[HttpPost("add")]
		public IActionResult Add(Invoice ınvoice)
		{
			var result = _invoiceService.Add(ınvoice);
			if (result.Success)
				return Ok(result.Message);

			return BadRequest(result.Message);
		}

		[HttpPost("update")]
		public IActionResult Update(Invoice ınvoice)
		{
			var result = _invoiceService.Update(ınvoice);
			if (result.Success)
				return Ok(result.Message);

			return BadRequest(result.Message);
		}

		[HttpPost("delete")]
		public IActionResult Delete(Invoice ınvoice)
		{
			var result = _invoiceService.Delete(ınvoice);
			if (result.Success)
				return Ok(result.Message);

			return BadRequest(result.Message);
		}
	}
}
