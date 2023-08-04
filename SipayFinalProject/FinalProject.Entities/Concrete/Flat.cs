using FinalProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Entities.Concrete
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
		public virtual ICollection<User> Users { get; set; }

		public ICollection<Dues> Dueses { get; set; }
		public ICollection<Invoice> Invoices { get; set; }
	}
}
