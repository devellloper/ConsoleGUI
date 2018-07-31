using System;
using ConsoleGUI.Interfaces;

namespace ConsoleGUI.Controls
{

	public class Label : Control, IControlLabel
	{

		private string _text;

		private const int MINIMAL_LABEL_HEIGHT = 1;

		public string Text
		{
			get
			{
				return this._text;
			}
			set
			{
				this._text = value;
				this.InitPoints();
			}
		}

		protected Label(string text, int x, int y, ConsoleColor? foreground = null, ConsoleColor? background = null) : base(false, false)
		{
			this.Figure = new Figure()
			{
				X = x,
				Y = y,
				Width = text.Length,
				Height = MINIMAL_LABEL_HEIGHT,
			};
			this.Foreground = foreground;
			this.Background = background;
			this.Text = text;
		}

		private void InitPoints()
		{
			if (!string.IsNullOrEmpty(this.Text))
			{
				int x = 0; ;
				foreach (char c in this.Text)
				{
					if (x > this.Figure.Width)
						return;

					IPoint point = Point.Create(this.Figure.X + x++, this.Figure.Y, c, this.Foreground, this.Background);
					this.Figure.Append(point);
				}
			}
		}

		public static IControlLabel Create(IControl parent, string text, int x, int y, ConsoleColor? foreground = null, ConsoleColor? background = null)
		{
			return new Label(text, x, y, foreground ?? parent.Foreground, background ?? parent.Background)
			{
				Parent = parent,
			};
		}

		
	}

}