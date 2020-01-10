using System;
using CR;
namespace CharRangeDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			var test = "abcdlmnorstuvwxz";
			// get a list of ranges for the above
			var ranges = CharRange.GetRanges(test);
			// write them out (looks like regex)
			Console.Write("[");
			foreach (var range in ranges)
				Console.Write(range);
			Console.WriteLine("]");
			// enumerate the characters in the ranges
			Console.Write("ranges chars: ");
			foreach (char ch in CharRange.ExpandRanges(ranges))
				Console.Write(ch);
			Console.WriteLine();
			// get a packed string - each char pair is one range
			Console.WriteLine("Packed string: " + CharRange.ToPackedString(ranges));
			// write out the inverted set of ranges (will look ugly in the console)
			Console.Write("[");
			foreach (var range in CharRange.NotRanges(ranges))
				Console.Write(range);
			Console.WriteLine("]");
			// range [a-x]
			var a2x = new CharRange('a', 'x');
			Console.WriteLine("[{0}]: Length = {1}", a2x, a2x.Length);
			// indexing into the range to get the character at the index
			Console.WriteLine("a2x[2] = " + a2x[2]);
			// enumerate the characters in the range
			Console.Write("a2x chars: ");
			foreach (var ch in a2x)
				Console.Write(ch);
			Console.WriteLine();
			
		

		}
	}
}
