using ConsoleGUI.Enums;
using ConsoleGUI.Interfaces;
using System;
using System.Collections.Generic;

namespace ConsoleGUI.Controls
{

	public class Control : IControl
	{

		private readonly List<IControl> _controls;

		private ConsoleColor _foreGround;

		private ConsoleColor _backGround;

		public ConsoleColor? Foreground { get; set; }

		public ConsoleColor? Background { get; set; }

		public bool IsTabControl { get; protected set; }

		public bool IsContainer { get; protected set; }

		public ControlType Type { get; protected set; }

		public IFigure Figure { get; protected set; }

		public IControl Parent { get; protected set; }

		public IEnumerable<IControl> Controls
		{
			get
			{
				return this._controls;
			}
		}

		public Control(bool isTabControl, bool isContainer)
		{
			this._controls = new List<IControl>();
			this.IsTabControl = isTabControl;
			this.IsContainer = isContainer;
		}

		public void Append(IControl control)
		{
			this._controls.Add(control);
		}

		public void Draw()
		{
			this._foreGround = Console.ForegroundColor;
			this._backGround = Console.BackgroundColor;

			foreach (IControl c in this._controls)
				c.Draw();
			this.Figure?.Draw();

			Console.ForegroundColor = this._foreGround;
			Console.BackgroundColor = this._backGround;
		}

		public void Dispose()
		{
		}

	}

}