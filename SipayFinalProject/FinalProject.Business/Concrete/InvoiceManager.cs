using FinalProject.Business.Abstract;
using FinalProject.Business.Contants;
using FinalProject.Core.Entities.Concrete;
using FinalProject.Core.Utilities.Results;
using FinalProject.DataAcces.Concrete.EntityFramework;
using FinalProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business.Concrete
{
	public class InvoiceManager : IInvoiceService
	{
		private readonly IInvoiceDal _invoinceDal;

		public InvoiceManager(IInvoiceDal invoinceDal)
		{
			_invoinceDal = invoinceDal;
		}

		public IResult Add(Invoice invoice)
		{
			_invoinceDal.Add(invoice);
			return new SuccessResult(Messages.FlatAdded);
		}

		public IResult Delete(Invoice invoice)
		{
			_invoinceDal.Delete(invoice);
			return new SuccessResult(Messages.FlatDeleted);
		}

		public IDataResult<Invoice> GetById(int invoiceId)
		{
			var invoice = _invoinceDal.Get(p => p.Id == invoiceId);
			return new SuccessDataResult<Invoice>(invoice);
		}

		public IDataResult<List<Invoice>> GetList()
		{
			var invoices = _invoinceDal.GetList().ToList();
			return new SuccessDataResult<List<Invoice>>(invoices);
		}

		public IDataResult<List<Invoice>> GetListByFlat(int flatId)
		{
			var flats = _invoinceDal.GetList(p => p.FlatId == flatId).ToList();
			return new SuccessDataResult<List<Invoice>>(flats);
		}

		public IResult Update(Invoice invoice)
		{
			_invoinceDal.Update(invoice);
			return new SuccessResult(Messages.FlatUpdated);
		}
	}
}
