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
	[Table("Dues")]
	public class Dues : IEntity
	{
		[Key]
		public int Id { get; set; }
		public decimal Amount { get; set; }
		public DateTime Date { get; set; }
		public int FlatId { get; set; }
		public virtual Flat Flat { get; set; }
	}
}
