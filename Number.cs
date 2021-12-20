namespace collatz
{
	class Number
	{
		private long value;
		private int stoppingTime = 0;

		public Number(long startNumber)
		{
			value = startNumber;
		}

		public Number(long startNumber, int calcStoppingTime) // use to record pre-calcuated numbers
		{
			value = startNumber;
			stoppingTime = calcStoppingTime;
		}

		public long getValue()
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
			this.value = (3 * this.value + 1) / 2;
			this.stoppingTime = this.stoppingTime + 2;
		}
	}
}