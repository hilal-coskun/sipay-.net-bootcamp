using FinalProject.Core.Entities.Concrete;
using FinalProject.Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business.Abstract
{
	public interface IInvoiceService
	{
		IDataResult<Invoice> GetById(int invoiceId);
		IDataResult<List<Invoice>> GetList();
		IDataResult<List<Invoice>> GetListByFlat(int flatId);
		IResult Add(Invoice invoice);
		IResult Update(Invoice invoice);
		IResult Delete(Invoice invoice);
	}
}
