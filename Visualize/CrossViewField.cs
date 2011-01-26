using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Visualization
{
	/// <summary>
	/// 任意の断面における値の分布図を描画するためのクラスです。
	/// </summary>
	class CrossViewField : Field
	{
		public CrossViewSetting Setting { get; private set; }

		public CrossViewField()
		{
			this.Setting = new CrossViewSetting();
		}

		public override void DrawTo( Canvas canvas, IDataSheet data )
		{
			Bitmap bmp = canvas.Bitmap;
			if( !this.Setting.Show )
			{
				return;
			}
			if( !this.Setting.IsLengthFixed )
			{
				double absMax = (Math.Abs( data.MaxZ ) > Math.Abs( data.MinZ ))	? Math.Abs( data.MaxZ )
																				: Math.Abs( data.MinZ );
				if( absMax == 0 ) absMax = 1;
				this.Setting.ReferredLength = absMax;
			}

			Graphics g = Graphics.FromImage( bmp );

			SolidBrush plotBlush = new SolidBrush( Setting.PlotColor );
			Pen plotPen = new Pen( Setting.PlotFrameColor );
			Pen linePen = new Pen( Setting.LineColor, Setting.LineWidth );
			Pen axisPen = new Pen( Setting.AxisColor, Setting.AxisWidth );

			Point lefttop = canvas.AsBitmapCoord( 0, 1 );
			Point rightbottom = canvas.AsBitmapCoord( 1, 0 );
			
			g.DrawRectangle( axisPen, lefttop.X, lefttop.Y, canvas.DrawingWidth, canvas.DrawingHeight );

			if( Setting.ReferenceI >= data.Columns ) Setting.ReferenceI = data.Columns - 1;
			if( Setting.ReferenceJ >= data.Rows ) Setting.ReferenceJ = data.Rows - 1;

			if( this.Setting.Horizontal )
			{
				double refY = data.GetY( this.Setting.ReferenceJ );
				g.DrawLine( axisPen, canvas.AsBitmapCoord( 0, refY ), canvas.AsBitmapCoord( 1, refY ) );
				List<Point> pt = new List<Point>();
				pt.Add( canvas.AsBitmapCoord( 0, refY ) );
				Func<int, int, double> value = (Setting.VectorMode)	? new Func<int, int, double>( data.GetV ) 
																	: new Func<int, int, double>( data.GetZ );
				for( int i=0; i<data.Columns; i++ )
				{
					int h = (int)(value( i, Setting.ReferenceJ )/this.Setting.ReferredLength*Setting.Scale + 0.5);
					Point gridPt = canvas.AsBitmapCoord( data.GetX( i ), refY );
					pt.Add( new Point( gridPt.X, gridPt.Y-h ) );
				}
				pt.Add( canvas.AsBitmapCoord( 1, refY ) );
				g.DrawLines( linePen, pt.ToArray() );
				int s = Setting.PlotSize;
				for( int i=1; i<pt.Count-1; i++ )
				{
					g.FillEllipse( plotBlush, pt[i].X - s/2, pt[i].Y - s/2, s, s );
					g.DrawEllipse( plotPen, pt[i].X - s/2, pt[i].Y - s/2, s, s );
				}

			}
			if( this.Setting.Vertical )
			{
				double refX = data.GetX( this.Setting.ReferenceI );
				g.DrawLine( axisPen, canvas.AsBitmapCoord( refX, 0 ), canvas.AsBitmapCoord( refX, 1 ) );
				List<Point> pt = new List<Point>();
				pt.Add( canvas.AsBitmapCoord( refX, 0 ) );
				Func<int, int, double> value = (Setting.VectorMode)	? new Func<int, int, double>( data.GetU ) 
			                                                        : new Func<int, int, double>( data.GetZ );
				for( int j=0; j<data.Rows; j++ )
				{
					int h = (int)(value( Setting.ReferenceI, j )/this.Setting.ReferredLength*Setting.Scale + 0.5);
					Point gridPt = canvas.AsBitmapCoord( refX, data.GetY( j ) );
					pt.Add( new Point( gridPt.X+h, gridPt.Y ) );
				}
				pt.Add( canvas.AsBitmapCoord( refX, 1 ) );
				g.DrawLines( linePen, pt.ToArray() );
				int s = Setting.PlotSize;
				for( int i=1; i<pt.Count-1; i++ )
				{
					g.FillEllipse( plotBlush, pt[i].X - s/2, pt[i].Y - s/2, s, s );
					g.DrawEllipse( plotPen, pt[i].X - s/2, pt[i].Y - s/2, s, s );
				}
			}
		}
	}
}
