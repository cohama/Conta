using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Visualization
{
	public class VectorFormatException : FormatException
	{
		public VectorFormatException( string msg )
			: base( msg ) { }
	}

	class Vectorgram
	{
		public void DrawTo( Image img, ColorContour contour, FieldSettings field )
		{
			if( !contour.HasVectorData )
			{
				throw new InvalidOperationException( "ベクトルデータはありません" );
			}
			Graphics g = Graphics.FromImage( img );
			Pen p = new Pen( field.Arrow.LineColor );
			Brush b = new SolidBrush( field.Arrow.InnerColor );
			PointF origin = new PointF( (float)contour.BmpMargin, (float)contour.BmpMargin );
			float unitX = (float)(contour.BmpWidth - 2*contour.BmpMargin -1) / (contour.XNum - 1);
			float unitY = (float)(contour.BmpHeight- 2*contour.BmpMargin -1) / (contour.YNum - 1);

			Drawer d = new Drawer( g, field );

			for( int i=0; i<contour.XNum; i++ )
			{
				for( int j=0; j<contour.YNum; j++ )
				{
					SizeF pt1 = new SizeF( i*unitX, (contour.YNum-1-j)*unitY );
					d.DrawArrow( origin + pt1, contour.scrData[i][j], contour.uData[i][j], contour.vData[i][j] );
				}
			}
		}
	}
}
