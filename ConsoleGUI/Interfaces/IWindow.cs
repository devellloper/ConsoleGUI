using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGUI.Interfaces
{

	public interface IWindow: IControl
	{

		void Show();

		void Hide();

	}

}