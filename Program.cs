using System;

namespace collatz
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Number startNumber = new Number(5);

			while (startNumber.getValue() > 1)
			{
				if (startNumber.getValue() % 2 == 0)
				{
					startNumber.processEven();
				}
				else
				{
					startNumber.processOdd();
				}
			}
			Console.WriteLine(startNumber.getValue());
			Console.WriteLine($"The stopping time is {startNumber.getStoppingTime()}");
		}
	}
}
