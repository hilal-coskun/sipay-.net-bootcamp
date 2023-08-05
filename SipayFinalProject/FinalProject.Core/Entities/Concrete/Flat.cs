using FinalProject.Core.Entities;
using FinalProject.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Core.Entities.Concrete
{
	[Table("Flat")]
	public class Flat : IEntity
	{

		[Key]
		public int Id { get; set; }
		public string BlokNo { get; set; }
		public bool IsFull { get; set; }
		public string Type { get; set; }
		public int FloorNumber { get; set; }
		public int FlatNumber { get; set; }

		public int UserId { get; set; }
		public virtual User User { get; set; }

		public int DuesesId { get; set; }
		public List<Dues> Dueses { get; set; }

		public int InvoicesId { get; set; }
		public List<Invoice> Invoices { get; set; }
	}
}
