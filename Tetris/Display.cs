using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
	public class Display
	{
		int Witdth;
		int Height;

		string horizontalBorder = "\u2550";
        string verticalBorder = "\u2551";

		string TopBorderLineTemplate;
		string MiddleBorderLineTemplate;
		string BottomBorderLineTemplate;

		public Display(int width, int height)
		{
			if (width < 0 && height < 0)
			{
				throw new ArgumentException($"{nameof(Witdth)}/{nameof(height)} of {nameof(Display)} cannot be negative");
			}

			Witdth = width;
			Height = height;

			TopBorderLineTemplate = "\u2554" + string.Concat(Enumerable.Repeat(horizontalBorder, Witdth)) + "\u2557";
			MiddleBorderLineTemplate = verticalBorder + string.Concat(Enumerable.Repeat(" ", Witdth)) + verticalBorder;
			BottomBorderLineTemplate = "\u255A" + string.Concat(Enumerable.Repeat(horizontalBorder, Witdth)) + "\u255D";
		}

		public void Print()
		{
			Console.SetCursorPosition(0, 0);
			Console.Write(TopBorderLineTemplate);

			for (var i = 1; i <= Witdth + 1; ++i)
			{
				Console.SetCursorPosition(0, i);
				Console.Write(MiddleBorderLineTemplate);
			}

			Console.SetCursorPosition(0, Witdth+2);
			Console.Write(BottomBorderLineTemplate);
		}
	}
}
