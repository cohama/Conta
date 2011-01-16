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

		IDataSheet data;

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

			public void DrawTo( Bitmap bmp, IDataSheet data )
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

			this.data = new NonuniformDataSheet();
		}

		public void FromFile( string filename )
		{
			this.filename = filename;
			NonuniformDataSheet nudata = new NonuniformDataSheet();
			nudata.Read( this.filename );
			this.data = nudata;
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
