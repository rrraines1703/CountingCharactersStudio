using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Please enter a sentence:");

			string userInput = (Console.ReadLine()).ToUpper();
			string input = Regex.Replace(userInput, "[^A-Za-z0-9]", "");
			Dictionary<char, int> characters = new Dictionary<char, int>();

			foreach (var let in input)
			{
				if (characters.ContainsKey(let))
					characters[let] = characters[let] + 1;
				else
					characters.Add(let, 1);
			}


			foreach (var item in characters)
				Console.WriteLine($"{item.Key}: {item.Value}");
		}
	}
}
