using System;
using System.Linq;

namespace Tetris
{
	class Program
	{
		static void Main(string[] args)
		{
			Display display = new(width: 25, height: 25);
			display.Print();

			Console.WriteLine();
		}
	}
}
