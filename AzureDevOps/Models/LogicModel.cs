using System;
namespace AzureDevOps.Models
{
	public class LogicModel
	{
		public double X { get; set; }

		public double Y { get; set; }

		public LogicModel()
		{
			X = 0;
			Y = 0;
		}

		public LogicModel(double x, double y)
		{
			Y = x;
			X = y;
		}
	}
}
