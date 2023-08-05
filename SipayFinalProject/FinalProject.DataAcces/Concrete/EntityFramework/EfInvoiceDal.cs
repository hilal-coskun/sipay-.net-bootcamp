using FinalProject.Core.DataAccess.EntityFramework;
using FinalProject.Core.Entities.Concrete;
using FinalProject.DataAccess.Abstract;
using FinalProject.DataAccess.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataAcces.Concrete.EntityFramework
{
	public class EfInvoiceDal : EfEntityRepositoryBase<Invoice, DataContexts>, IInvoiceDal
	{
		
	}
}
