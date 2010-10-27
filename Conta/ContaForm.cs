using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Visualization;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace Conta
{
	public partial class ContaForm : Form
	{
		Visualize vis;
		string filename;
		ArrowDialog arrowDlg;
		CrossViewColorDialog colorDlg;
		FileSeeker seek;

		int drawCount = 0;

		private void draw()
		{
			this.drawCount++;
			Debug.Write( "draw " );
			Debug.WriteLine( drawCount );
			if( this.filename == null )
			{
				return;
			}
			this.pictureBox.Image = this.vis.CreateBmp( this.panelBmp.Width-20, this.panelBmp.Height-20 );
			this.pictureBox.Width = this.pictureBox.Image.Width;
			this.pictureBox.Height = this.pictureBox.Image.Height;
			this.textBoxMaxColor.Text = this.vis.ContourSetting.MaxValue.ToString();
			this.textBoxMinColor.Text = this.vis.ContourSetting.MinValue.ToString();
			this.textBoxRefVectorLength.Text = this.vis.VectorSetting.ReferredLength.ToString();
			this.textBoxRefCrossView.Text = this.vis.CrossViewSetting.ReferredLength.ToString();
			this.Invalidate();
		}

		private void openFile()
		{
			this.Text = Path.GetFileName( this.filename );
			this.seek = new FileSeeker( this.filename );

			try
			{
				this.vis.FromFile( this.filename );
				this.numericUpDownX.Maximum = this.vis.I-1;
				this.numericUpDownY.Maximum = this.vis.J-1;
				this.switchButtonVector.Enabled
				= this.checkBoxVectorMode.Enabled = this.checkBoxVectorMode.Checked = this.vis.HasVectorData;
				if( !this.vis.HasVectorData )
				{
					this.vis.VectorSetting.Show = false;
					this.switchButtonVector.Checked = false;
				}
				this.draw();
				this.toolStripStatusLabel.Text = (this.vis.HasVectorData) ? "ベクトルデータ" : "スカラーデータ";
				this.toolStripStatusLabel.Text += " (" + this.vis.I.ToString() + "x" + this.vis.J.ToString() + ")";
			}
			catch( FormatException ex )
			{
				this.toolStripStatusLabel.Text = "このファイルは読み込めませんでした。" + ex.Message;
			}
			catch( Exception ex )
			{
				MessageBox.Show( ex.Message );
			}
		}

		public ContaForm()
		{
			InitializeComponent();
		}

		private void ContaForm_Load( object sender, EventArgs e )
		{
			this.Size = new Size( 652, 481 );

			this.vis = new Visualize( this.panelBmp.Height-20, this.panelBmp.Width-20 );

			this.arrowDlg = new ArrowDialog( this.vis.VectorSetting );
			this.colorDlg = new CrossViewColorDialog( this.vis.CrossViewSetting );
			this.seek = new FileSeeker();

			this.groupBoxContour.Visible = false;
			this.groupBoxVector.Visible = false;
			this.groupBoxCrossView.Visible = false;
			this.comboBoxSizeMode.SelectedIndex = 0;
			this.textBoxMinColor.DataBindings.Add( "Text", this.vis.ContourSetting, "MinValue" );
			this.textBoxMaxColor.DataBindings.Add( "Text", this.vis.ContourSetting, "MaxValue" );
			this.textBoxScale.DataBindings.Add( "Text", this.vis.CrossViewSetting, "Scale" );
			this.textBoxRefVectorLength.DataBindings.Add( "Text", this.vis.VectorSetting, "ReferredLength" );
			this.textBoxRefCrossView.DataBindings.Add( "Text", this.vis.CrossViewSetting, "ReferredLength" );
		}

		#region スイッチボタンのイベントハンドラ
		private void contourSwitchButton_Click( object sender, EventArgs e )
		{
			this.groupBoxContour.Visible = this.vis.ContourSetting.Show = switchButtonContour.Checked;
			this.draw();
		}

		private void vectorSwitchButton_Click( object sender, EventArgs e )
		{
			this.groupBoxVector.Visible = this.vis.VectorSetting.Show = switchButtonVector.Checked;
			this.draw();
		}

		private void switchButtonGridPoint_Click( object sender, EventArgs e )
		{
			this.vis.GripPointSetting.Show = switchButtonGridPoint.Checked;
			this.draw();
		}

		private void switchButtonCrossView_Click( object sender, EventArgs e )
		{
			this.groupBoxCrossView.Visible = this.vis.CrossViewSetting.Show = switchButtonCrossView.Checked;
			this.draw();
		}
		#endregion

		private void ContaForm_DragEnter( object sender, DragEventArgs e )
		{
			if( e.Data.GetDataPresent( DataFormats.FileDrop ) )
			{
				e.Effect = DragDropEffects.All;
			}
		}

		private void ContaForm_DragDrop( object sender, DragEventArgs e )
		{
			try
			{
				this.pictureBox.Focus();	// 検証イベントの発生が目的
				this.filename = ((string[])e.Data.GetData( DataFormats.FileDrop ))[0];
				this.openFile();
				this.Activate();
			}
			catch( Exception ex )
			{
				MessageBox.Show( ex.ToString() );
			}
		}

		private void buttonInvMax_Click( object sender, EventArgs e )
		{
			double data;
			if( double.TryParse( this.textBoxMaxColor.Text, out data ) )
			{
				this.vis.ContourSetting.MinValue = -data;
				this.textBoxMinColor.Text = (-data).ToString();
			}
		}

		private void buttonInvMin_Click( object sender, EventArgs e )
		{
			double data;
			if( double.TryParse( this.textBoxMinColor.Text, out data ) )
			{
				this.vis.ContourSetting.MaxValue = -data;
				this.textBoxMaxColor.Text = (-data).ToString();
			}
		}

		private void buttonArrowSet_Click( object sender, EventArgs e )
		{
			this.arrowDlg.ShowDialog();
			this.draw();
		}

		private void checkBoxAutoColor_CheckedChanged( object sender, EventArgs e )
		{
			this.vis.ContourSetting.AutoScaleColor = this.textBoxMaxColor.ReadOnly = this.textBoxMinColor.ReadOnly = checkBoxAutoColor.Checked;
			this.draw();
		}

		private void buttonRedraw_Click( object sender, EventArgs e )
		{
			this.draw();
		}

		private void buttonReopen_Click( object sender, EventArgs e )
		{
			this.openFile();
		}

		private void buttonLeft_Click( object sender, EventArgs e )
		{
			this.filename = this.seek.PreviousFile();
			this.openFile();
		}

		private void buttonRight_Click( object sender, EventArgs e )
		{
			this.filename = this.seek.NextFile();
			this.openFile();
		}

		private void buttonEdit_Click( object sender, EventArgs e )
		{
			Process.Start( this.filename );
		}

		private void ContaForm_ResizeEnd( object sender, EventArgs e )
		{
			this.draw();
			this.panelBmp.AutoScroll = false;	// こうしないとなんかバグる
			this.panelBmp.AutoScroll = true;
		}

		private FormWindowState oldState = FormWindowState.Normal;
		private void ContaForm_Resize( object sender, EventArgs e )
		{
			if( this.WindowState != FormWindowState.Minimized )
			{
				if( oldState != this.WindowState )
				{
					this.ContaForm_ResizeEnd( sender, e );
				}
				this.oldState = this.WindowState;
			}
		}

		private void comboBoxSizeMode_SelectedIndexChanged( object sender, EventArgs e )
		{
			this.vis.ViewSetting.FieldSizeMode = (FieldSizeMode)this.comboBoxSizeMode.SelectedIndex;
			this.draw();
		}

		private void numericUpDownX_ValueChanged( object sender, EventArgs e )
		{
			this.vis.CrossViewSetting.ReferenceI = (int)this.numericUpDownX.Value;
			this.draw();
		}

		private void numericUpDownY_ValueChanged( object sender, EventArgs e )
		{
			this.vis.CrossViewSetting.ReferenceJ = (int)this.numericUpDownY.Value;
			this.draw();
		}

		private void checkBoxHorizontal_CheckedChanged( object sender, EventArgs e )
		{
			this.vis.CrossViewSetting.Horizontal = this.numericUpDownY.Enabled = this.checkBoxHorizontal.Checked;
		}

		private void checkBoxHorizontal_Click( object sender, EventArgs e )
		{
			this.draw();
		}

		private void checkBoxVertical_CheckedChanged( object sender, EventArgs e )
		{
			this.vis.CrossViewSetting.Vertical = this.numericUpDownX.Enabled = this.checkBoxVertical.Checked;
		}

		private void checkBoxVertical_Click( object sender, EventArgs e )
		{
			this.draw();
		}

		private void textBoxScale_KeyDown( object sender, KeyEventArgs e )
		{
			if( e.KeyCode == Keys.Enter )
			{
				this.vis.CrossViewSetting.Scale = int.Parse( this.textBoxScale.Text );
				this.draw();
			}
		}

		private void checkBoxVectorMode_CheckedChanged( object sender, EventArgs e )
		{
			this.vis.CrossViewSetting.VectorMode = this.checkBoxVectorMode.Checked;
		}

		private void checkBoxVectorMode_Click( object sender, EventArgs e )
		{
			this.draw();
		}

		private void buttonColorSet_Click( object sender, EventArgs e )
		{
			this.colorDlg.ShowDialog();
			this.draw();
		}

		private void buttonToCenter_Click( object sender, EventArgs e )
		{
			this.numericUpDownX.Value = this.numericUpDownX.Maximum/2;
			this.numericUpDownY.Value = this.numericUpDownY.Maximum/2;
			this.draw();
		}

		private void numericUpDownInterval_ValueChanged( object sender, EventArgs e )
		{
			this.vis.VectorSetting.Interval = (int)this.numericUpDownInterval.Value;
			this.draw();
		}

		private void numericUpDownOffset_ValueChanged( object sender, EventArgs e )
		{
			this.vis.VectorSetting.Offset = (int)this.numericUpDownOffset.Value;
			this.draw();
		}

		private void checkBoxFixedBound_CheckedChanged( object sender, EventArgs e )
		{
			this.vis.VectorSetting.FixedBound = this.checkBoxFixedBound.Checked;
			this.draw();
		}

		private void buttonSaveBmp_Click( object sender, EventArgs e )
		{
			DialogResult dr = this.saveFileDialog.ShowDialog();
			if( dr  == DialogResult.OK )
			{
				this.pictureBox.Image.Save( this.saveFileDialog.FileName );
			}
		}

		private void checkBoxRefVector_CheckedChanged( object sender, EventArgs e )
		{
			this.vis.VectorSetting.IsLengthFixed = this.checkBoxRefVector.Checked;
			this.textBoxRefVectorLength.ReadOnly = !this.checkBoxRefVector.Checked;
			this.draw();
		}

		private void checkBoxRefCrossView_CheckedChanged( object sender, EventArgs e )
		{
			this.vis.CrossViewSetting.IsLengthFixed = this.checkBoxRefCrossView.Checked;
			this.textBoxRefCrossView.ReadOnly = !this.checkBoxRefCrossView.Checked;
			this.draw();
		}
	}
}
