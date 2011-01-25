using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Visualization;

namespace Conta
{
	public partial class ArrowDialog : Form
	{
		VectorSetting previewSetting;

		VectorSetting set;

		public ArrowDialog( VectorSetting setting )
		{
			InitializeComponent();

			this.previewSetting = new VectorSetting();
			this.set = setting;
		}

		private void ArrowDialog_Load( object sender, EventArgs e )
		{
			this.textBoxLength.Text = this.set.Length.ToString();
			this.textBoxTipAngle.Text = this.set.TipAngle.ToString();
			this.textBoxTipLength.Text = this.set.TipLength.ToString();
			switch( this.set.TipType )
			{
			case TipType.FillTriangle:
				this.radioButtonTrAnglArrow.Checked = true;
				break;
			case TipType.LineTip:
				this.radioButtonLineArrow.Checked = true;
				break;
			default:
				throw new NotImplementedException();
			}
			this.colorDialogInner.Color = this.panelInnerColor.BackColor = this.set.InnerColor;
			this.colorDialogLine.Color = this.panelLineColor.BackColor = this.set.LineColor;
			this.checkBoxColorful.Checked = this.set.Colorful;
			this.checkBoxFixTip.Checked = this.set.FixTipSize;
		}

		private void ArrowDialog_FormClosing( object sender, FormClosingEventArgs e )
		{
			if( this.DialogResult == DialogResult.OK )
			{
				try
				{
					this.set.Length = int.Parse( this.textBoxLength.Text );
					this.set.TipAngle = int.Parse( this.textBoxTipAngle.Text );
					this.set.TipLength = int.Parse( this.textBoxTipLength.Text );
				}
				catch( FormatException fe )
				{
					MessageBox.Show( fe.Message );
					e.Cancel = true;
				}
				if( this.radioButtonLineArrow.Checked )
				{
					this.set.TipType = TipType.LineTip;
				}
				else
				{
					this.set.TipType = TipType.FillTriangle;
				}
				this.set.LineWidth = (float)this.numericUpDownLineWidth.Value;
				this.set.InnerColor = this.panelInnerColor.BackColor;
				this.set.LineColor = this.panelLineColor.BackColor;
				this.set.Colorful = this.checkBoxColorful.Checked;
				this.set.FixTipSize = this.checkBoxFixTip.Checked;
			}
		}

		private void panelLineColor_Click( object sender, EventArgs e )
		{
			DialogResult dr = this.colorDialogLine.ShowDialog();
			if( dr == DialogResult.OK )
			{
				this.previewSetting.LineColor = this.panelLineColor.BackColor = this.colorDialogLine.Color;
			}
			this.Invalidate( true );
		}

		private void panelInnerColor_Click( object sender, EventArgs e )
		{
			DialogResult dr = this.colorDialogInner.ShowDialog();
			if( dr == DialogResult.OK )
			{
				this.previewSetting.InnerColor = this.panelInnerColor.BackColor = this.colorDialogInner.Color;
			}
			this.Invalidate( true );
		}

		private void pictureBoxPreview_Paint( object sender, PaintEventArgs e )
		{
			Drawer d = new Drawer( e.Graphics, this.previewSetting, 1.5, 0 );
			for( int i=0; i<4; i++ )
			{
				for( int j=0; j<2; j++ )
				{
					double len = 1.5 - 0.3*i - 0.3*j;
					double angle = Math.Atan2( 0.25, 1.0 );
					d.DrawArrow( new PointF( i*70F+20F, 80F-j*40F ), len*Math.Cos( angle ), len*Math.Sin( angle ) );
				}
			}
		}

		private void radioButtonTrAnglArrow_Click( object sender, EventArgs e )
		{
			this.previewSetting.TipType = TipType.FillTriangle;
			this.Invalidate( true );
		}

		private void radioButtonLineArrow_Click( object sender, EventArgs e )
		{
			this.previewSetting.TipType = TipType.LineTip;
			this.Invalidate( true );
		}

		private void checkBoxFixTip_CheckedChanged( object sender, EventArgs e )
		{
			this.previewSetting.FixTipSize = this.checkBoxFixTip.Checked;
			this.Invalidate( true );
		}

		private void checkBoxColorful_CheckedChanged( object sender, EventArgs e )
		{
			this.previewSetting.Colorful = this.checkBoxColorful.Checked;
			this.Invalidate( true );
		}

		private void buttonOK_Click( object sender, EventArgs e )
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void buttonCancel_Click( object sender, EventArgs e )
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void textBoxLength_TextChanged( object sender, EventArgs e )
		{
			try
			{
				if( textBoxLength.Text == string.Empty ) return;
				this.previewSetting.Length = int.Parse( textBoxLength.Text );
				this.Invalidate( true );
			}
			catch( ArgumentOutOfRangeException )
			{
			}
			catch( FormatException ex )
			{
				MessageBox.Show( ex.Message );
			}
		}

		private void textBoxTipAngle_TextChanged( object sender, EventArgs e )
		{
			try
			{
				if( this.textBoxTipAngle.Text == string.Empty ) return;
				this.previewSetting.TipAngle = int.Parse( textBoxTipAngle.Text );
				this.Invalidate( true );
			}
			catch( ArgumentOutOfRangeException )
			{
			}
			catch( FormatException ex )
			{
				if( ex.Source != string.Empty ) MessageBox.Show( ex.Message );
			}
		}

		private void textBoxTipLength_TextChanged( object sender, EventArgs e )
		{
			try
			{
				if( this.textBoxTipLength.Text == string.Empty ) return;
				this.previewSetting.TipLength = int.Parse( textBoxTipLength.Text );
				this.Invalidate( true );
			}
			catch( ArgumentOutOfRangeException )
			{
			}
			catch( FormatException ex )
			{
				if( ex.Source != string.Empty ) MessageBox.Show( ex.Message );
			}
		}

		private void numericUpDownLineWidth_ValueChanged( object sender, EventArgs e )
		{
			try
			{
				this.previewSetting.LineWidth = (float)this.numericUpDownLineWidth.Value;
				this.Invalidate( true );
			}
			catch( ArgumentOutOfRangeException )
			{
			}
			catch( SystemException ex )
			{
				if( ex.Source != string.Empty ) MessageBox.Show( ex.Message );
			}
		}
	}
}
