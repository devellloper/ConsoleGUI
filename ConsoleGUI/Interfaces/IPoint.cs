using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGUI.Interfaces
{

	public interface IPoint
	{

		int X { get; set; }

		int Y { get; set; }

		char Value { get; set; }

		ConsoleColor? Foreground { get; set; }

		ConsoleColor? Background { get; set; }

		bool IsNeedRedraw { get; set; }

		void Draw(bool RedrawAnyway = false);

	}

}