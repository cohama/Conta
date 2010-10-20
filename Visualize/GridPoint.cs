using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Visualization
{
	class GridPoint
	{
		public void DrawTo( Image img, ColorContour contour )
		{
			Graphics g = Graphics.FromImage( img );
			Pen p = new Pen( Color.Black );
			int origin = contour.BmpMargin - 1;
			double unitX = (double)(contour.BmpWidth - 2*contour.BmpMargin - 1) / (contour.XNum - 1);
			double unitY = (double)(contour.BmpHeight- 2*contour.BmpMargin - 1) / (contour.YNum - 1);
			for( int i=0; i<contour.XNum; i++ )
			{
				for( int j=0; j<contour.YNum; j++ )
				{
					int x = (int)(i*unitX + 0.5);
					int y = (int)(j*unitY + 0.5);
					g.DrawRectangle( p, origin + x, origin + y, 2, 2 );
				}
			}
		}
	}
}
