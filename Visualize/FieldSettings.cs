using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Visualization
{
	public enum FieldSizeMode
	{
		HeightBase,
		WidthBase,
	}

	public class FieldSettings
	{
		public double MaxValue { get; set; }
		public double MinValue { get; set; }

		public bool Contour { get; set; }
		public bool Vector { get; set; }
		public bool GridPoint { get; set; }
		public bool Line { get; set; }

		public bool AutoScaleColor { get; set; }

		public ArrowSettings Arrow { get; set; }

		public FieldSizeMode SizeMode { get; set; }

		public FieldSettings()
		{
			this.MaxValue = 1.0;
			this.MinValue = 0;
			this.AutoScaleColor = true;

			this.Arrow = new ArrowSettings();
		}
	}
}
