namespace Conta
{
	partial class ArrowDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( ArrowDialog ) );
			this.buttonOK = new System.Windows.Forms.Button();
			this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
			this.radioButtonLineArrow = new System.Windows.Forms.RadioButton();
			this.radioButtonTrAnglArrow = new System.Windows.Forms.RadioButton();
			this.colorDialogLine = new System.Windows.Forms.ColorDialog();
			this.colorDialogInner = new System.Windows.Forms.ColorDialog();
			this.panelLineColor = new System.Windows.Forms.Panel();
			this.panelInnerColor = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxLength = new System.Windows.Forms.TextBox();
			this.textBoxTipLength = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxTipAngle = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.checkBoxFixTip = new System.Windows.Forms.CheckBox();
			this.checkBoxColorful = new System.Windows.Forms.CheckBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.numericUpDownLineWidth = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLineWidth)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point( 71, 295 );
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size( 75, 23 );
			this.buttonOK.TabIndex = 1;
			this.buttonOK.Text = "&OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler( this.buttonOK_Click );
			// 
			// pictureBoxPreview
			// 
			this.pictureBoxPreview.BackColor = System.Drawing.Color.White;
			this.pictureBoxPreview.Location = new System.Drawing.Point( 12, 12 );
			this.pictureBoxPreview.Name = "pictureBoxPreview";
			this.pictureBoxPreview.Size = new System.Drawing.Size( 316, 100 );
			this.pictureBoxPreview.TabIndex = 4;
			this.pictureBoxPreview.TabStop = false;
			this.pictureBoxPreview.Paint += new System.Windows.Forms.PaintEventHandler( this.pictureBoxPreview_Paint );
			// 
			// radioButtonLineArrow
			// 
			this.radioButtonLineArrow.Appearance = System.Windows.Forms.Appearance.Button;
			this.radioButtonLineArrow.AutoSize = true;
			this.radioButtonLineArrow.Image = global::Conta.Properties.Resources.LineArrow;
			this.radioButtonLineArrow.Location = new System.Drawing.Point( 50, 146 );
			this.radioButtonLineArrow.Name = "radioButtonLineArrow";
			this.radioButtonLineArrow.Size = new System.Drawing.Size( 54, 23 );
			this.radioButtonLineArrow.TabIndex = 3;
			this.radioButtonLineArrow.TabStop = true;
			this.radioButtonLineArrow.UseVisualStyleBackColor = true;
			this.radioButtonLineArrow.Click += new System.EventHandler( this.radioButtonLineArrow_Click );
			// 
			// radioButtonTrAnglArrow
			// 
			this.radioButtonTrAnglArrow.Appearance = System.Windows.Forms.Appearance.Button;
			this.radioButtonTrAnglArrow.AutoSize = true;
			this.radioButtonTrAnglArrow.Image = global::Conta.Properties.Resources.TriangleArrow;
			this.radioButtonTrAnglArrow.Location = new System.Drawing.Point( 50, 124 );
			this.radioButtonTrAnglArrow.Name = "radioButtonTrAnglArrow";
			this.radioButtonTrAnglArrow.Size = new System.Drawing.Size( 54, 23 );
			this.radioButtonTrAnglArrow.TabIndex = 2;
			this.radioButtonTrAnglArrow.TabStop = true;
			this.radioButtonTrAnglArrow.UseVisualStyleBackColor = true;
			this.radioButtonTrAnglArrow.Click += new System.EventHandler( this.radioButtonTrAnglArrow_Click );
			// 
			// panelLineColor
			// 
			this.panelLineColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelLineColor.Location = new System.Drawing.Point( 220, 123 );
			this.panelLineColor.Name = "panelLineColor";
			this.panelLineColor.Size = new System.Drawing.Size( 52, 23 );
			this.panelLineColor.TabIndex = 5;
			this.panelLineColor.Click += new System.EventHandler( this.panelLineColor_Click );
			// 
			// panelInnerColor
			// 
			this.panelInnerColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelInnerColor.Location = new System.Drawing.Point( 220, 152 );
			this.panelInnerColor.Name = "panelInnerColor";
			this.panelInnerColor.Size = new System.Drawing.Size( 52, 23 );
			this.panelInnerColor.TabIndex = 6;
			this.panelInnerColor.Click += new System.EventHandler( this.panelInnerColor_Click );
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point( 146, 129 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 39, 12 );
			this.label1.TabIndex = 7;
			this.label1.Text = "線の色";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point( 146, 159 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size( 63, 12 );
			this.label2.TabIndex = 8;
			this.label2.Text = "三角形の色";
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point( 195, 295 );
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size( 75, 23 );
			this.buttonCancel.TabIndex = 9;
			this.buttonCancel.Text = "&Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler( this.buttonCancel_Click );
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point( 12, 189 );
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size( 71, 12 );
			this.label3.TabIndex = 10;
			this.label3.Text = "ベクトルの長さ";
			// 
			// textBoxLength
			// 
			this.textBoxLength.Location = new System.Drawing.Point( 89, 186 );
			this.textBoxLength.Name = "textBoxLength";
			this.textBoxLength.Size = new System.Drawing.Size( 46, 19 );
			this.textBoxLength.TabIndex = 11;
			this.textBoxLength.TextChanged += new System.EventHandler( this.textBoxLength_TextChanged );
			// 
			// textBoxTipLength
			// 
			this.textBoxTipLength.Location = new System.Drawing.Point( 89, 211 );
			this.textBoxTipLength.Name = "textBoxTipLength";
			this.textBoxTipLength.Size = new System.Drawing.Size( 46, 19 );
			this.textBoxTipLength.TabIndex = 13;
			this.textBoxTipLength.TextChanged += new System.EventHandler( this.textBoxTipLength_TextChanged );
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point( 12, 214 );
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size( 68, 12 );
			this.label4.TabIndex = 12;
			this.label4.Text = "先端の大きさ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point( 141, 214 );
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size( 11, 12 );
			this.label5.TabIndex = 15;
			this.label5.Text = "%";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point( 141, 189 );
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size( 11, 12 );
			this.label6.TabIndex = 14;
			this.label6.Text = "%";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point( 141, 237 );
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size( 11, 12 );
			this.label7.TabIndex = 18;
			this.label7.Text = "%";
			// 
			// textBoxTipAngle
			// 
			this.textBoxTipAngle.Location = new System.Drawing.Point( 89, 234 );
			this.textBoxTipAngle.Name = "textBoxTipAngle";
			this.textBoxTipAngle.Size = new System.Drawing.Size( 46, 19 );
			this.textBoxTipAngle.TabIndex = 17;
			this.textBoxTipAngle.TextChanged += new System.EventHandler( this.textBoxTipAngle_TextChanged );
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point( 12, 237 );
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size( 63, 12 );
			this.label8.TabIndex = 16;
			this.label8.Text = "先端の角度";
			// 
			// checkBoxFixTip
			// 
			this.checkBoxFixTip.AutoSize = true;
			this.checkBoxFixTip.Location = new System.Drawing.Point( 192, 189 );
			this.checkBoxFixTip.Name = "checkBoxFixTip";
			this.checkBoxFixTip.Size = new System.Drawing.Size( 139, 16 );
			this.checkBoxFixTip.TabIndex = 19;
			this.checkBoxFixTip.Text = "先端の大きさを固定する";
			this.checkBoxFixTip.UseVisualStyleBackColor = true;
			this.checkBoxFixTip.CheckedChanged += new System.EventHandler( this.checkBoxFixTip_CheckedChanged );
			// 
			// checkBoxColorful
			// 
			this.checkBoxColorful.AutoSize = true;
			this.checkBoxColorful.Location = new System.Drawing.Point( 192, 211 );
			this.checkBoxColorful.Name = "checkBoxColorful";
			this.checkBoxColorful.Size = new System.Drawing.Size( 122, 16 );
			this.checkBoxColorful.TabIndex = 20;
			this.checkBoxColorful.Text = "値によって色を変える";
			this.checkBoxColorful.UseVisualStyleBackColor = true;
			this.checkBoxColorful.CheckedChanged += new System.EventHandler( this.checkBoxColorful_CheckedChanged );
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point( 141, 262 );
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size( 17, 12 );
			this.label9.TabIndex = 23;
			this.label9.Text = "px";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point( 12, 262 );
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size( 47, 12 );
			this.label10.TabIndex = 21;
			this.label10.Text = "線の太さ";
			// 
			// numericUpDownLineWidth
			// 
			this.numericUpDownLineWidth.DecimalPlaces = 1;
			this.numericUpDownLineWidth.Increment = new decimal( new int[] {
            5,
            0,
            0,
            65536} );
			this.numericUpDownLineWidth.Location = new System.Drawing.Point( 89, 259 );
			this.numericUpDownLineWidth.Maximum = new decimal( new int[] {
            10,
            0,
            0,
            0} );
			this.numericUpDownLineWidth.Minimum = new decimal( new int[] {
            1,
            0,
            0,
            0} );
			this.numericUpDownLineWidth.Name = "numericUpDownLineWidth";
			this.numericUpDownLineWidth.Size = new System.Drawing.Size( 46, 19 );
			this.numericUpDownLineWidth.TabIndex = 24;
			this.numericUpDownLineWidth.Value = new decimal( new int[] {
            1,
            0,
            0,
            0} );
			this.numericUpDownLineWidth.ValueChanged += new System.EventHandler( this.numericUpDownLineWidth_ValueChanged );
			// 
			// ArrowDialog
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size( 340, 330 );
			this.Controls.Add( this.numericUpDownLineWidth );
			this.Controls.Add( this.label9 );
			this.Controls.Add( this.label10 );
			this.Controls.Add( this.checkBoxColorful );
			this.Controls.Add( this.checkBoxFixTip );
			this.Controls.Add( this.label7 );
			this.Controls.Add( this.textBoxTipAngle );
			this.Controls.Add( this.label8 );
			this.Controls.Add( this.label5 );
			this.Controls.Add( this.label6 );
			this.Controls.Add( this.textBoxTipLength );
			this.Controls.Add( this.label4 );
			this.Controls.Add( this.textBoxLength );
			this.Controls.Add( this.label3 );
			this.Controls.Add( this.buttonCancel );
			this.Controls.Add( this.label2 );
			this.Controls.Add( this.label1 );
			this.Controls.Add( this.panelInnerColor );
			this.Controls.Add( this.panelLineColor );
			this.Controls.Add( this.pictureBoxPreview );
			this.Controls.Add( this.radioButtonLineArrow );
			this.Controls.Add( this.radioButtonTrAnglArrow );
			this.Controls.Add( this.buttonOK );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject( "$this.Icon" )));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ArrowDialog";
			this.Text = "ArrowDialog";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.ArrowDialog_FormClosing );
			this.Load += new System.EventHandler( this.ArrowDialog_Load );
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLineWidth)).EndInit();
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.RadioButton radioButtonTrAnglArrow;
		private System.Windows.Forms.RadioButton radioButtonLineArrow;
		private System.Windows.Forms.PictureBox pictureBoxPreview;
		private System.Windows.Forms.ColorDialog colorDialogLine;
		private System.Windows.Forms.ColorDialog colorDialogInner;
		private System.Windows.Forms.Panel panelLineColor;
		private System.Windows.Forms.Panel panelInnerColor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxLength;
		private System.Windows.Forms.TextBox textBoxTipLength;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxTipAngle;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox checkBoxFixTip;
		private System.Windows.Forms.CheckBox checkBoxColorful;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.NumericUpDown numericUpDownLineWidth;

	}
}