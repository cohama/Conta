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

		public override void DrawTo( Bitmap bmp, IDataSheet data )
		{
			if( !Setting.Show )
			{
				return;
			}
			Graphics g = Graphics.FromImage( bmp );
			Pen p = new Pen( Color.Black );
			int originX = Visualize.BmpMargin - 1;
			int originY = bmp.Height - Visualize.BmpMargin;
			double unitX = (double)(bmp.Width - 2*Visualize.BmpMargin - 1) / (data.GetX( data.Columns-1 ) - data.GetX( 0 ) );
			double unitY = (double)(bmp.Height- 2*Visualize.BmpMargin - 1) / (data.GetY( data.Rows-1 ) - data.GetY( 0 ) );
			for( int i=0; i<data.Columns; i++ )
			{
				for( int j=0; j<data.Rows; j++ )
				{
					int x = (int)(data.GetX( i )*unitX + 0.5);
					int y = (int)(data.GetY( j )*unitY + 0.5);
					g.DrawRectangle( p, originX + x, originY - y, 2, 2 );
				}
			}
		}
	}
}
