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
		public static readonly int BmpMargin = 50;

		public int BmpWidth { get; private set; }
		public int BmpHeight { get; private set; }

		string filename;

		Canvas canvas;

		NonuniformDataSheet data;

		ContourField contour;
		VectorField vector;
		GridPointField gridPoint;
		CrossViewField crossView;

		List<Field> fields;

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
			this.fields = new List<Field>();

			this.contour = new ContourField();
			this.vector = new VectorField();
			this.gridPoint = new GridPointField();
			this.crossView = new CrossViewField();

			this.fields.Add( this.contour );
			this.fields.Add( this.vector );
			this.fields.Add( this.gridPoint );
			this.fields.Add( this.crossView );

			this.BmpWidth = width;
			this.BmpHeight = height;

			this.data = new NonuniformDataSheet();
		}

		public void FromFile( string filename )
		{
			this.filename = filename;
			this.data.Read( this.filename );
		}

		public Bitmap CreateBmp( int width, int height )
		{
			this.canvas = new Canvas( width, height, this.data.AspectRatio, this.ViewSetting.FieldSizeMode, new Margin( 50 ) );
			foreach( var field in fields )
			{
				field.DrawTo( this.canvas.Bitmap, this.data );
			}
			return this.canvas.Bitmap;
		}
	}
}
