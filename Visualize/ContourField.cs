using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Visualization
{
	class ContourField : Field
	{
		public ContourSetting Setting { get; private set; }

		public ContourField()
		{
			this.Setting = new ContourSetting();
		}

		/// <summary>
		/// 線形補間を行う静的メソッド
		/// </summary>
		/// <param name="x0">座標 0</param>
		/// <param name="x">補間したい位置</param>
		/// <param name="x1">座標 1</param>
		/// <param name="v0">座標 0 における値</param>
		/// <param name="v1">座標 1 における値</param>
		/// <returns>位置 x における線形補間された値</returns>
		private static double linearInterpolation( double x0, double x, double x1, double v0, double v1 )
		{
			return (x - x0) / (x1 - x0) * (v1 - v0) + v0;
		}

		/// <summary>
		/// バイリニア補間を行う静的メソッド
		/// </summary>
		/// <param name="x0">x 座標 0</param>
		/// <param name="x">補間したい位置の x 座標</param>
		/// <param name="x1">x 座標 1</param>
		/// <param name="y0">y 座標 0</param>
		/// <param name="y">補間したい位置の y 座標</param>
		/// <param name="y1">y 座標 1</param>
		/// <param name="vx0y0">x が 0、y が 0 の位置における値</param>
		/// <param name="vx0y1">x が 0、y が 1 の位置における値</param>
		/// <param name="vx1y0">x が 1、y が 0 の位置における値</param>
		/// <param name="vx1y1">x が 1、y が 1 の位置における値</param>
		/// <returns>位置 (x, y) における線形補間された値</returns>
		private static double bilinearInterpolation( double x0, double x, double x1, double y0, double y, double y1, double vx0y0, double vx0y1, double vx1y0, double vx1y1 )
		{
			return linearInterpolation( y0, y, y1,
				linearInterpolation( x0, x, x1, vx0y0, vx1y0 ),
				linearInterpolation( x0, x, x1, vx0y1, vx1y1 ) );
		}

		public override void DrawTo( Bitmap bmp, IDataSheet data )
		{
			if( !this.Setting.Show )
			{
				return;
			}
			if( this.Setting.AutoScaleColor )
			{
				this.Setting.MaxValue = data.MaxZ;
				this.Setting.MinValue = data.MinZ;
			}
			this.Setting.PropertyChanged = false;
			double max = this.Setting.MaxValue;
			double min = this.Setting.MinValue;
			BitmapData bd = bmp.LockBits( new Rectangle( 0, 0, bmp.Width, bmp.Height ), ImageLockMode.WriteOnly, bmp.PixelFormat );
			try
			{
				IntPtr scan0 = bd.Scan0;
				byte[] bytes = new byte[bmp.Width*bmp.Height*4];
				for( int i=0; i<bytes.Length; i+=4 )	// 白で初期化
				{
					bytes[i+0] = 255; // as B
					bytes[i+1] = 255; // as G
					bytes[i+2] = 255; // as R
					bytes[i+3] = 255; // as A
				}
				int width = bmp.Width - 2*Visualize.BmpMargin;	// コンターの幅
				int height = bmp.Height - 2*Visualize.BmpMargin;	// コンターの高さ

				double dataWidth = data.GetX( data.Columns - 1 ) - data.GetX( 0 );
				double dataHeight = data.GetY( data.Rows - 1 ) - data.GetY( 0 );

				double xRate = dataWidth / (width - 1);		// bmp 座標 → データ座標変換用
				double yRate = dataHeight / (height - 1);

				double newValue = 0;	// バイリニア補間されたデータ
				int index = 0;			// バイト配列アクセス用
				int hue = 0;			// 色相

				int dataYIndex = 0;

				for( int j=0; j<height; j++ )
				{
					index = 4*(((height+Visualize.BmpMargin)-1-j)*bmp.Width + Visualize.BmpMargin);
					double y = yRate*j;
					while( !(data.GetY( dataYIndex ) <= y && y <= data.GetY( dataYIndex+1 )) )
					{
						dataYIndex++;
					}
					double y0 = data.GetY( dataYIndex );
					double y1 = data.GetY( dataYIndex+1 );

					int dataXIndex = 0;

					for( int i=0; i<width; i++ )
					{
						// bilinear interporation
						double x = xRate*i;
						while( !(data.GetX( dataXIndex ) <= x && x <= data.GetX( dataXIndex+1 )) )
						{
							dataXIndex++;
						}
						double x0 = data.GetX( dataXIndex );
						double x1 = data.GetX( dataXIndex+1 );

						double vx0y0 = data.GetZ( dataXIndex, dataYIndex );
						double vx0y1 = data.GetZ( dataXIndex, dataYIndex+1 );
						double vx1y0 = data.GetZ( dataXIndex+1, dataYIndex );
						double vx1y1 = data.GetZ( dataXIndex+1, dataYIndex+1 );

						newValue = bilinearInterpolation( x0, x, x1, y0, y, y1, vx0y0, vx0y1, vx1y0, vx1y1 );

						hue = (int)((newValue - min) / (max - min) * 360.0);
						if( hue >= 360 ) hue = 359;
						if( hue < 0 ) hue = 0;
						bytes[index+0] = ColorBar.FromHue( hue ).B;
						bytes[index+1] = ColorBar.FromHue( hue ).G;
						bytes[index+2] = ColorBar.FromHue( hue ).R;
						bytes[index+3] = 255;		// as A
						index += 4;
					}
				}
				Marshal.Copy( bytes, 0, scan0, bytes.Length );
			}
			finally
			{
				bmp.UnlockBits( bd );
			}
		}
	}
}
