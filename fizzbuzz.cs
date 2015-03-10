void Main()
{
	// 100までFizzBuzz
	FizzBuzzGenerate().Take(100).Dump();
}

// FizzBuzz作成
static IEnumerable<string> FizzBuzzGenerate()
{
   int i = 1;
   // iのoverflowはあえて無視
   while (true)
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
	   i++;
   }
}