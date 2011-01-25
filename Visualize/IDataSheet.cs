using System;
namespace Visualization
{
	interface IDataSheet
	{
		/// <summary>
		/// データのアスペクト比 (x/y) を取得します。
		/// </summary>
		double AspectRatio { get; }

		/// <summary>
		/// x 方向の格子点の数を取得します。
		/// </summary>
		int Columns { get; }

		/// <summary>
		/// 0.0 ～ 1.0 の間に正規化された x 方向座標を取得します。
		/// </summary>
		/// <param name="i">x 方向のインデックス</param>
		/// <returns>正規化された x 座標</returns>
		double GetX( int i );

		/// <summary>
		/// 0.0 ～ 1.0 の間に正規化された y 方向座標を取得します。
		/// </summary>
		/// <param name="j">y 方向のインデックス</param>
		/// <returns>正規化された y 座標</returns>
		double GetY( int j );

		/// <summary>
		/// 任意の格子点のスカラーデータを取得します。
		/// </summary>
		/// <param name="i">x 方向のインデックス</param>
		/// <param name="j">y 方向のインデックス</param>
		/// <returns>(i, j) 点におけるスカラーデータ</returns>
		double GetZ( int i, int j );

		/// <summary>
		/// 任意の格子点のベクトルデータの x 方向成分を取得します。
		/// </summary>
		/// <param name="i">x 方向のインデックス</param>
		/// <param name="j">y 方向のインデックス</param>
		/// <returns>(i, j) 点におけるベクトルの x 方向成分</returns>
		double GetU( int i, int j );

		/// <summary>
		/// 任意の格子点のベクトルデータの y 方向成分を取得します。
		/// </summary>
		/// <param name="i">x 方向のインデックス</param>
		/// <param name="j">y 方向のインデックス</param>
		/// <returns>(i, j) 点におけるベクトルの y 方向成分</returns>
		double GetV( int i, int j );

		/// <summary>
		/// このデータにベクトルデータが含まれるかどうかを取得します。
		/// </summary>
		bool HasVectorData { get; }

		/// <summary>
		/// スカラーデータの最大値を取得します。
		/// </summary>
		double MaxZ { get; }

		/// <summary>
		/// スカラーデータの最小値を取得します。
		/// </summary>
		double MinZ { get; }

		/// <summary>
		/// ベクトルデータの最大長さを取得します。
		/// </summary>
		double MaxVector { get; }

		/// <summary>
		/// ベクトルデータの最小長さを取得します。
		/// </summary>
		double MinVector { get; }

		/// <summary>
		/// y 方向の格子点の数を取得します。
		/// </summary>
		int Rows { get; }
	}
}
