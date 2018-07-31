using System;
using System.Collections.Generic;
using ConsoleGUI.Interfaces;

namespace ConsoleGUI
{

	public class Point : IPoint
	{

		public int X { get; set; }

		public int Y { get; set; }

		public char Value { get; set; }

		public ConsoleColor? Foreground { get; set; }

		public ConsoleColor? Background { get; set; }

		public bool IsNeedRedraw { get; set; }

		protected Point()
		{
			this.IsNeedRedraw = true;
		}

		public void Draw(bool RedrawAnyway = false)
		{
			if (this.IsNeedRedraw || RedrawAnyway)
			{
				if (Console.CursorLeft != this.X)
					Console.CursorLeft = this.X;
				if (Console.CursorTop != this.Y)
					Console.CursorTop = this.Y;
				if (this.Foreground.HasValue && Console.ForegroundColor != this.Foreground)
					Console.ForegroundColor = this.Foreground.Value;
				if (this.Background.HasValue && Console.BackgroundColor != this.Background)
					Console.BackgroundColor = this.Background.Value;
				Console.Write(this.Value);
			}
		}

		public static IPoint Create(int x, int y, char value, ConsoleColor? foreground = null, ConsoleColor? background = null)
		{
			return new Point()
			{
				X = x,
				Y = y,
				Value = value,
				Foreground = foreground,
				Background = background,
			};
		}

	}

}