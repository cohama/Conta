using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Visualization
{
	/// <summary>
	/// 断面分布ビューの設定を行います。
	/// </summary>
	public class CrossViewSetting : FieldSetting
	{
		/// <summary>
		/// 分布を表示する際に、長さの基準値を設定するかどうかを取得、設定します。
		/// </summary>
		public bool IsLengthFixed { get; set; }

		/// <summary>
		/// 断面分布を描画する際の基準となる長さを取得、設定します。
		/// </summary>
		public double ReferredLength { get; set; }

		/// <summary>
		/// x 方向の参照点のインデックスを取得、設定します。
		/// </summary>
		public int ReferenceI { get; set; }
		/// <summary>
		/// y 方向の参照点のインデックスを取得、設定します。
		/// </summary>
		public int ReferenceJ { get; set; }

		/// <summary>
		/// 拡大率を固定するかどうかを取得、設定します。
		/// </summary>
		public bool ScaleLock { get; set; }

		/// <summary>
		/// 拡大率 (パーセント) を取得、設定します。
		/// </summary>
		public int Scale { get; set; }

		/// <summary>
		/// 横方向の断面分布を表示するかどうかを取得、設定します。
		/// </summary>
		public bool Horizontal { get; set; }
		/// <summary>
		/// 縦方向の断面分布を表示するかどうかを取得、設定します。
		/// </summary>
		public bool Vertical { get; set; }

		/// <summary>
		/// 軸の色を取得、設定します。
		/// </summary>
		public Color AxisColor { get; set; }
		/// <summary>
		/// グラフの点の色を取得、設定します。
		/// </summary>
		public Color PlotColor { get; set; }
		/// <summary>
		/// グラフの点の枠の色を取得、設定します。
		/// </summary>
		public Color PlotFrameColor { get; set; }
		/// <summary>
		/// グラフの線の色を取得、設定します。
		/// </summary>
		public Color LineColor { get; set; }

		/// <summary>
		/// 軸の線の太さを取得、設定します。
		/// </summary>
		public float AxisWidth { get; set; }
		/// <summary>
		/// グラフの線の太さを取得、設定します。
		/// </summary>
		public float LineWidth { get; set; }
		/// <summary>
		/// グラフの点の大きさを取得、設定します。
		/// </summary>
		public int PlotSize { get; set; }

		/// <summary>
		/// ベクトルモードかどうかを取得、設定します。ベクトルモードの場合、縦軸には u 成分、横軸には v 成分をプロットします。
		/// </summary>
		public bool VectorMode { get; set; }

		public CrossViewSetting()
		{
			this.ReferredLength = 1.0;

			this.AxisColor = Color.Black;
			this.PlotColor = Color.White;
			this.PlotFrameColor = Color.Black;
			this.LineColor = Color.Black;

			this.AxisWidth = 2.0F;
			this.LineWidth = 1.5F;
			this.PlotSize = 4;

			this.Scale = 100;
		}
	}
}
