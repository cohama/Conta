using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Visualization
{
	public delegate Color ColorGenerator( int hue );

	public static class ColorBar
	{
		private static Color[] colors;

		public static Color FromHue( int hue ){ return ColorBar.colors[hue]; }

		public static ColorGenerator Generator
		{
			set
			{
				for( int i=0; i<Resolusion; i++ )
				{
					ColorBar.colors[i] = value( i );
				}
			}
		}			



		public static readonly int Resolusion = 360;

		static ColorBar()
		{
			ColorBar.colors = new Color[Resolusion];
			ColorBar.Generator = ColorBar.DefaultGenerator;
		}

		#region カラーバー生成関数
		public static Color DefaultGenerator( int hue )
		{
			int r = (int)(255*(Math.Sin( (hue/2.0 - 60.0)/180.0*Math.PI )));
			int g = (int)(255*(Math.Sin( hue/2.0/180.0*Math.PI )));
			int b = (int)(255*(Math.Sin( (hue/2.0 + 60.0)/180.0*Math.PI )));
			if( r < 0 ) r = 0;
			if( g < 0 ) g = 0;
			if( b < 0 ) b = 0;

			return Color.FromArgb( r, g, b );
		}
		#endregion
	}
}
