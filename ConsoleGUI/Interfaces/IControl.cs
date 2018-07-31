using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGUI.Interfaces
{

	public interface IControl : IDisposable
	{

		ConsoleColor? Foreground { get; set; }

		ConsoleColor? Background { get; set; }

		bool IsTabControl { get; }

		bool IsContainer { get; }

		Enums.ControlType Type { get; }

		IFigure Figure { get; }

		IControl Parent { get; }

		IEnumerable<IControl> Controls { get; }

		void Append(IControl control);

		void Draw();

	}

}