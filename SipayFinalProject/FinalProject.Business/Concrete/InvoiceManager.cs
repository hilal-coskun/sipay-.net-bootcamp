using FinalProject.Business.Abstract;
using FinalProject.Business.Contants;
using FinalProject.Core.Utilities.Results;
using FinalProject.DataAcces.Concrete.EntityFramework;
using FinalProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business.Concrete
{
	public class InvoiceManager : IInvoiceService
	{
		private readonly EfInvoiceDal _efInvoiceDal;

		public InvoiceManager(EfInvoiceDal efInvoiceDal)
		{
			_efInvoiceDal = efInvoiceDal;
		}

		public IResult Add(Invoice invoice)
		{
			_efInvoiceDal.Add(invoice);
			return new SuccessResult(Messages.FlatAdded);
		}

		public IResult Delete(Invoice invoice)
		{
			_efInvoiceDal.Delete(invoice);
			return new SuccessResult(Messages.FlatDeleted);
		}

		public IDataResult<Invoice> GetById(int invoiceId)
		{
			var invoice = _efInvoiceDal.Get(p => p.Id == invoiceId);
			return new SuccessDataResult<Invoice>(invoice);
		}

		public IDataResult<List<Invoice>> GetList()
		{
			var invoices = _efInvoiceDal.GetList().ToList();
			return new SuccessDataResult<List<Invoice>>(invoices);
		}

		public IDataResult<List<Invoice>> GetListByFlat(int flatId)
		{
			var flats = _efInvoiceDal.GetList(p => p.FlatId == flatId).ToList();
			return new SuccessDataResult<List<Invoice>>(flats);
		}

		public IResult Update(Invoice invoice)
		{
			_efInvoiceDal.Update(invoice);
			return new SuccessResult(Messages.FlatUpdated);
		}
	}
}
