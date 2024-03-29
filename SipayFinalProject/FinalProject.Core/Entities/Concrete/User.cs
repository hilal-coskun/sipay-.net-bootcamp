﻿using FinalProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Core.Entities.Concrete
{
	[Table("Users")]
	public class User : IEntity
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string TCNumber { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public string CarInfo { get; set; }
        public bool Status { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }

        public int FlatId { get; set; }
        public virtual Flat Flat { get; set; }
	}
}
