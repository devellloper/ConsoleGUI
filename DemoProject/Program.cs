using System;
using System.Linq;

namespace DemoProject
{

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.WriteLine();
			Console.WriteLine("1 - Simple figure");
			Console.WriteLine("2 - Simple window with labels");
			Console.WriteLine();
			Console.Write("Enter your choice: ");

			if(int.TryParse(Console.ReadLine(), out int result))
			{
				Console.Clear();

				switch (result)
				{
					case 1:
						SimpleFigure();
						break;
					case 2:
						SimpleWindowWithLabels();
						break;
				}
			}

			Console.Clear();
			Console.WriteLine("Press any key to exit.");
			Console.ReadKey(true);
		}

		private static void SimpleWindowWithLabels()
		{
			using (ConsoleGUI.Controls.Window w = new ConsoleGUI.Controls.Window())
			{
				w.Background = ConsoleColor.Blue;
				w.Foreground = ConsoleColor.Cyan;
				w.Append(ConsoleGUI.Controls.Label.Create(w, "Hi :)", 0, 0, ConsoleColor.Red, ConsoleColor.White));
				w.Append(ConsoleGUI.Controls.Label.Create(w, "Hello, world! How are you?", 0, 2));
				w.Append(ConsoleGUI.Controls.Label.Create(w, "My name is Dmytry Koshovyi :-)", 0, 3));
				w.Show();
			}
		}

		private static void SimpleFigure()
		{
			ConsoleGUI.Figure f = new ConsoleGUI.Figure();
			f.Append(ConsoleGUI.Point.Create(0, 0, '[', ConsoleColor.Red));
			f.Append(ConsoleGUI.Point.Create(1, 0, '=', ConsoleColor.Yellow));
			f.Append(ConsoleGUI.Point.Create(2, 0, '=', ConsoleColor.Magenta));
			f.Append(ConsoleGUI.Point.Create(3, 0, ']', ConsoleColor.Blue));
			f.Draw();
		}

	}

}
