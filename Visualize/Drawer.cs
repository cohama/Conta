using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Visualization
{
	public class Drawer
	{
		private struct ArrowComponents
		{
			public PointF Zero;
			public PointF Tip;
			public PointF Left;
			public PointF Right;

			public ArrowComponents( PointF zero, PointF tip, PointF left, PointF right )
			{
				this.Zero = zero;
				this.Tip = tip;
				this.Left = left;
				this.Right = right;
			}
		}

		public VectorSetting Arrow { get; private set; }

		delegate Color ColorSetter( double scr );
		delegate ArrowComponents PointCalculator( PointF pt1, double u, double v, double tipSize );
		delegate void ArrowDrawer( ArrowComponents points );
		ColorSetter innerColorSetter;
		ColorSetter lineColorSetter;
		PointCalculator pointCalculator;
		ArrowDrawer arrowDrawer;
		Graphics G;
		readonly double maxValue;
		readonly double minValue;
		readonly double refValue;
		readonly double unitLength;
		readonly double magnitude;
		readonly double tipMagnitude;
		readonly double halfTipAngle;
		readonly double tan_halfTipAngle;
		readonly Pen linePen;
		readonly SolidBrush innerBrush;

		/// <summary>
		/// 新しいベクトル描画マネージャを作成します。
		/// </summary>
		/// <param name="g">グラフィックデバイス</param>
		/// <param name="arrow">矢印の設定オブジェクト</param>
		/// <param name="MaxValue">データの最大値</param>
		public Drawer( Graphics g, VectorSetting arrow, double MaxValue, double MinValue )
		{
			this.Arrow = arrow;
			this.G = g;

			this.maxValue = MaxValue;
			this.minValue = MinValue;
			this.refValue = arrow.ReferredLength;
			this.unitLength = 500/20.0;
			this.magnitude = this.Arrow.Length/100.0/this.refValue*this.unitLength*2;
			this.tipMagnitude = this.Arrow.TipLength/100.0*this.magnitude;
			this.halfTipAngle = arrow.TipAngle/180.0*Math.PI/2.0;
			this.tan_halfTipAngle = Math.Tan( this.halfTipAngle );
			this.linePen = new Pen( arrow.LineColor, arrow.LineWidth );
			this.innerBrush = new SolidBrush( arrow.InnerColor );

			switch( arrow.TipType )
			{
				case TipType.FillTriangle:
					this.arrowDrawer = this.drawTrAnglArrow;
					break;
				case TipType.LineTip:
					this.arrowDrawer = this.drawLineArrow;
					break;
				default:
					throw new NotImplementedException();
			}
			if( arrow.FixTipSize )
			{
				this.pointCalculator = this.calcFixPoints;
			}
			else
			{
				this.pointCalculator = this.calcVarPoints;
			}
			if( arrow.Colorful )
			{
				this.lineColorSetter = this.setColorfulColor;
				this.innerColorSetter = this.setColorfulColor;
			}
			else
			{
				this.lineColorSetter = this.setFixedPenColor;
				this.innerColorSetter = this.setFixedBrushColor;
			}
		}

		public void DrawArrow( PointF pt1, double u, double v )
		{
			double scr = Math.Sqrt( u*u + v*v );
			this.innerBrush.Color = this.innerColorSetter( scr );
			this.linePen.Color = this.lineColorSetter( scr );
			ArrowComponents points = this.pointCalculator( pt1, u, v, scr*this.tipMagnitude );
			this.arrowDrawer( points );
		}

		private Color setFixedBrushColor( double scr )
		{
			return this.Arrow.InnerColor;
		}

		private Color setFixedPenColor( double scr )
		{
			return this.Arrow.LineColor;
		}

		private Color setColorfulColor( double scr )
		{
			int hue = (int)((scr - this.minValue) / (this.maxValue - this.minValue) * 360.0);
			if( hue >= 360 ) hue = 359;
			if( hue < 0 ) hue = 0;
			return ColorBar.FromHue( hue );
		}

		private void drawTrAnglArrow( ArrowComponents pts )
		{
			G.DrawLine( this.linePen, pts.Zero, pts.Tip );
			G.FillPolygon( this.innerBrush, new[] { pts.Tip, pts.Left, pts.Right } );
			G.DrawPolygon( this.linePen, new[] { pts.Tip, pts.Left, pts.Right } );
		}

		private void drawLineArrow( ArrowComponents pts )
		{
			G.DrawLine( this.linePen, pts.Zero, pts.Tip );
			G.DrawLine( this.linePen, pts.Tip, pts.Left );
			G.DrawLine( this.linePen, pts.Tip, pts.Right );
		}

		private ArrowComponents calcVarPoints( PointF pt1, double u, double v, double tipSize )
		{
			double angle = Math.Atan2( -v, u );
			double scr = Math.Sqrt( u*u + v*v );
			double x = scr * Math.Cos( angle );
			double y = - scr * Math.Sin( angle );
			PointF centroid = new PointF( (float)(pt1.X + x*this.magnitude), (float)(pt1.Y - y*this.magnitude) );
			PointF p1 = new PointF();
			PointF p2 = new PointF();
			PointF p3 = new PointF();

			p1.X = (float)(centroid.X + 2.0/3.0*tipSize*x/scr);
			p1.Y = (float)(centroid.Y - 2.0/3.0*tipSize*y/scr);

			p2.X = (float)(p1.X - tipSize/Math.Cos( this.halfTipAngle )*Math.Cos( angle+this.halfTipAngle ));
			p2.Y = (float)(p1.Y - tipSize/Math.Cos( this.halfTipAngle )*Math.Sin( angle+this.halfTipAngle ));

			p3.X = (float)(p1.X - tipSize/Math.Cos( this.halfTipAngle )*Math.Cos( angle-this.halfTipAngle ));
			p3.Y = (float)(p1.Y - tipSize/Math.Cos( this.halfTipAngle )*Math.Sin( angle-this.halfTipAngle ));

			return new ArrowComponents( pt1, p1, p2, p3 );
		}

		private ArrowComponents calcFixPoints( PointF pt1, double u, double v, double tipSize )
		{
			return calcVarPoints( pt1, u, v, this.maxValue*tipMagnitude );
		}
	}
}
