using Autofac;
using FinalProject.Business.Abstract;
using FinalProject.Business.Concrete;
using FinalProject.DataAcces.Concrete.EntityFramework;
using FinalProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business.Autofac
{
	public class AutofacBussinessModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<UserManager>().As<IUserService>();
			builder.RegisterType<EfUserDal>().As<IUserDal>();

			builder.RegisterType<DuesManager>().As<IDuesService>();
			builder.RegisterType<EfDuesDal>().As<IDuesDal>();

			builder.RegisterType<InvoiceManager>().As<IInvoiceService>();
			builder.RegisterType<EfInvoiceDal>().As<IInvoiceDal>();

			builder.RegisterType<FlatManager>().As<IFlatService>();
			builder.RegisterType<EfFlatDal>().As<IFlatDal>();

		}
	}
}
