using FinalProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Core.Entities.Concrete
{
	public class UserOperationClaim : IEntity
	{
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public int OperationClaimId { get; set; }
    }
}
