using FinalProject.Business.Abstract;
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

		public void Add(Invoice invoice)
		{
			_efInvoiceDal.Add(invoice);
		}

		public void Delete(Invoice invoice)
		{
			_efInvoiceDal.Delete(invoice);
		}

		public Invoice GetById(int invoiceId)
		{
			var invoice = _efInvoiceDal.Get(p => p.Id == invoiceId);
			return invoice;
		}

		public List<Invoice> GetList()
		{
			var invoices = _efInvoiceDal.GetList().ToList();
			return invoices;
		}

		public List<Invoice> GetListByFlat(int flatId)
		{
			var flats = _efInvoiceDal.GetList(p => p.FlatId == flatId).ToList();
			return flats;
		}

		public void Update(Invoice invoice)
		{
			_efInvoiceDal.Update(invoice);
		}
	}
}
