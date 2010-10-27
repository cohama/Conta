using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Visualization
{
	/// <summary>
	/// 2 次元のスカラーまたはベクトルの配列を管理するクラスです。
	/// </summary>
	class DataSheet : Visualization.IDataSheet
	{
		double[,] scr;
		double[,] u;
		double[,] v;
		double[] x;	// 座標データ
		double[] y; // 座標データ

		/// <summary>
		/// データの最大値を取得します。
		/// </summary>
		public double MaxZ { get; private set; }
		/// <summary>
		/// データの最小値を取得します。
		/// </summary>
		public double MinZ { get; private set; }

		/// <summary>
		/// データがベクトルデータを持っているかどうかを取得、設定します。
		/// </summary>
		public bool HasVectorData { get; set; }
		/// <summary>
		/// データの x 方向の要素数を取得します。
		/// </summary>
		public int Columns { get; private set; }
		/// <summary>
		/// データの y 方向の要素数を取得します。
		/// </summary>
		public int Rows { get; private set; }
		/// <summary>
		/// データの縦横比 (Columns/Rows) を取得します。
		/// </summary>
		public double AspectRatio { get; private set; }

		/// <summary>
		/// スカラーデータを取得します。
		/// </summary>
		/// <param name="i">x 方向のインデックス</param>
		/// <param name="j">y 方向のインデックス</param>
		/// <returns>(i, j) 点におけるスカラーデータ</returns>
		public double GetZ( int i, int j ) { return this.scr[i, j]; }
		/// <summary>
		/// ベクトルデータの u 成分 (x 方向成分) を取得します。
		/// </summary>
		/// <param name="i">x 方向のインデックス</param>
		/// <param name="j">y 方向のインデックス</param>
		/// <returns>(i, j) 点におけるベクトルの u 成分データ</returns>
		public double GetU( int i, int j ) { return this.u[i, j]; }
		/// <summary>
		/// ベクトルデータの v 成分 (y 方向成分) を取得します。		
		/// </summary>
		/// <param name="i">x 方向のインデックス</param>
		/// <param name="j">y 方向のインデックス</param>
		/// <returns>(i, j) 点におけるベクトルの v 成分データ</returns>
		public double GetV( int i, int j ) { return this.v[i, j]; }

		/// <summary>
		/// テキストファイルから 2 次元配列データを作成します。
		/// </summary>
		/// <param name="fileName">読み込むファイルのフルパス名</param>
		/// <exception cref="Visualization.DataFormatException">データフォーマットが不正の時に投げられます。</exception>
		public DataSheet( string fileName )
		{
			this.MaxZ = double.MinValue;
			this.MinZ = double.MaxValue;

			string[] allLines = File.ReadAllLines( fileName );
			int commentOffset = 0;
			while( allLines[commentOffset][0] == '#' )	//	'#' はコメントアウト
			{
				commentOffset++;	// コメント行の数
			}
			string[] firstLine = allLines[commentOffset].Split( new[] { '\t', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries );
			string[] lastline = allLines[allLines.Length-1].Split( new[] { '\t', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries );
			this.Columns = int.Parse( lastline[0] ) + 1 - int.Parse( firstLine[0] );
			this.Rows = int.Parse( lastline[1] ) + 1 - int.Parse( firstLine[1] );
			this.x = new double[this.Columns];
			this.y = new double[this.Rows];
			this.AspectRatio = (double)Columns/(double)Rows;
			this.scr = new double[Columns, Rows];
			// ベクトルモード
			try
			{
				if( lastline.Length >= 5 )
				{
					this.HasVectorData = true;
					this.u = new double[Columns, Rows];
					this.v = new double[Columns, Rows];
					for( int i=0; i<Columns; i++ )
					{
						for( int j=0; j<Rows; j++ )
						{
							int index = Rows*i + j + commentOffset;
							string[] part = (allLines[index]).Split( new[] { '\t', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries );
							if( this.x[i] == 0 )
							{
								this.x[i] = double.Parse( part[0] );
							}
							if( this.y[j] == 0 )
							{
								this.y[j] = double.Parse( part[1] );
							}
							double dat = double.Parse( part[2] );
							double u = double.Parse( part[3] );
							double v = double.Parse( part[4] );
							double length = Math.Sqrt( u*u + v*v );
							this.scr[i, j] = dat;
							this.u[i, j] = u;
							this.v[i, j] = v;
							if( length > this.MaxZ ) this.MaxZ = length;
							if( length < this.MinZ ) this.MinZ = length;
						}
					}
				}
				// スカラーモード
				else
				{
					this.HasVectorData = false;
					for( int i=0; i<Columns; i++ )
					{
						for( int j=0; j<Rows; j++ )
						{
							int index = Rows*i + j + commentOffset;
							string[] part = (allLines[index]).Split( new[] { '\t', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries );
							double dat = double.Parse( part[2] );
							this.scr[i, j] = dat;
							if( dat > this.MaxZ ) this.MaxZ = dat;
							if( dat < this.MinZ ) this.MinZ = dat;
						}
					}
				}
			}
			catch( FormatException fe ) { throw new DataFormatException( fileName, "フォーマットエラー", fe ); }
			catch( IndexOutOfRangeException ie ) { throw new DataFormatException( fileName, "フォーマットエラー", ie ); }
		}
	}
}
