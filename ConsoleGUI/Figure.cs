using System.Collections.Generic;
using ConsoleGUI.Interfaces;

namespace ConsoleGUI
{

	public class Figure : IFigure
	{

		private readonly List<IPoint> _points;

		public int X { get; set; }

		public int Y { get; set; }

		public int Height { get; set; }

		public int Width { get; set; }

		public IEnumerable<IPoint> Points
		{
			get
			{
				return this._points;
			}
		}

		public int Count
		{
			get
			{
				return this._points.Count;
			}
		}

		#region Constructor

		public Figure()
		{
			this._points = new List<IPoint>();
		}

		#endregion

		public virtual void Draw(bool RedrawAnyway = false)
		{
			foreach(IPoint point in this._points)
			{
				point.Draw(RedrawAnyway);
			}
		}

		public void Append(IPoint point)
		{
			this._points.Add(point);
		}

	}

}