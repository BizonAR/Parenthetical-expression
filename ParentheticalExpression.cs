using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentheticalExpression
{
	internal class ParentheticalExpression
	{
		static void Main(string[] args)
		{
			int maximumBracketDepth = 0;
			int currentBracketDepth = 0;
			bool isCorrectString = true;

			char openingBracket = '(';
			char closingBracket = ')';

			Console.Write("Введите строку полностью состоящую из скобок: ");
			string bracketString = Console.ReadLine();

			for (int i = 0; i < bracketString.Length; i++)
			{
				if (bracketString[i] == openingBracket)
				{
					currentBracketDepth++;

					if (currentBracketDepth > maximumBracketDepth)
						maximumBracketDepth = currentBracketDepth;
				}
				else if (bracketString[i] == closingBracket)
				{
					currentBracketDepth--;

					if (currentBracketDepth < 0)
						isCorrectString = false;
				}
			}
			if (currentBracketDepth != 0)
				isCorrectString = false;

			if (isCorrectString == true)
				Console.WriteLine("Строка корректна.");
			else
				Console.WriteLine("Строка некорректна");

			Console.WriteLine($"Максимальная глубина вложенности скобок: {maximumBracketDepth}");
		}
	}
}
