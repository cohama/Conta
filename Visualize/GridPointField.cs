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

		public override void DrawTo( Canvas canvas, IDataSheet data )
		{
			if( !Setting.Show )
			{
				return;
			}
			Graphics g = Graphics.FromImage( canvas.Bitmap );
			Pen p = new Pen( Color.Black );
			for( int i=0; i<data.Columns; i++ )
			{
				for( int j=0; j<data.Rows; j++ )
				{
					Point pt = canvas.AsBitmapCoord( data.GetX( i ), data.GetY( j ) );
					g.DrawRectangle( p, pt.X - 1, pt.Y -1, 2, 2 );
				}
			}
		}
	}
}
