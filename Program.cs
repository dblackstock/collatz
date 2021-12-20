using System;

namespace collatz
{
	class Program
	{
		private Number numberWithLongestStoppingTime = new Number(0, 0);
		static void Main(string[] args)
		{
			var watch = new System.Diagnostics.Stopwatch();
			watch.Start();
			var prog = new Program();
			Console.WriteLine("Welcome to Collatz Conjecture checker!");
			Console.WriteLine("This will check every number from 1 to 100,000,000");

			for (long i = 1; i <= 100000000; i++)
			{
				Number startNumber = new Number(i);
				CheckNumber(startNumber);
				if (startNumber.getStoppingTime() > prog.numberWithLongestStoppingTime.getStoppingTime())
				{
					prog.numberWithLongestStoppingTime = new Number(i, startNumber.getStoppingTime());
				}
			}
			watch.Stop();
			Console.WriteLine($"The number with the longest stopping time is {prog.numberWithLongestStoppingTime.getValue()}");
			Console.WriteLine($"The longest stopping time is {prog.numberWithLongestStoppingTime.getStoppingTime()}");
			Console.WriteLine($"Processing time was {watch.ElapsedMilliseconds} ms");

		}

		static void CheckNumber(Number numberToCheck)
		{
			while (numberToCheck.getValue() > 1)
			{
				if (numberToCheck.getValue() % 2 == 0)
				{
					numberToCheck.processEven();
				}
				else
				{
					numberToCheck.processOdd();
				}
			}
		}
	}
}
