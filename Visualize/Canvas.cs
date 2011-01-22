using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Visualization.Properties;

namespace Visualization
{

	class Canvas
	{
		static readonly Bitmap PlaneCanvas = Resources.PlaneCanvas;

		public ViewSetting Setting { get; set; }

		public Bitmap Bitmap { get; private set; }

		public int Width { get { return this.Bitmap.Width; } }
		public int Height { get { return this.Bitmap.Height; } }

		public int DrawingWidth { get { return this.Width - this.Setting.Margin.Left - this.Setting.Margin.Right; } }
		public int DrawingHeight { get { return this.Height - this.Setting.Margin.Top - this.Setting.Margin.Bottom; } }

		/// <summary>
		/// 0.0 ～ 1.0 に正規化された座標からビットマップ座標におけるピクセルの位置を取得します。
		/// </summary>
		/// <param name="x">正規化された x 座標</param>
		/// <param name="y">正規化された y 座標</param>
		/// <returns>(x, y) に対応するピクセルの位置</returns>
		public Point AsBitmapCoord( double x, double y )
		{
			int originx = this.Setting.Margin.Left;
			int originy = this.Height - this.Setting.Margin.Bottom - 1;

			return new Point( originx + (int)(x*(DrawingWidth-1) + 0.5), originy - (int)(y*(DrawingHeight-1) + 0.5) );
		}

		public Canvas( int width, int height, double aspectRatio )
		{
			this.Setting = new ViewSetting();

			this.resize( width, height, aspectRatio );
		}

		private void resize( int width, int height, double aspectRatio )
		{
			int w;
			int h;

			switch( this.Setting.FieldSizeMode )
			{
				case FieldSizeMode.Auto:
					if( aspectRatio < (double)width / height )
					{
						w = (int)(height * aspectRatio);
						h = height;
					}
					else
					{
						w = width;
						h = (int)(width / aspectRatio);
					}
					break;

				case FieldSizeMode.HeightBase:
					w = (int)(height * aspectRatio);
					h = height;
					break;

				case FieldSizeMode.WidthBase:
					w = width;
					h = (int)(width / aspectRatio);
					break;

				default:
					throw new NotImplementedException();
			}

			this.Bitmap = new Bitmap( PlaneCanvas, w, h );
		}
	}
}
