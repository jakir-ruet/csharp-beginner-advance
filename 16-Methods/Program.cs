class Methods
{
	static void Main()
	{
		// Instance Method Call
		Methods obj = new Methods();
		obj.evenNumbers();

		// Static Method Call
		Methods.oddNumbers();

		// Static Method with Parameter Call
		Methods.evenNumParam(30);

		// Instance Method with Parameter Call
		Methods objNubParam = new Methods();
		int Sum = objNubParam.Add(10, 20);
		Console.WriteLine("Sum is: " + Sum);
	}

	public void evenNumbers()
	{
		int Start = 1;
		while (Start <= 20)
		{
			if (Start % 2 == 0)
			{
				Console.WriteLine("There are even numbers: " + Start);
			}
			Start++;
		}
	}

	public static void oddNumbers()
	{
		int Start = 1;
		while (Start <= 20)
		{
			if (Start % 2 != 0)
			{
				Console.WriteLine("There are odd numbers: " + Start);
			}
			Start++;
		}
	}

	public static void evenNumParam(int Traget)
	{
		int Start = 1;
		while (Start <= Traget)
		{
			if (Start % 2 == 0)
			{
				Console.WriteLine("There are even numbers with parameter: " + Start);
			}
			Start++;
		}
	}
	public int Add(int a, int b)
	{
		return a + b;
	}
}
