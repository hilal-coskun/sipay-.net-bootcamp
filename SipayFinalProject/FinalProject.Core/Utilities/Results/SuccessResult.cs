using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Core.Utilities.Results
{
	public class SuccessResult : Result
	{
		public SuccessResult() : base(true)
		{

		}

		public SuccessResult(string message) : base(true, message)
		{

		}
	}
}
