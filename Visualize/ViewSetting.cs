using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Visualization
{
	/// <summary>
	/// ビットマップの表示の仕方を表します。
	/// </summary>
	public enum FieldSizeMode
	{
		/// <summary>
		/// ビットマップを既定の矩形内に収まるように自動調整します。
		/// </summary>
		Auto,
		/// <summary>
		/// 高さを固定してビットマップを表示します。
		/// </summary>
		HeightBase,
		/// <summary>
		/// 幅を固定してビットマップを表示します。
		/// </summary>
		WidthBase,
	}

	public struct Margin
	{
		public int Left;
		public int Right;
		public int Bottom;
		public int Top;

		public int Width { get { return this.Left + this.Right; } }
		public int Height { get { return this.Top + this.Bottom; } }

		public void SetAll( int value )
		{
			this.Left = this.Right = this.Bottom = this.Top = value;
		}

		public Margin( int value )
		{
			this.Left = this.Right = this.Bottom = this.Top = value;
		}

		public Margin( int left, int right, int bottom, int top )
		{
			this.Left = left;
			this.Right = right;
			this.Bottom = bottom;
			this.Top = top;
		}
	}

	/// <summary>
	/// Conta における表示の設定を行うクラスです。
	/// </summary>
	public class ViewSetting
	{
		/// <summary>
		/// ビットマップの表示の仕方を取得、設定します。
		/// </summary>
		public FieldSizeMode FieldSizeMode { get; set; }

		public Margin Margin { get; set; }

		public ViewSetting()
		{
			this.FieldSizeMode = Visualization.FieldSizeMode.Auto;
			this.Margin = new Margin( 4, 8, 16, 32 );
		}
	}
}
