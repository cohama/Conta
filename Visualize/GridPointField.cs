using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Visualization
{
	class GridPointField : Field
	{
		public GridPointSetting Setting { get; private set; }

		public GridPointField()
		{
			this.Setting = new GridPointSetting();
		}

		public override void DrawTo( Bitmap bmp, DataSheet data )
		{
			if( !Setting.Show )
			{
				return;
			}
			Graphics g = Graphics.FromImage( bmp );
			Pen p = new Pen( Color.Black );
			int origin = Visualize.BmpMargin - 1;
			double unitX = (double)(bmp.Width - 2*Visualize.BmpMargin - 1) / (data.Columns - 1);
			double unitY = (double)(bmp.Height- 2*Visualize.BmpMargin - 1) / (data.Rows - 1);
			for( int i=0; i<data.Columns; i++ )
			{
				for( int j=0; j<data.Rows; j++ )
				{
					int x = (int)(i*unitX + 0.5);
					int y = (int)(j*unitY + 0.5);
					g.DrawRectangle( p, origin + x, origin + y, 2, 2 );
				}
			}
		}
	}
}
