using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Visualization
{
	/// <summary>
	/// 矢印の先端の種類を表します。
	/// </summary>
	public enum TipType
	{
		/// <summary>
		/// 単色で塗りつぶされた三角形
		/// </summary>
		FillTriangle,
		/// <summary>
		/// 枠線で囲まれた三角形
		/// </summary>
		LineTip,
	}

	/// <summary>
	/// ベクトル矢印の設定を行うためのクラスです。
	/// </summary>
	public class VectorSetting : FieldSetting
	{
		#region プロパティの内部実装
		int _length;
		int _tipLength;
		int _tipAngle;
		int _interval;
		int _offset;
		float _lineWidth;
		#endregion

		/// <summary>
		/// ベクトルを描画する際の基準となる長さを取得、設定します。
		/// </summary>
		public double ReferredLength { get; set; }

		/// <summary>
		/// ベクトルを描画する際に、長さの基準値を設定するかどうかを取得、設定します。
		/// </summary>
		public bool IsLengthFixed { get; set; }

		/// <summary>
		/// ベクトルの線の太さを取得、設定します。
		/// </summary>
		public float LineWidth
		{
			get { return this._lineWidth; }
			set
			{
				if( value < 1 || 10 < value )
				{
					throw new ArgumentOutOfRangeException( "線の太さは 1 から 10 の間で設定してください。" );
				}
				this._lineWidth = value;
			}
		}

		/// <summary>
		/// true なら、ベクトルを間引いて表示しても必ず端は描画します。
		/// </summary>
		public bool FixedBound { get; set; }

		/// <summary>
		/// ベクトルを間引いて表示する際のオフセットを取得、設定します。
		/// </summary>
		public int Offset
		{
			get { return this._offset; }
			set
			{
				if( value < 0 )
				{
					throw new ArgumentOutOfRangeException( "負の値は無効です" );
				}
				this._offset = value;
			}
		}

		/// <summary>
		/// ベクトルを描画する間隔を取得、設定します。2 以上なら間引いて描画します。
		/// </summary>
		public int Interval
		{
			get { return this._interval; }
			set
			{
				if( value <= 0 )
				{
					throw new ArgumentOutOfRangeException( "自然数を設定してください" );
				}
				this._interval = value;
			}
		}

		/// <summary>
		/// 矢印の先端の種類を取得、設定します。
		/// </summary>
		public TipType TipType { get; set; }

		/// <summary>
		/// ベクトルの長さを取得、設定します。
		/// </summary>
		public int Length
		{
			get { return this._length; }
			set
			{
				if( value < 0 )
				{
					throw new ArgumentOutOfRangeException( "負の値は無効です" );
				}
				this._length = value;
			}
		}
		/// <summary>
		/// ベクトルの矢印の大きさを取得、設定します。
		/// </summary>
		public int TipLength
		{
			get { return this._tipLength; }
			set
			{
				if( value < 0 )
				{
					throw new ArgumentOutOfRangeException( "負の値は無効です" );
				}
				this._tipLength = value;
			}
		}
		/// <summary>
		/// ベクトルの矢印の先端の開き角を取得、設定します。
		/// </summary>
		public int TipAngle
		{
			get { return this._tipAngle; }
			set
			{
				if( value >= 180 )
				{
					throw new ArgumentOutOfRangeException( "角度は 180°を越えられません" );
				}
				else if( value < 0 )
				{
					throw new ArgumentOutOfRangeException( "負の値は無効です" );
				}
				this._tipAngle = value;
			}
		}

		/// <summary>
		/// ベクトルの矢印の大きさを値によらず固定にするかどうかを取得、設定します。
		/// </summary>
		public bool FixTipSize { get; set; }

		/// <summary>
		/// ベクトルの色を値大きさによって変化させるかどうかを取得、設定します。
		/// </summary>
		public bool Colorful { get; set; }
		/// <summary>
		/// ベクトルの線の色を取得、設定します。
		/// </summary>
		public Color LineColor { get; set; }
		/// <summary>
		/// ベクトルの内部の色を取得、設定します。TipType プロパティが FillTriangle のときは値は反映されません。
		/// </summary>
		public Color InnerColor { get; set; }

		/// <summary>
		/// 新しい ArrowSettings クラスのインスタンスを作成します。
		/// </summary>
		public VectorSetting()
		{
			this.ReferredLength = 1.0;
			this.Interval = 1;
			this.Offset = 0;
			this.FixedBound = false;
			this.TipType = TipType.FillTriangle;
			this.Length = 100;
			this.TipLength = 40;
			this.TipAngle = 30;
			this.FixTipSize = false;
			this.Colorful = false;
			this.LineColor = Color.Black;
			this.InnerColor = Color.White;
		}

		/// <summary>
		/// 設定を別の ArrowSettings クラスへコピーします。
		/// </summary>
		/// <param name="arrow">コピー先の ArrowSettings クラス</param>
		public void CopyTo( VectorSetting arrow )
		{
			arrow.Colorful = this.Colorful;
			arrow.FixTipSize = this.FixTipSize;
			arrow.InnerColor = this.InnerColor;
			arrow.Length = this.Length;
			arrow.LineColor = this.LineColor;
			arrow.TipType = this.TipType;
			arrow.TipAngle = this.TipAngle;
			arrow.TipLength = this.TipLength;
		}
	}
}
