namespace collatz
{
	class Number
	{
		private int value;
		private int stoppingTime = 0;

		public Number(int startNumber)
		{
			value = startNumber;
		}

		public Number(int startNumber, int calcStoppingTime) // use to record pre-calcuated numbers
		{
			value = startNumber;
			stoppingTime = calcStoppingTime;
		}

		public int getValue()
		{
			return this.value;
		}

		public int getStoppingTime()
		{
			return this.stoppingTime;
		}

		public void processEven()
		{
			this.value = this.value / 2;
			this.stoppingTime++;
		}

		public void processOdd()
		{
			this.value = 3 * this.value + 1;
			this.stoppingTime++;
		}
	}
}