using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Conta
{
	public class SwitchButton : Button
	{
		private Image bkimgnormal;
		private bool _checked;

		public Image BkImgNormal
		{
			get { return this.bkimgnormal; }
			set { this.BackgroundImage = this.bkimgnormal = value; }
		}
		public Image BkImgSelected { get; set; }

		[Browsable( false )]
		public override Image BackgroundImage
		{
			get { return base.BackgroundImage; }
			set { base.BackgroundImage = value; }
		}



		[Browsable( false )]
		public bool Checked
		{
			get { return this._checked; }
			set
			{
				this._checked = value;
				if( this.Checked )
				{
					this.BackgroundImage = this.BkImgSelected;
				}
				else
				{
					this.BackgroundImage = this.BkImgNormal;
				}
			}
		}

		public event EventHandler SwitchTurnedOn;
		public event EventHandler SwitchTurnedOff;

		protected void SwitchOn( EventArgs e )
		{
			if( SwitchTurnedOn != null )
			{
				this.SwitchTurnedOn( this, e );
			}
		}

		protected void SwitchOff( EventArgs e )
		{
			if( SwitchTurnedOff != null )
			{
				this.SwitchTurnedOff( this, e );
			}
		}

		public SwitchButton()
		{
			this.InitializeComponent();
		}

		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// SwitchButton
			// 
			this.FlatAppearance.BorderSize = 0;
			this.Size = new System.Drawing.Size( 50, 50 );
			this.Click += new System.EventHandler( this.SwitchButton_Click );
			this.ResumeLayout( false );

		}

		private void SwitchButton_Click( object sender, EventArgs e )
		{
			this._checked = !this._checked;
			if( this.Checked )
			{
				this.BackgroundImage = this.BkImgSelected;
				this.SwitchOn( e );
			}
			else
			{
				this.BackgroundImage = this.BkImgNormal;
				this.SwitchOff( e );
			}
		}

	}
}
