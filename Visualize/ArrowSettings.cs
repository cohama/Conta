using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Visualization
{
	public class ArrowSettings
	{
		TipType _tip;
		int _length;
		int _tipLength;
		int _tipAngle;

		bool _fixTipSize;

		bool _colorful;
		Color _lineColor;
		Color _innerColor;

		public event EventHandler AnyPropertyChanged;

		public enum TipType
		{
			FillTriangle,
			LineTip,
		}
		public TipType Tip
		{
			get { return this._tip; }
			set
			{
				this._tip = value;
				this.AnyPropertyChanged( this, null );
			}
		}

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
				this.AnyPropertyChanged( this, null );
			}
		}
		public int TipLength
		{
			get { return this._tipLength; }
			set
			{
				if( value < 0)
				{
					throw new ArgumentOutOfRangeException( "負の値は無効です" );
				}
				this._tipLength = value;
				this.AnyPropertyChanged( this, null );
			}
		}
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
				this.AnyPropertyChanged( this, null );
			}
		}

		public bool FixTipSize
		{
			get { return this._fixTipSize; }
			set
			{
				this._fixTipSize = value;
				this.AnyPropertyChanged( this, null );
			}
		}

		public bool Colorful
		{
			get { return this._colorful; }
			set
			{
				this._colorful = value;
				this.AnyPropertyChanged( this, null );
			}
		}
		public Color LineColor
		{
			get { return this._lineColor; }
			set
			{
				this._lineColor = value;
				this.AnyPropertyChanged( this, null );
			}
		}
		public Color InnerColor
		{
			get { return this._innerColor; }
			set
			{
				this._innerColor = value;
				this.AnyPropertyChanged( this, null );
			}
		}

		public ArrowSettings()
		{
			this.AnyPropertyChanged += ( sender, e ) => { };

			this.Tip = TipType.FillTriangle;
			this.Length = 100;
			this.TipLength = 40;
			this.TipAngle = 30;
			this.FixTipSize = false;
			this.Colorful = false;
			this.LineColor = Color.Black;
			this.InnerColor = Color.White;
		}

		public void CopyTo( ArrowSettings arrow )
		{
			arrow.Colorful = this.Colorful;
			arrow.FixTipSize = this.FixTipSize;
			arrow.InnerColor = this.InnerColor;
			arrow.Length = this.Length;
			arrow.LineColor = this.LineColor;
			arrow.Tip = this.Tip;
			arrow.TipAngle = this.TipAngle;
			arrow.TipLength = this.TipLength;
		}
	}
}
