namespace Conta
{
	partial class CrossViewColorDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( CrossViewColorDialog ) );
			this.labelAxis = new System.Windows.Forms.Label();
			this.labelLine = new System.Windows.Forms.Label();
			this.labelPlot = new System.Windows.Forms.Label();
			this.labelPlotFrame = new System.Windows.Forms.Label();
			this.panelPlotFrame = new System.Windows.Forms.Panel();
			this.panelPlot = new System.Windows.Forms.Panel();
			this.panelLine = new System.Windows.Forms.Panel();
			this.panelAxis = new System.Windows.Forms.Panel();
			this.colorDialogPlotFrame = new System.Windows.Forms.ColorDialog();
			this.colorDialogPlot = new System.Windows.Forms.ColorDialog();
			this.colorDialogLine = new System.Windows.Forms.ColorDialog();
			this.colorDialogAxis = new System.Windows.Forms.ColorDialog();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelAxis
			// 
			this.labelAxis.AutoSize = true;
			this.labelAxis.Location = new System.Drawing.Point( 59, 32 );
			this.labelAxis.Name = "labelAxis";
			this.labelAxis.Size = new System.Drawing.Size( 39, 12 );
			this.labelAxis.TabIndex = 0;
			this.labelAxis.Text = "軸の色";
			// 
			// labelLine
			// 
			this.labelLine.AutoSize = true;
			this.labelLine.Location = new System.Drawing.Point( 59, 68 );
			this.labelLine.Name = "labelLine";
			this.labelLine.Size = new System.Drawing.Size( 74, 12 );
			this.labelLine.TabIndex = 1;
			this.labelLine.Text = "グラフの線の色";
			// 
			// labelPlot
			// 
			this.labelPlot.AutoSize = true;
			this.labelPlot.Location = new System.Drawing.Point( 59, 104 );
			this.labelPlot.Name = "labelPlot";
			this.labelPlot.Size = new System.Drawing.Size( 74, 12 );
			this.labelPlot.TabIndex = 2;
			this.labelPlot.Text = "グラフの点の色";
			// 
			// labelPlotFrame
			// 
			this.labelPlotFrame.AutoSize = true;
			this.labelPlotFrame.Location = new System.Drawing.Point( 59, 140 );
			this.labelPlotFrame.Name = "labelPlotFrame";
			this.labelPlotFrame.Size = new System.Drawing.Size( 108, 12 );
			this.labelPlotFrame.TabIndex = 3;
			this.labelPlotFrame.Text = "グラフの点の枠線の色";
			// 
			// panelPlotFrame
			// 
			this.panelPlotFrame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelPlotFrame.Location = new System.Drawing.Point( 173, 132 );
			this.panelPlotFrame.Name = "panelPlotFrame";
			this.panelPlotFrame.Size = new System.Drawing.Size( 52, 23 );
			this.panelPlotFrame.TabIndex = 6;
			this.panelPlotFrame.Click += new System.EventHandler( this.panelPlotFrame_Click );
			// 
			// panelPlot
			// 
			this.panelPlot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelPlot.Location = new System.Drawing.Point( 173, 96 );
			this.panelPlot.Name = "panelPlot";
			this.panelPlot.Size = new System.Drawing.Size( 52, 23 );
			this.panelPlot.TabIndex = 7;
			this.panelPlot.Click += new System.EventHandler( this.panelPlot_Click );
			// 
			// panelLine
			// 
			this.panelLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelLine.Location = new System.Drawing.Point( 173, 60 );
			this.panelLine.Name = "panelLine";
			this.panelLine.Size = new System.Drawing.Size( 52, 23 );
			this.panelLine.TabIndex = 7;
			this.panelLine.Click += new System.EventHandler( this.panelLine_Click );
			// 
			// panelAxis
			// 
			this.panelAxis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelAxis.Location = new System.Drawing.Point( 173, 24 );
			this.panelAxis.Name = "panelAxis";
			this.panelAxis.Size = new System.Drawing.Size( 52, 23 );
			this.panelAxis.TabIndex = 7;
			this.panelAxis.Click += new System.EventHandler( this.panelAxis_Click );
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point( 167, 172 );
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size( 75, 23 );
			this.buttonCancel.TabIndex = 11;
			this.buttonCancel.Text = "&Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler( this.buttonCancel_Click );
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point( 43, 172 );
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size( 75, 23 );
			this.buttonOK.TabIndex = 10;
			this.buttonOK.Text = "&OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler( this.buttonOK_Click );
			// 
			// CrossViewColorDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 284, 215 );
			this.Controls.Add( this.buttonCancel );
			this.Controls.Add( this.buttonOK );
			this.Controls.Add( this.panelPlotFrame );
			this.Controls.Add( this.panelPlot );
			this.Controls.Add( this.panelLine );
			this.Controls.Add( this.panelAxis );
			this.Controls.Add( this.labelPlotFrame );
			this.Controls.Add( this.labelPlot );
			this.Controls.Add( this.labelLine );
			this.Controls.Add( this.labelAxis );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject( "$this.Icon" )));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CrossViewColorDialog";
			this.Text = "CrossViewColorDialog";
			this.Load += new System.EventHandler( this.CrossViewColorDialog_Load );
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.CrossViewColorDialog_FormClosing );
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelAxis;
		private System.Windows.Forms.Label labelLine;
		private System.Windows.Forms.Label labelPlot;
		private System.Windows.Forms.Label labelPlotFrame;
		private System.Windows.Forms.Panel panelPlotFrame;
		private System.Windows.Forms.Panel panelPlot;
		private System.Windows.Forms.Panel panelLine;
		private System.Windows.Forms.Panel panelAxis;
		private System.Windows.Forms.ColorDialog colorDialogPlotFrame;
		private System.Windows.Forms.ColorDialog colorDialogPlot;
		private System.Windows.Forms.ColorDialog colorDialogLine;
		private System.Windows.Forms.ColorDialog colorDialogAxis;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
	}
}