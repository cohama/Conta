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
	class ColorContour
	{
		internal double[][] scrData;	// スカラーデータ
		internal double[][] uData;	// x 方向のベクトル成分データ
		internal double[][] vData;	// y 方向のベクトル成分データ

		public bool HasVectorData { get; private set; }

		public int XNum { get { return this.scrData.Length; } }
		public int YNum { get { return this.scrData[0].Length; } }

		public double MaxValue { get; private set; }
		public double MinValue { get; private set; }

		public double AspectRatio { get; private set; }

		public int BmpWidth { get; private set; }
		public int BmpHeight { get; private set; }
		public int BmpMargin { get; private set; }

		private Padding bmpMargin;

		public Bitmap Bmp { get; private set; }

		public ColorContour()
			: this( 500, 500, 50 )
		{
		}

		public ColorContour( int width, int height, int margin )
		{
			this.MaxValue = double.MinValue;
			this.MinValue = double.MaxValue;

			this.BmpWidth = width;
			this.BmpHeight = height;
			this.BmpMargin = margin;
			this.bmpMargin = new Padding( margin );
			this.AspectRatio = (double)height/width;
		}

		public void ResizeBmp( int newWidth, int newHeight )
		{
			if( this.AspectRatio < 1.0 )
			{
				this.BmpWidth = newWidth;
				this.BmpHeight = (int)(newWidth / this.AspectRatio);
			}
			else
			{
				this.BmpWidth = (int)(newHeight * this.AspectRatio);
				this.BmpHeight  = newHeight;
			}
			this.Bmp = new Bitmap( this.BmpWidth, this.BmpHeight );
		}

		public void FromFile( string filename )
		{
			this.MaxValue = double.MinValue;
			this.MinValue = double.MaxValue;

			string[] allLines = File.ReadAllLines( filename );
			int commentOffset = 0;
			while( allLines[commentOffset][0] == '#' )	//	'#' はコメントアウト
			{
				commentOffset++;	// コメント行の数
			}

			string[] lastline = allLines[allLines.Length-1].Split( new[] { '\t', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries );
			int I = int.Parse( lastline[0] ) + 1;
			int J = int.Parse( lastline[1] ) + 1;
			this.AspectRatio = (double)I/(double)J;
			this.ResizeBmp( this.BmpWidth, this.BmpHeight );
			this.Bmp = new Bitmap( this.BmpWidth, this.BmpHeight );
			this.scrData = new double[I][];
			// ベクトルモード
			if( lastline.Length >= 5 )
			{
				this.HasVectorData = true;
				this.uData = new double[I][];
				this.vData = new double[I][];
				for( int i=0; i<I; i++ )
				{
					this.scrData[i] = new double[J];
					this.uData[i] = new double[J];
					this.vData[i] = new double[J];
					for( int j=0; j<J; j++ )
					{
						int index = J*i + j + commentOffset;
						string[] part = (allLines[index]).Split( new[] { '\t', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries );
						double dat = double.Parse( part[2] );
						double u = double.Parse( part[3] );
						double v = double.Parse( part[4] );
						if( dat > this.MaxValue ) this.MaxValue = dat;
						if( dat < this.MinValue ) this.MinValue = dat;
						this.scrData[i][j] = dat;
						this.uData[i][j] = u;
						this.vData[i][j] = v;
					}
				}
			}
			// スカラーモード
			else
			{
				this.HasVectorData = false;
				for( int i=0; i<I; i++ )
				{
					this.scrData[i] = new double[J];
					for( int j=0; j<J; j++ )
					{
						int index = J*i + j + commentOffset;
						string[] part = (allLines[index]).Split( new[] { '\t', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries );
						double dat = double.Parse( part[2] );
						if( dat > this.MaxValue ) this.MaxValue = dat;
						if( dat < this.MinValue ) this.MinValue = dat;
						this.scrData[i][j] = dat;
					}
				}
			}
		}

		[Obsolete( "これは遅い", true )]
		public void _FromFile( string filename )
		{
			this.MaxValue = double.MinValue;
			this.MinValue = double.MaxValue;

			string[] allLines = File.ReadAllLines( filename );
			List<int> xIndex = new List<int>();
			List<int> yIndex = new List<int>();
			List<double> zData = new List<double>();
			foreach( var line in allLines )
			{
				string[] part = line.Split( new char[] { '\t', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries );
				// 3 列未満なら読み飛ばす (コメントとして認識)
				if( part.Length < 3 )
				{
					break;
				}
				try
				{
					int x = int.Parse( part[0] );
					int y = int.Parse( part[1] );
					double data = double.Parse( part[2] );
					if( !xIndex.Exists( n => n == x ) ) xIndex.Add( x );
					if( !yIndex.Exists( n => n == y ) ) yIndex.Add( y );
					zData.Add( data );
				}
				catch( FormatException ex )
				{
					throw new FormatException( "フォーマットエラー", ex );
				}
			}
			if( xIndex.Count * yIndex.Count != allLines.Length )
			{
				throw new FormatException( "データが格子状でない" );
			}
			this.scrData = new double[xIndex.Max()-xIndex.Min()+1][];
			for( int i=0; i<scrData.Length; i++ )
			{
				this.scrData[i] = new double[yIndex.Max()-xIndex.Min()+1];
				for( int j=0; j<scrData[i].Length; j++ )
				{
					int index = xIndex[i] * scrData[0].Length + yIndex[j];
					this.scrData[i][j] = zData[index];
				}
			}
			var maxList =
				from d in this.scrData
				let max = d.Max()
				let min = d.Min()
				select new { max, min };
			this.MaxValue = maxList.Max( a => a.max );
			this.MinValue = maxList.Min( a => a.min );
		}

		public Bitmap CreateBmp()
		{
			return this.CreateBmp( this.MaxValue, this.MinValue );
		}

		public Bitmap CreateBmp( double max, double min )
		{
			BitmapData bd = Bmp.LockBits( new Rectangle( 0, 0, Bmp.Width, Bmp.Height ), ImageLockMode.WriteOnly, Bmp.PixelFormat );
			try
			{
				IntPtr scan0 = bd.Scan0;
				byte[] bytes = new byte[Bmp.Width*Bmp.Height*4];
				for( int i=0; i<bytes.Length; i+=4 )	// 白で初期化
				{
					bytes[i+0] = 255; // as B
					bytes[i+1] = 255; // as G
					bytes[i+2] = 255; // as R
					bytes[i+3] = 255; // as A
				}
				Padding margin = this.bmpMargin;
				int inW = this.Bmp.Width - margin.Horizontal;	// コンターの幅
				int inH = this.Bmp.Height - margin.Vertical;	// コンターの高さ

				double xRate = (double)(this.XNum - 1)/(inW - 1);		// データ座標 → ビットマップ座標の変換用
				double yRate = (double)(this.YNum - 1)/(inH - 1);
				double newValue = 0;	// バイリニア補間されたデータ
				int index = 0;			// バイト配列アクセス用
				int hue = 0;			// 色相

				for( int j=0; j<inH-1; j++ )
				{
					index = 4*( ((inH+margin.Top)-1-j)*Bmp.Width + margin.Left );
					double y = yRate*j;
					int l = (int)y;
					for( int i=0; i<inW-1; i++ )
					{
						// bilinear interporation
						double x = xRate*i;
						int k = (int)x;
						newValue = ((k+1)-x)*((l+1)-y)*scrData[k][l]
								 + ((k+1)-x)*(y-l)    *scrData[k][l+1]
								 + (x-k)    *((l+1)-y)*scrData[k+1][l]
								 + (x-k)    *(y-l)    *scrData[k+1][l+1];
						hue = (int)((newValue - min) / (max - min) * 360.0);
						if( hue >= 360 ) hue = 359;
						if( hue < 0 ) hue = 0;
						bytes[index+0] = ColorBar.FromHue( hue ).B;
						bytes[index+1] = ColorBar.FromHue( hue ).G;
						bytes[index+2] = ColorBar.FromHue( hue ).R;
						bytes[index+3] = 255;		// as A
						index += 4;
					}
					newValue = ((l+1)-y)*scrData[this.XNum-1][l]
							 + (y-l)    *scrData[this.XNum-1][l+1];
					hue = (int)((newValue - min) / (max - min) * 360.0);
					if( hue >= 360 ) hue = 359;
					if( hue < 0 ) hue = 0;
					bytes[index+0] = ColorBar.FromHue( hue ).B;
					bytes[index+1] = ColorBar.FromHue( hue ).G;
					bytes[index+2] = ColorBar.FromHue( hue ).R;
					bytes[index+3] = 255;		// as A
					index += 4;
				}
				index = 4*( margin.Top*(this.Bmp.Width) + margin.Left );
				for( int i=0; i<inW-1; i++ )
				{
					double x = xRate*i;
					int k = (int)x;
					newValue = ((k+1)-x)*scrData[k][this.YNum-1]
							 + (x-k)    *scrData[k+1][this.YNum-1];
					hue = (int)((newValue - min) / (max - min) * 360.0);
					if( hue >= 360 ) hue = 359;
					if( hue < 0 ) hue = 0;
					bytes[index+0] = ColorBar.FromHue( hue ).B;
					bytes[index+1] = ColorBar.FromHue( hue ).G;
					bytes[index+2] = ColorBar.FromHue( hue ).R;
					bytes[index+3] = 255;		// as A
					index += 4;
				}
				newValue = scrData[this.XNum-1][this.YNum-1];
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
				Bmp.UnlockBits( bd );
			}
			return this.Bmp;
		}

		public Bitmap CreateWhiteBmp()
		{
			BitmapData bd = Bmp.LockBits( new Rectangle( 0, 0, Bmp.Width, Bmp.Height ), ImageLockMode.WriteOnly, Bmp.PixelFormat );
			try
			{
				IntPtr scan0 = bd.Scan0;
				byte[] bytes = new byte[Bmp.Width*Bmp.Height*4];
				for( int i=0; i<bytes.Length; i+=4 )	// 白で初期化
				{
					bytes[i+0] = 255; // as B
					bytes[i+1] = 255; // as G
					bytes[i+2] = 255; // as R
					bytes[i+3] = 255; // as A
				}
				Marshal.Copy( bytes, 0, scan0, bytes.Length );
			}
			finally
			{
				Bmp.UnlockBits( bd );
			}
			return this.Bmp;
		}


	}
}
