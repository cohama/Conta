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
				int inW = bmp.Width - 2*Visualize.BmpMargin;	// コンターの幅
				int inH = bmp.Height - 2*Visualize.BmpMargin;	// コンターの高さ

				double xRate = (double)(data.Columns - 1)/(inW - 1);		// データ座標 → ビットマップ座標の変換用
				double yRate = (double)(data.Rows - 1)/(inH - 1);
				double newValue = 0;	// バイリニア補間されたデータ
				int index = 0;			// バイト配列アクセス用
				int hue = 0;			// 色相
				
				for( int j=0; j<inH-1; j++ )
				{
					index = 4*(((inH+Visualize.BmpMargin)-1-j)*bmp.Width + Visualize.BmpMargin);
					double y = yRate*j;
					int l = (int)y;
					for( int i=0; i<inW-1; i++ )
					{
						// bilinear interporation
						double x = xRate*i;
						int k = (int)x;
						newValue = ((k+1)-x)*((l+1)-y)*data.GetZ( k, l )
								 + ((k+1)-x)*(y-l)    *data.GetZ( k, l+1 )
								 + (x-k)    *((l+1)-y)*data.GetZ( k+1, l )
								 + (x-k)    *(y-l)    *data.GetZ( k+1, l+1 );
						hue = (int)((newValue - min) / (max - min) * 360.0);
						if( hue >= 360 ) hue = 359;
						if( hue < 0 ) hue = 0;
						bytes[index+0] = ColorBar.FromHue( hue ).B;
						bytes[index+1] = ColorBar.FromHue( hue ).G;
						bytes[index+2] = ColorBar.FromHue( hue ).R;
						bytes[index+3] = 255;		// as A
						index += 4;
					}
					newValue = ((l+1)-y)*data.GetZ( data.Columns-1, l )
							 + (y-l)    *data.GetZ( data.Columns-1, l+1 );
					hue = (int)((newValue - min) / (max - min) * 360.0);
					if( hue >= 360 ) hue = 359;
					if( hue < 0 ) hue = 0;
					bytes[index+0] = ColorBar.FromHue( hue ).B;
					bytes[index+1] = ColorBar.FromHue( hue ).G;
					bytes[index+2] = ColorBar.FromHue( hue ).R;
					bytes[index+3] = 255;		// as A
					index += 4;
				}
				index = 4*(Visualize.BmpMargin*bmp.Width + Visualize.BmpMargin);
				for( int i=0; i<inW-1; i++ )
				{
					double x = xRate*i;
					int k = (int)x;
					newValue = ((k+1)-x)*data.GetZ( k, data.Rows-1 )
							 + (x-k)    *data.GetZ( k+1, data.Rows-1 );
					hue = (int)((newValue - min) / (max - min) * 360.0);
					if( hue >= 360 ) hue = 359;
					if( hue < 0 ) hue = 0;
					bytes[index+0] = ColorBar.FromHue( hue ).B;
					bytes[index+1] = ColorBar.FromHue( hue ).G;
					bytes[index+2] = ColorBar.FromHue( hue ).R;
					bytes[index+3] = 255;		// as A
					index += 4;
				}
				newValue = data.GetZ( data.Columns-1, data.Rows-1 );
				hue = (int)((newValue - min) / (max - min) * 360.0);
				if( hue >= 360 ) hue = 359;
				if( hue < 0 ) hue = 0;
				bytes[index+0] = ColorBar.FromHue( hue ).B;
				bytes[index+1] = ColorBar.FromHue( hue ).G;
				bytes[index+2] = ColorBar.FromHue( hue ).R;
				bytes[index+3] = 255;		// as A

				Marshal.Copy( bytes, 0, scan0, bytes.Length );
			}
			finally
			{
				bmp.UnlockBits( bd );
			}
		}
	}
}
