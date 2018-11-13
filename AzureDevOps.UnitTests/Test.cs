using NUnit.Framework;
using System;
using AzureDevOps.Models;

namespace AzureDevOps.UnitTests
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void TestLogicModelCase()
		{
			var logicModel = new LogicModel();
			Assert.AreEqual(0, logicModel.X);
			Assert.AreEqual(0, logicModel.Y);
			Console.WriteLine($"Logic Model #1: {logicModel.X}, {logicModel.Y}");

			logicModel = new LogicModel(1, 2);
			Assert.AreEqual(1, logicModel.X);
			Assert.AreEqual(2, logicModel.Y);
			Console.WriteLine($"Logic Model #2: {logicModel.X}, {logicModel.Y}");
		}
	}
}
