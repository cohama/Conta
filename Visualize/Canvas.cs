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

		public Canvas( int width, int height, double aspectRatio )
		{
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
