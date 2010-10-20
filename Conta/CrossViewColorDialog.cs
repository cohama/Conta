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
	public partial class CrossViewColorDialog : Form
	{
		CrossViewSetting set;

		public CrossViewColorDialog( CrossViewSetting setting )
		{
			InitializeComponent();

			this.set = setting;
		}

		private void CrossViewColorDialog_Load( object sender, EventArgs e )
		{
			this.colorDialogAxis.Color = this.panelAxis.BackColor = this.set.AxisColor;
			this.colorDialogLine.Color = this.panelLine.BackColor = this.set.LineColor;
			this.colorDialogPlot.Color = this.panelPlot.BackColor = this.set.PlotColor;
			this.colorDialogPlotFrame.Color = this.panelPlotFrame.BackColor = this.set.PlotFrameColor;
		}

		private void CrossViewColorDialog_FormClosing( object sender, FormClosingEventArgs e )
		{
			if( this.DialogResult == DialogResult.OK )
			{
				this.set.AxisColor = this.panelAxis.BackColor;
				this.set.LineColor = this.panelLine.BackColor;
				this.set.PlotColor = this.panelPlot.BackColor;
				this.set.PlotFrameColor = this.panelPlotFrame.BackColor;
			}

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

		private void panelAxis_Click( object sender, EventArgs e )
		{
			DialogResult dr = this.colorDialogAxis.ShowDialog();
			if( dr == DialogResult.OK )
			{
				this.panelAxis.BackColor = this.colorDialogAxis.Color;
			}
		}

		private void panelLine_Click( object sender, EventArgs e )
		{
			DialogResult dr = this.colorDialogLine.ShowDialog();
			if( dr == DialogResult.OK )
			{
				this.panelLine.BackColor = this.colorDialogLine.Color;
			}
		}

		private void panelPlot_Click( object sender, EventArgs e )
		{
			DialogResult dr = this.colorDialogPlot.ShowDialog();
			if( dr == DialogResult.OK )
			{
				this.panelPlot.BackColor = this.colorDialogPlot.Color;
			}
		}

		private void panelPlotFrame_Click( object sender, EventArgs e )
		{
			DialogResult dr = this.colorDialogPlotFrame.ShowDialog();
			if( dr == DialogResult.OK )
			{
				this.panelPlotFrame.BackColor = this.colorDialogPlotFrame.Color;
			}
		}
	}
}
