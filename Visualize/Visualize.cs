using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Diagnostics;
using Visualization.Properties;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Visualization
{
	public class Visualize
	{
		static readonly Bitmap planeCanvas = Resources.PlaneCanvas;

		public static readonly int BmpMargin = 50;

		public int BmpWidth { get; private set; }
		public int BmpHeight { get; private set; }

		string filename;

		Bitmap canvas;

		DataSheet data;

		ContourField contour;
		VectorField vector;
		GridPointField gridPoint;
		CrossViewField crossView;

		class FieldCollection
		{
			List<Field> fields;

			public FieldCollection()
			{
				this.fields = new List<Field>();
			}

			public void Add( Field field )
			{
				this.fields.Add( field );
			}

			public void ForEach( Action<Field> action )
			{
				foreach( var field in this.fields )
				{
					action( field );
				}
			}

			public void DrawTo( Bitmap bmp, DataSheet data )
			{
				foreach( var field in this.fields )
				{
					field.DrawTo( bmp, data );
				}
			}
		}
		FieldCollection Fields { get; set; }

		public ViewSetting ViewSetting { get; private set; }

		public ContourSetting ContourSetting { get { return this.contour.Setting; } }
		public VectorSetting VectorSetting { get { return this.vector.Setting; } }
		public GridPointSetting GripPointSetting { get { return this.gridPoint.Setting; } }
		public CrossViewSetting CrossViewSetting { get { return this.crossView.Setting; } }

		public int I { get { return this.data.Columns; } }
		public int J { get { return this.data.Rows; } }

		public bool HasVectorData { get { return this.data.HasVectorData; } }

		public Visualize()
			: this( 500, 500 ) { }

		public Visualize( int width, int height )
		{
			this.ViewSetting = new ViewSetting();
			this.Fields = new FieldCollection();

			this.contour = new ContourField();
			this.vector = new VectorField();
			this.gridPoint = new GridPointField();
			this.crossView = new CrossViewField();

			this.Fields.Add( this.contour );
			this.Fields.Add( this.vector );
			this.Fields.Add( this.gridPoint );
			this.Fields.Add( this.crossView );

			this.BmpWidth = width;
			this.BmpHeight = height;
		}

		private Size resize( int width, int height )
		{
			int w;
			int h;
			switch( this.ViewSetting.FieldSizeMode )
			{
			case FieldSizeMode.Auto:
				if( this.data.AspectRatio < ((double)width/(double)height) )
				{
					w = (int)(height * data.AspectRatio);
					h = height;
				}
				else
				{
					w = width;
					h = (int)(width / data.AspectRatio);
				}
				break;

			case FieldSizeMode.HeightBase:
				w = (int)(height * data.AspectRatio);
				h = height;
				break;

			case FieldSizeMode.WidthBase:
				w = width;
				h = (int)(width / data.AspectRatio);
				break;

			default:
				throw new NotImplementedException();
			}
			return new Size( w, h );
		}

		public void FromFile( string filename )
		{
			this.filename = filename;
			this.data = new DataSheet( this.filename );
		}

		public Bitmap CreateBmp( int width, int height )
		{
			Size newSize = this.resize( width, height );
			this.BmpWidth = newSize.Width;
			this.BmpHeight = newSize.Height;
			this.canvas = new Bitmap( planeCanvas, BmpWidth, BmpHeight );
			this.Fields.DrawTo( this.canvas, this.data );
			return this.canvas;
		}
	}
}
