using ConsoleGUI.Enums;
using ConsoleGUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleGUI.Controls
{

	public class Window : Control, IWindow
	{

		private bool _cursorBeforeShow;

		public Window() : base(false, true)
		{
			this.Type = ControlType.Window;
		}

		public void Show()
		{
			_cursorBeforeShow = Console.CursorVisible;
			Console.CursorVisible = false;

			this.Draw();

			while (Console.ReadKey(true).Key != ConsoleKey.Escape)
			{
				Thread.Sleep(10);
			}
		}

		public void Hide()
		{
			Console.CursorVisible = _cursorBeforeShow;
			this.Parent?.Draw();
		}

	}

}