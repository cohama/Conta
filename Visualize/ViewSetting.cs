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

	/// <summary>
	/// Conta における表示の設定を行うクラスです。
	/// </summary>
	public class ViewSetting
	{
		/// <summary>
		/// ビットマップの表示の仕方を取得、設定します。
		/// </summary>
		public FieldSizeMode FieldSizeMode { get; set; }

		public ViewSetting()
		{
		}
	}
}
