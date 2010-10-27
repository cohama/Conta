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

		public double GetX( int i ) { return x[i]; }
		public double GetY( int j ) { return y[j]; }
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
		public int Columns { get; private set; }
		public int Rows { get; private set; }
		public string FileName { get; private set; }
		public bool HasVectorData { get; private set; }
		public double AspectRatio { get { throw new NotImplementedException(); } }

		public NonuniformDataSheet()
		{
			this.MinZ = double.MaxValue;
			this.MinVector = double.MaxValue;
			this.MaxZ = double.MinValue;
			this.MaxVector = double.MaxValue;

			this.XColumn = 1;
			this.YColumn = 2;
			this.ZColumn = 3;
			this.UColumn = 4;
			this.ZColumn = 5;
		}

		public void Read( string filename )
		{
			this.initializeData( filename );
		}

		private void initializeData( string filename )
		{
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

			string[] firstLineParts = firstLine.Split( new[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries );
			string[] lastLineParts  = lastLine.Split( new[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries );

			if( firstLineParts.Length <= this.UColumn
			 && firstLineParts.Length <= this.VColumn )
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
				string message = "指定されたデータ列は存在しません。\r\n"
					+ firstLineParts.Length
					+ " までの数値を指定してください。";
				throw new DataFormatException( this.FileName, message, ex );
			}

			this.Columns = lastX + 1 - firstX;
			this.Rows = lastY +1 - firstY;

			this.x = new double[this.Columns];
			this.y = new double[this.Rows];
			this.z = new double[this.Columns, this.Rows];
			if( this.HasVectorData )
			{
				this.u = new double[this.Columns, this.Rows];
				this.v = new double[this.Columns, this.Rows];
			}
			return false;
		}

		private bool readAsFloatXY( string[] allLines, int commentOffset )
		{
			throw new NotImplementedException();
		}

		private void readAsFloatXYSlow( string[] allLines, int commentOffset )
		{
			throw new NotImplementedException();
		}

	}
}
