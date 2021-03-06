using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvestmentCalculator.Lib.Common;
using InvestmentCalculator.Lib.Models;

namespace InvestmentCalculator.Lib.Interfaces
{
	public interface IInvestmentCalculateService
	{
		public ExecutionResult<double> CalculateSum(InvestmentModel model);
	}
}