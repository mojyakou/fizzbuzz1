void Main()
{
	// 100までFizzBuzz
	FizzBuzzGenerate(100).Dump();
}

// FizzBuzz作成
static IEnumerable<string> FizzBuzzGenerate(int count)
{
   for (var i = 1; i <= count; i++)
   {
       if (i % 15 == 0)
       {
           yield return "FizzBuzz";
       }
       else if (i % 3 == 0)
       {
            yield return "Fizz";
       }
       else if (i % 5 == 0)
       {
            yield return "Buzz";
       }
       else
       {
            yield return i.ToString();
       }
   }
}
