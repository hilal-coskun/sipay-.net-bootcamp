using FinalProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business.Abstract
{
	public interface IInvoiceService
	{
		Invoice GetById(int invoiceId);
		List<Invoice> GetList();
		List<Invoice> GetListByFlat(int flatId);
		void Add(Invoice invoice);
		void Update(Invoice invoice);
		void Delete(Invoice invoice);
	}
}
