using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Visualization
{
	class NonuniformDataSheet : IDataSheet
	{
		private double[] x;
		private double[] y;
		private double[,] z;
		private double[,] u;
		private double[,] v;

		public double GetX( int i ) { return x[i] / (x[Columns-1] - x[0]); }
		public double GetRawX( int i ) { return x[i]; }
		public double GetY( int j ) { return y[j] / (y[Rows-1] - y[0]); }
		public double GetRawY( int j ) { return y[j]; }
		public double GetZ( int i, int j ) { return z[i, j]; }
		public double GetU( int i, int j ) { return u[i, j]; }
		public double GetV( int i, int j ) { return v[i, j]; }
		public double MaxZ { get; private set; }
		public double MinZ { get; private set; }
		public double MaxVector { get; private set; }
		public double MinVector { get; private set; }
		public int XColumn { get; private set; }
		public int YColumn { get; private set; }
		public int ZColumn { get; private set; }
		public int UColumn { get; private set; }
		public int VColumn { get; private set; }
		public int Columns { get { return this.x.Length; } }
		public int Rows { get { return this.y.Length; } }
		public string FileName { get; private set; }
		public bool HasVectorData { get; private set; }
		public double AspectRatio { get { return (x[Columns-1] - x[0]) / (y[Rows-1] - y[0]); } }

		public NonuniformDataSheet()
		{
			this.XColumn = 1;
			this.YColumn = 2;
			this.ZColumn = 3;
			this.UColumn = 4;
			this.VColumn = 5;
		}

		public void Read( string filename )
		{
			this.initializeData( filename );
		}

		private void initializeData( string filename )
		{
			this.MinZ = double.MaxValue;
			this.MinVector = double.MaxValue;
			this.MaxZ = double.MinValue;
			this.MaxVector = double.MinValue;
			this.HasVectorData = false;

			this.FileName = filename;
			string[] allLines = File.ReadAllLines( filename );
			int commentOffset = 0;

			while( allLines[commentOffset][0] == '#' )	//	'#' はコメントアウト
			{
				commentOffset++;	// コメント行の数
			}
			// 座標が整数の場合は高速読み込み
			if( !this.readAsIntXY( allLines, commentOffset ) )
			{	// に失敗したら高速実数読み込み
				if( !this.readAsFloatXY( allLines, commentOffset ) )
				{	//　にも失敗したら最も遅い実数読み込み
					this.readAsFloatXYSlow( allLines, commentOffset );
				}
			}
		}

		private bool readAsIntXY( string[] allLines, int commentOffset )
		{
			string firstLine = allLines[commentOffset];
			string lastLine  = allLines[allLines.Length - 1];

			string[] firstLineParts = splitToData( firstLine );
			string[] lastLineParts  = splitToData( lastLine );

			if( firstLineParts.Length < 3 )
			{
				throw new FileCouldNotReadException( "このファイルは読み込めませんでした。" );
			}

			if( firstLineParts.Length >= this.UColumn
			 && firstLineParts.Length >= this.VColumn )
			{
				this.HasVectorData = true;
			}

			bool judge = true;
			int firstX;
			int firstY;
			int lastX;
			int lastY;
			try
			{
				judge &= int.TryParse( firstLineParts[this.XColumn-1], out firstX );
				judge &= int.TryParse( firstLineParts[this.YColumn-1], out firstY );
				judge &= int.TryParse( lastLineParts[this.XColumn-1], out lastX );
				judge &= int.TryParse( lastLineParts[this.YColumn-1], out lastY );

				if( !judge )
				{	// parse に失敗
					return false;
				}
			}
			catch( IndexOutOfRangeException ex )
			{
				string message = "指定されたデータ列は存在しません。"
					+ firstLineParts.Length
					+ " までの数値を指定してください。";
				throw new DataColumnNotFoundException( this.FileName, message, ex );
			}

			int columns = lastX + 1 - firstX;
			int rows = lastY +1 - firstY;

			this.x = new double[columns];
			this.y = new double[rows];
			this.z = new double[this.Columns, this.Rows];
			if( this.HasVectorData )
			{
				this.u = new double[this.Columns, this.Rows];
				this.v = new double[this.Columns, this.Rows];
			}
			for( int i=0; i<this.Columns; i++ )
			{
				for( int j=-0; j<this.Rows; j++ )
				{
					int index = Rows*i + j + commentOffset;
					string[] parts = splitToData( allLines[index] );
					if( x[i] == 0 )
					{
						x[i] = double.Parse( parts[this.XColumn-1] );
					}
					if( y[j] == 0 )
					{
						y[j] = double.Parse( parts[this.YColumn-1] );
					}
					double z = double.Parse( parts[this.ZColumn-1] );
					this.z[i, j] = z;
					if( this.MaxZ < z ) this.MaxZ = z;
					if( this.MinZ > z ) this.MinZ = z;
					if( this.HasVectorData )
					{
						double u = double.Parse( parts[this.UColumn-1] );
						double v = double.Parse( parts[this.VColumn-1] );
						this.u[i, j] = u;
						this.v[i, j] = v;
						double length = Math.Sqrt( u*u + v*v );
						if( this.MaxVector < length ) this.MaxVector = length;
						if( this.MinVector > length ) this.MinVector = length;
					}
				}
			}
			return true;
		}

		private bool readAsFloatXY( string[] allLines, int commentOffset )
		{
			return false;
		}

		private void readAsFloatXYSlow( string[] allLines, int commentOffset )
		{
			HashSet<double> xSet = new HashSet<double>();
			HashSet<double> ySet = new HashSet<double>();

			string[] firstLineParts = splitToData( allLines[commentOffset] );
			if( firstLineParts.Length >= this.UColumn
			 && firstLineParts.Length >= this.VColumn )
			{
				this.HasVectorData = true;
			}

			// まず、x と y を算出する
			for( int index=commentOffset; index<allLines.Length; index++ )
			{
				string line = allLines[index];
				string[] parts = splitToData( line );
				xSet.Add( double.Parse( parts[this.XColumn-1] ) );
				ySet.Add( double.Parse( parts[this.YColumn-1] ) );
			}
			this.x = xSet.ToArray();
			this.y = ySet.ToArray();
			this.z = new double[this.Columns, this.Rows];
			if( this.HasVectorData )
			{
				this.u = new double[this.Columns, this.Rows];
				this.v = new double[this.Columns, this.Rows];
			}

			// 次にデータを取得する
			for( int i=0; i<this.Columns; i++ )
			{
				for( int j=0; j<this.Rows; j++ )
				{
					int index = Rows*i + j + commentOffset;
					string[] parts = splitToData( allLines[index] );
					double z = double.Parse( parts[this.ZColumn-1] );
					this.z[i, j] = z;
					if( this.MaxZ < z ) this.MaxZ = z;
					if( this.MinZ > z ) this.MinZ = z;
					if( this.HasVectorData )
					{
						double u = double.Parse( parts[this.UColumn-1] );
						double v = double.Parse( parts[this.VColumn-1] );
						this.u[i, j] = u;
						this.v[i, j] = v;
						double length = Math.Sqrt( u*u + v*v );
						if( this.MaxVector < length ) this.MaxVector = length;
						if( this.MinVector > length ) this.MinVector = length;
					}
				}
			}
		}

		private static string[] splitToData( string line )
		{
			return line.Split( new[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries );
		}
	}
}
