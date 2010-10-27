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

		public override void DrawTo( Bitmap bmp, IDataSheet data )
		{
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

			int mgn = Visualize.BmpMargin;
			double unitX = (double)(bmp.Width - 2*Visualize.BmpMargin - 1) / (data.Columns - 1);
			double unitY = (double)(bmp.Height- 2*Visualize.BmpMargin - 1) / (data.Rows - 1);

			SolidBrush plotBlush = new SolidBrush( Setting.PlotColor );
			Pen plotPen = new Pen( Setting.PlotFrameColor );
			Pen linePen = new Pen( Setting.LineColor, Setting.LineWidth );
			Pen axisPen = new Pen( Setting.AxisColor, Setting.AxisWidth );

			g.DrawRectangle( axisPen, mgn, mgn, bmp.Width-2*mgn-1, bmp.Height-2*mgn-1 );

			if( Setting.ReferenceI >= data.Columns ) Setting.ReferenceI = data.Columns - 1;
			if( Setting.ReferenceJ >= data.Rows ) Setting.ReferenceJ = data.Rows - 1;

			if( this.Setting.Horizontal )
			{
				int y = (int)(bmp.Height - 2*mgn - 1 - Setting.ReferenceJ*unitY + 0.5);
				g.DrawLine( axisPen, mgn, mgn+y, bmp.Width-mgn-1, mgn+y );
				Point[] pt = new Point[data.Columns];
				Func<int, int, double> value = (Setting.VectorMode)	? new Func<int, int, double>( data.GetV ) 
																	: new Func<int, int, double>( data.GetZ );
				for( int i=0; i<data.Columns; i++ )
				{
					int h = (int)(value( i, Setting.ReferenceJ )/this.Setting.ReferredLength*Setting.Scale + 0.5);
					int x = (int)(i*unitX + 0.5);
					pt[i] = new Point( mgn+x, mgn+y-h ); 
				}
				g.DrawLines( linePen, pt );
				int s = Setting.PlotSize;
				for( int i=0; i<data.Columns; i++ )
				{
					g.FillEllipse( plotBlush, pt[i].X - s/2, pt[i].Y - s/2, s, s );
					g.DrawEllipse( plotPen, pt[i].X - s/2, pt[i].Y - s/2, s, s );
				}

			}
			if( this.Setting.Vertical )
			{
				int x = (int)(Setting.ReferenceI*unitX + 0.5);
				g.DrawLine( axisPen, mgn + x, mgn, mgn + x, bmp.Height - mgn );
				Point[] pt = new Point[data.Rows];
				Func<int, int, double> value = (Setting.VectorMode)	? new Func<int, int, double>( data.GetU ) 
																	: new Func<int, int, double>( data.GetZ );
				for( int j=0; j<data.Rows; j++ )
				{
					int h = (int)(value( Setting.ReferenceI, j )/this.Setting.ReferredLength*Setting.Scale + 0.5);
					int y = (int)(bmp.Height - 2*mgn - 1 - j*unitY + 0.5);
					pt[j] = new Point( mgn+x+h, mgn+y );
				}
				g.DrawLines( linePen, pt );
				int s = Setting.PlotSize;
				for( int i=0; i<data.Rows; i++ )
				{
					g.FillEllipse( plotBlush, pt[i].X - s/2, pt[i].Y - s/2, s, s );
					g.DrawEllipse( plotPen, pt[i].X - s/2, pt[i].Y - s/2, s, s );
				}
			}


		}
	}
}
