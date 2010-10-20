using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visualization
{
	public class ContourSetting : FieldSetting
	{
		#region プロパティの内部実装
		double _maxValue;
		double _minValue;
		bool _autoScaleColor;
		#endregion

		internal bool PropertyChanged { get; set; }
		/// <summary>
		/// カラーバーの最大値を表す数値を取得、設定します。
		/// </summary>
		public double MaxValue
		{
			get { return this._maxValue; }
			set
			{
				this._maxValue = value;
				this.PropertyChanged = true;
			}
		}
		/// <summary>
		/// カラーバーの最小値を表す数値を取得、設定します。
		/// </summary>
		public double MinValue
		{
			get { return this._minValue; }
			set
			{
				this._minValue = value;
				this.PropertyChanged = true;
			}
		}

		/// <summary>
		/// カラーバーの最大、最小値をデータの最大、最小値に合わせるかどうかを取得、設定します。
		/// </summary>
		public bool AutoScaleColor
		{
			get { return this._autoScaleColor; }
			set
			{
				this._autoScaleColor = value;
				this.PropertyChanged = true;
			}
		}

		public ContourSetting()
		{
			this.MaxValue = 1.0;
			this.MinValue = 0;
			this.AutoScaleColor = true;
		}
	}
}
