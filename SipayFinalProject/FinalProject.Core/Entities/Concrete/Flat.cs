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
		public string Block { get; set; }
		public bool IsFull { get; set; }
		public string Type { get; set; }
		public int FloorNo { get; set; }
		public int FlatNo { get; set; }

		public int OwnerId { get; set; }
		public virtual User Owner { get; set; }

		public List<Dues> Dueses { get; set; }

		public List<Invoice> Invoices { get; set; }
	}
}
