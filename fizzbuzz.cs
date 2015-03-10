void Main()
{
	// 100までFizzBuzz
	Enumerable.Range(1, 100)
		.Select(x=> FuzzBizz(x))
		.Dump();
}

static string FuzzBizz(int i)
{
	if (i % 15 == 0)
	{
		return "FizzBuzz";
	}
	else if (i % 3 == 0)
	{
		return "Fizz";
	}
	else if (i % 5 == 0)
	{
		return "Buzz";
	}
	else
	{
		return i.ToString();
	}
}