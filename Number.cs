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