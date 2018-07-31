using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGUI.Interfaces
{

	public interface IFigure
	{

		int X { get; set; }

		int Y { get; set; }

		int Width { get; set; }

		int Height { get; set; }

		IEnumerable<IPoint> Points { get; }

		void Append(IPoint point);

		int Count { get; }

		void Draw(bool RedrawAnyway = false);

	}

}