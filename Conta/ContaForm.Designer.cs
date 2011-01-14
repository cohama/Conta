namespace Conta
{
	partial class ContaForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( ContaForm ) );
			this.panelSettings = new System.Windows.Forms.Panel();
			this.groupBoxCrossView = new System.Windows.Forms.GroupBox();
			this.checkBoxRefCrossView = new System.Windows.Forms.CheckBox();
			this.textBoxRefCrossView = new System.Windows.Forms.TextBox();
			this.buttonToCenter = new System.Windows.Forms.Button();
			this.buttonColorSet = new System.Windows.Forms.Button();
			this.labelScale = new System.Windows.Forms.Label();
			this.textBoxScale = new System.Windows.Forms.TextBox();
			this.checkBoxVectorMode = new System.Windows.Forms.CheckBox();
			this.checkBoxVertical = new System.Windows.Forms.CheckBox();
			this.checkBoxHorizontal = new System.Windows.Forms.CheckBox();
			this.labelY = new System.Windows.Forms.Label();
			this.labelX = new System.Windows.Forms.Label();
			this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
			this.groupBoxVector = new System.Windows.Forms.GroupBox();
			this.checkBoxRefVector = new System.Windows.Forms.CheckBox();
			this.textBoxRefVectorLength = new System.Windows.Forms.TextBox();
			this.checkBoxFixedBound = new System.Windows.Forms.CheckBox();
			this.labelOffset = new System.Windows.Forms.Label();
			this.labelInterval = new System.Windows.Forms.Label();
			this.numericUpDownOffset = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
			this.buttonArrowSet = new System.Windows.Forms.Button();
			this.groupBoxContour = new System.Windows.Forms.GroupBox();
			this.labelMin = new System.Windows.Forms.Label();
			this.panelColorBar = new System.Windows.Forms.Panel();
			this.buttonInvMin = new System.Windows.Forms.Button();
			this.textBoxMinColor = new System.Windows.Forms.TextBox();
			this.labelMax = new System.Windows.Forms.Label();
			this.buttonInvMax = new System.Windows.Forms.Button();
			this.textBoxMaxColor = new System.Windows.Forms.TextBox();
			this.checkBoxAutoColor = new System.Windows.Forms.CheckBox();
			this.groupBoxView = new System.Windows.Forms.GroupBox();
			this.comboBoxSizeMode = new System.Windows.Forms.ComboBox();
			this.groupBoxData2D = new System.Windows.Forms.GroupBox();
			this.groupBoxBasic = new System.Windows.Forms.GroupBox();
			this.buttonSaveBmp = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonReopen = new System.Windows.Forms.Button();
			this.buttonRight = new System.Windows.Forms.Button();
			this.buttonLeft = new System.Windows.Forms.Button();
			this.buttonRedraw = new System.Windows.Forms.Button();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
			this.表示vToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolTip = new System.Windows.Forms.ToolTip( this.components );
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.panelBmp = new System.Windows.Forms.Panel();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.textBoxRefVectorLength = new System.Windows.Forms.TextBox();
			this.checkBoxRefVector = new System.Windows.Forms.CheckBox();
			this.checkBoxRefCrossView = new System.Windows.Forms.CheckBox();
			this.textBoxRefCrossView = new System.Windows.Forms.TextBox();
			this.switchButtonCrossView = new Conta.SwitchButton();
			this.switchButtonGridPoint = new Conta.SwitchButton();
			this.switchButtonVector = new Conta.SwitchButton();
			this.switchButtonContour = new Conta.SwitchButton();
			this.panelSettings.SuspendLayout();
			this.groupBoxCrossView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
			this.groupBoxVector.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffset)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).BeginInit();
			this.groupBoxContour.SuspendLayout();
			this.groupBoxView.SuspendLayout();
			this.groupBoxData2D.SuspendLayout();
			this.groupBoxBasic.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.panelBmp.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// panelSettings
			// 
			this.panelSettings.AutoScroll = true;
			this.panelSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelSettings.Controls.Add( this.groupBoxCrossView );
			this.panelSettings.Controls.Add( this.groupBoxVector );
			this.panelSettings.Controls.Add( this.groupBoxContour );
			this.panelSettings.Controls.Add( this.groupBoxView );
			this.panelSettings.Controls.Add( this.groupBoxData2D );
			this.panelSettings.Controls.Add( this.groupBoxBasic );
			this.panelSettings.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelSettings.Location = new System.Drawing.Point( 400, 24 );
			this.panelSettings.Name = "panelSettings";
			this.panelSettings.Padding = new System.Windows.Forms.Padding( 3 );
			this.panelSettings.Size = new System.Drawing.Size( 236, 399 );
			this.panelSettings.TabIndex = 5;
			// 
			// groupBoxCrossView
			// 
			this.groupBoxCrossView.Controls.Add( this.checkBoxRefCrossView );
			this.groupBoxCrossView.Controls.Add( this.textBoxRefCrossView );
			this.groupBoxCrossView.Controls.Add( this.buttonToCenter );
			this.groupBoxCrossView.Controls.Add( this.buttonColorSet );
			this.groupBoxCrossView.Controls.Add( this.labelScale );
			this.groupBoxCrossView.Controls.Add( this.textBoxScale );
			this.groupBoxCrossView.Controls.Add( this.checkBoxVectorMode );
			this.groupBoxCrossView.Controls.Add( this.checkBoxVertical );
			this.groupBoxCrossView.Controls.Add( this.checkBoxHorizontal );
			this.groupBoxCrossView.Controls.Add( this.labelY );
			this.groupBoxCrossView.Controls.Add( this.labelX );
			this.groupBoxCrossView.Controls.Add( this.numericUpDownY );
			this.groupBoxCrossView.Controls.Add( this.numericUpDownX );
			this.groupBoxCrossView.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxCrossView.Location = new System.Drawing.Point( 3, 395 );
			this.groupBoxCrossView.Name = "groupBoxCrossView";
			this.groupBoxCrossView.Size = new System.Drawing.Size( 209, 118 );
			this.groupBoxCrossView.TabIndex = 12;
			this.groupBoxCrossView.TabStop = false;
			this.groupBoxCrossView.Text = "断面分布図の設定";
			// 
			// checkBoxRefCrossView
			// 
			this.checkBoxRefCrossView.AutoSize = true;
			this.checkBoxRefCrossView.Location = new System.Drawing.Point( 14, 93 );
			this.checkBoxRefCrossView.Name = "checkBoxRefCrossView";
			this.checkBoxRefCrossView.Size = new System.Drawing.Size( 93, 16 );
			this.checkBoxRefCrossView.TabIndex = 12;
			this.checkBoxRefCrossView.Text = "基準値を指定";
			this.checkBoxRefCrossView.UseVisualStyleBackColor = true;
			this.checkBoxRefCrossView.CheckedChanged += new System.EventHandler( this.checkBoxRefCrossView_CheckedChanged );
			// 
			// textBoxRefCrossView
			// 
			this.textBoxRefCrossView.Location = new System.Drawing.Point( 118, 91 );
			this.textBoxRefCrossView.Name = "textBoxRefCrossView";
			this.textBoxRefCrossView.ReadOnly = true;
			this.textBoxRefCrossView.Size = new System.Drawing.Size( 83, 19 );
			this.textBoxRefCrossView.TabIndex = 11;
			// 
			// buttonToCenter
			// 
			this.buttonToCenter.BackgroundImage = global::Conta.Properties.Resources.ToCenter;
			this.buttonToCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonToCenter.Location = new System.Drawing.Point( 141, 15 );
			this.buttonToCenter.Name = "buttonToCenter";
			this.buttonToCenter.Size = new System.Drawing.Size( 27, 27 );
			this.buttonToCenter.TabIndex = 10;
			this.toolTip.SetToolTip( this.buttonToCenter, "x と y を中心に設定" );
			this.buttonToCenter.UseVisualStyleBackColor = true;
			this.buttonToCenter.Click += new System.EventHandler( this.buttonToCenter_Click );
			// 
			// buttonColorSet
			// 
			this.buttonColorSet.Location = new System.Drawing.Point( 141, 42 );
			this.buttonColorSet.Name = "buttonColorSet";
			this.buttonColorSet.Size = new System.Drawing.Size( 62, 23 );
			this.buttonColorSet.TabIndex = 9;
			this.buttonColorSet.Text = "詳細設定";
			this.toolTip.SetToolTip( this.buttonColorSet, "グラフの色やプロットの設定を行います。" );
			this.buttonColorSet.UseVisualStyleBackColor = true;
			this.buttonColorSet.Click += new System.EventHandler( this.buttonColorSet_Click );
			// 
			// labelScale
			// 
			this.labelScale.AutoSize = true;
			this.labelScale.Location = new System.Drawing.Point( 128, 71 );
			this.labelScale.Name = "labelScale";
			this.labelScale.Size = new System.Drawing.Size( 29, 12 );
			this.labelScale.TabIndex = 8;
			this.labelScale.Text = "倍率";
			// 
			// textBoxScale
			// 
			this.textBoxScale.Location = new System.Drawing.Point( 163, 67 );
			this.textBoxScale.Name = "textBoxScale";
			this.textBoxScale.Size = new System.Drawing.Size( 38, 19 );
			this.textBoxScale.TabIndex = 7;
			this.toolTip.SetToolTip( this.textBoxScale, "値をどれくらいの長さで表すかの倍率です。" );
			this.textBoxScale.KeyDown += new System.Windows.Forms.KeyEventHandler( this.textBoxScale_KeyDown );
			// 
			// checkBoxVectorMode
			// 
			this.checkBoxVectorMode.AutoSize = true;
			this.checkBoxVectorMode.Location = new System.Drawing.Point( 14, 71 );
			this.checkBoxVectorMode.Name = "checkBoxVectorMode";
			this.checkBoxVectorMode.Size = new System.Drawing.Size( 88, 16 );
			this.checkBoxVectorMode.TabIndex = 6;
			this.checkBoxVectorMode.Text = "ベクトルモード";
			this.toolTip.SetToolTip( this.checkBoxVectorMode, "ベクトルモードのときは縦軸にU、横軸にVを表示します。" );
			this.checkBoxVectorMode.UseVisualStyleBackColor = true;
			this.checkBoxVectorMode.CheckedChanged += new System.EventHandler( this.checkBoxVectorMode_CheckedChanged );
			this.checkBoxVectorMode.Click += new System.EventHandler( this.checkBoxVectorMode_Click );
			// 
			// checkBoxVertical
			// 
			this.checkBoxVertical.AutoSize = true;
			this.checkBoxVertical.Location = new System.Drawing.Point( 14, 21 );
			this.checkBoxVertical.Name = "checkBoxVertical";
			this.checkBoxVertical.Size = new System.Drawing.Size( 60, 16 );
			this.checkBoxVertical.TabIndex = 5;
			this.checkBoxVertical.Text = "縦方向";
			this.toolTip.SetToolTip( this.checkBoxVertical, "縦に切った断面の分布を表示します。" );
			this.checkBoxVertical.UseVisualStyleBackColor = true;
			this.checkBoxVertical.CheckedChanged += new System.EventHandler( this.checkBoxVertical_CheckedChanged );
			this.checkBoxVertical.Click += new System.EventHandler( this.checkBoxVertical_Click );
			// 
			// checkBoxHorizontal
			// 
			this.checkBoxHorizontal.AutoSize = true;
			this.checkBoxHorizontal.Location = new System.Drawing.Point( 14, 46 );
			this.checkBoxHorizontal.Name = "checkBoxHorizontal";
			this.checkBoxHorizontal.Size = new System.Drawing.Size( 60, 16 );
			this.checkBoxHorizontal.TabIndex = 4;
			this.checkBoxHorizontal.Text = "横方向";
			this.toolTip.SetToolTip( this.checkBoxHorizontal, "横に切った断面の分布を表示します。" );
			this.checkBoxHorizontal.UseVisualStyleBackColor = true;
			this.checkBoxHorizontal.CheckedChanged += new System.EventHandler( this.checkBoxHorizontal_CheckedChanged );
			this.checkBoxHorizontal.Click += new System.EventHandler( this.checkBoxHorizontal_Click );
			// 
			// labelY
			// 
			this.labelY.AutoSize = true;
			this.labelY.Location = new System.Drawing.Point( 80, 47 );
			this.labelY.Name = "labelY";
			this.labelY.Size = new System.Drawing.Size( 11, 12 );
			this.labelY.TabIndex = 3;
			this.labelY.Text = "y";
			// 
			// labelX
			// 
			this.labelX.AutoSize = true;
			this.labelX.Location = new System.Drawing.Point( 80, 22 );
			this.labelX.Name = "labelX";
			this.labelX.Size = new System.Drawing.Size( 11, 12 );
			this.labelX.TabIndex = 2;
			this.labelX.Text = "x";
			// 
			// numericUpDownY
			// 
			this.numericUpDownY.Location = new System.Drawing.Point( 98, 45 );
			this.numericUpDownY.Maximum = new decimal( new int[] {
            999,
            0,
            0,
            0} );
			this.numericUpDownY.Name = "numericUpDownY";
			this.numericUpDownY.Size = new System.Drawing.Size( 37, 19 );
			this.numericUpDownY.TabIndex = 1;
			this.toolTip.SetToolTip( this.numericUpDownY, "データを参照する y 方向のインデックス" );
			this.numericUpDownY.ValueChanged += new System.EventHandler( this.numericUpDownY_ValueChanged );
			// 
			// numericUpDownX
			// 
			this.numericUpDownX.Location = new System.Drawing.Point( 98, 20 );
			this.numericUpDownX.Maximum = new decimal( new int[] {
            999,
            0,
            0,
            0} );
			this.numericUpDownX.Name = "numericUpDownX";
			this.numericUpDownX.Size = new System.Drawing.Size( 37, 19 );
			this.numericUpDownX.TabIndex = 0;
			this.toolTip.SetToolTip( this.numericUpDownX, "データを参照する x 方向のインデックス" );
			this.numericUpDownX.ValueChanged += new System.EventHandler( this.numericUpDownX_ValueChanged );
			// 
			// groupBoxVector
			// 
			this.groupBoxVector.Controls.Add( this.checkBoxRefVector );
			this.groupBoxVector.Controls.Add( this.textBoxRefVectorLength );
			this.groupBoxVector.Controls.Add( this.checkBoxFixedBound );
			this.groupBoxVector.Controls.Add( this.labelOffset );
			this.groupBoxVector.Controls.Add( this.labelInterval );
			this.groupBoxVector.Controls.Add( this.numericUpDownOffset );
			this.groupBoxVector.Controls.Add( this.numericUpDownInterval );
			this.groupBoxVector.Controls.Add( this.buttonArrowSet );
			this.groupBoxVector.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxVector.Location = new System.Drawing.Point( 3, 301 );
			this.groupBoxVector.Name = "groupBoxVector";
			this.groupBoxVector.Size = new System.Drawing.Size( 209, 94 );
			this.groupBoxVector.TabIndex = 11;
			this.groupBoxVector.TabStop = false;
			this.groupBoxVector.Text = "ベクトルの設定";
			// 
			// checkBoxRefVector
			// 
			this.checkBoxRefVector.AutoSize = true;
			this.checkBoxRefVector.Location = new System.Drawing.Point( 14, 71 );
			this.checkBoxRefVector.Name = "checkBoxRefVector";
			this.checkBoxRefVector.Size = new System.Drawing.Size( 93, 16 );
			this.checkBoxRefVector.TabIndex = 10;
			this.checkBoxRefVector.Text = "基準値を指定";
			this.checkBoxRefVector.UseVisualStyleBackColor = true;
			this.checkBoxRefVector.CheckedChanged += new System.EventHandler( this.checkBoxRefVector_CheckedChanged );
			// 
			// textBoxRefVectorLength
			// 
			this.textBoxRefVectorLength.Location = new System.Drawing.Point( 118, 69 );
			this.textBoxRefVectorLength.Name = "textBoxRefVectorLength";
			this.textBoxRefVectorLength.ReadOnly = true;
			this.textBoxRefVectorLength.Size = new System.Drawing.Size( 83, 19 );
			this.textBoxRefVectorLength.TabIndex = 9;
			// 
			// checkBoxFixedBound
			// 
			this.checkBoxFixedBound.AutoSize = true;
			this.checkBoxFixedBound.Location = new System.Drawing.Point( 14, 47 );
			this.checkBoxFixedBound.Name = "checkBoxFixedBound";
			this.checkBoxFixedBound.Size = new System.Drawing.Size( 111, 16 );
			this.checkBoxFixedBound.TabIndex = 8;
			this.checkBoxFixedBound.Text = "端は必ず描画する";
			this.toolTip.SetToolTip( this.checkBoxFixedBound, "ベクトルを間引いた場合でも、端のベクトルは常に描画するようにします。" );
			this.checkBoxFixedBound.UseVisualStyleBackColor = true;
			this.checkBoxFixedBound.CheckedChanged += new System.EventHandler( this.checkBoxFixedBound_CheckedChanged );
			// 
			// labelOffset
			// 
			this.labelOffset.AutoSize = true;
			this.labelOffset.Location = new System.Drawing.Point( 116, 20 );
			this.labelOffset.Name = "labelOffset";
			this.labelOffset.Size = new System.Drawing.Size( 47, 12 );
			this.labelOffset.TabIndex = 7;
			this.labelOffset.Text = "オフセット";
			// 
			// labelInterval
			// 
			this.labelInterval.AutoSize = true;
			this.labelInterval.Location = new System.Drawing.Point( 12, 20 );
			this.labelInterval.Name = "labelInterval";
			this.labelInterval.Size = new System.Drawing.Size( 53, 12 );
			this.labelInterval.TabIndex = 6;
			this.labelInterval.Text = "描画間隔";
			// 
			// numericUpDownOffset
			// 
			this.numericUpDownOffset.Location = new System.Drawing.Point( 169, 18 );
			this.numericUpDownOffset.Maximum = new decimal( new int[] {
            999,
            0,
            0,
            0} );
			this.numericUpDownOffset.Name = "numericUpDownOffset";
			this.numericUpDownOffset.Size = new System.Drawing.Size( 37, 19 );
			this.numericUpDownOffset.TabIndex = 5;
			this.toolTip.SetToolTip( this.numericUpDownOffset, "指定したインデックスのベクトルから描画を始めます。" );
			this.numericUpDownOffset.ValueChanged += new System.EventHandler( this.numericUpDownOffset_ValueChanged );
			// 
			// numericUpDownInterval
			// 
			this.numericUpDownInterval.Location = new System.Drawing.Point( 65, 18 );
			this.numericUpDownInterval.Maximum = new decimal( new int[] {
            999,
            0,
            0,
            0} );
			this.numericUpDownInterval.Minimum = new decimal( new int[] {
            1,
            0,
            0,
            0} );
			this.numericUpDownInterval.Name = "numericUpDownInterval";
			this.numericUpDownInterval.Size = new System.Drawing.Size( 37, 19 );
			this.numericUpDownInterval.TabIndex = 4;
			this.toolTip.SetToolTip( this.numericUpDownInterval, "指定した数値の分だけベクトルを間引きます。" );
			this.numericUpDownInterval.Value = new decimal( new int[] {
            1,
            0,
            0,
            0} );
			this.numericUpDownInterval.ValueChanged += new System.EventHandler( this.numericUpDownInterval_ValueChanged );
			// 
			// buttonArrowSet
			// 
			this.buttonArrowSet.Location = new System.Drawing.Point( 128, 43 );
			this.buttonArrowSet.Name = "buttonArrowSet";
			this.buttonArrowSet.Size = new System.Drawing.Size( 75, 23 );
			this.buttonArrowSet.TabIndex = 0;
			this.buttonArrowSet.Text = "矢印の設定";
			this.toolTip.SetToolTip( this.buttonArrowSet, "矢印の色や大きさなどの設定を行います。" );
			this.buttonArrowSet.UseVisualStyleBackColor = true;
			this.buttonArrowSet.Click += new System.EventHandler( this.buttonArrowSet_Click );
			// 
			// groupBoxContour
			// 
			this.groupBoxContour.Controls.Add( this.labelMin );
			this.groupBoxContour.Controls.Add( this.panelColorBar );
			this.groupBoxContour.Controls.Add( this.buttonInvMin );
			this.groupBoxContour.Controls.Add( this.textBoxMinColor );
			this.groupBoxContour.Controls.Add( this.labelMax );
			this.groupBoxContour.Controls.Add( this.buttonInvMax );
			this.groupBoxContour.Controls.Add( this.textBoxMaxColor );
			this.groupBoxContour.Controls.Add( this.checkBoxAutoColor );
			this.groupBoxContour.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxContour.Location = new System.Drawing.Point( 3, 183 );
			this.groupBoxContour.Name = "groupBoxContour";
			this.groupBoxContour.Size = new System.Drawing.Size( 209, 118 );
			this.groupBoxContour.TabIndex = 7;
			this.groupBoxContour.TabStop = false;
			this.groupBoxContour.Text = "カラーコンターの設定";
			// 
			// labelMin
			// 
			this.labelMin.AutoSize = true;
			this.labelMin.Location = new System.Drawing.Point( 6, 67 );
			this.labelMin.Name = "labelMin";
			this.labelMin.Size = new System.Drawing.Size( 23, 12 );
			this.labelMin.TabIndex = 2;
			this.labelMin.Text = "Min";
			// 
			// panelColorBar
			// 
			this.panelColorBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject( "panelColorBar.BackgroundImage" )));
			this.panelColorBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelColorBar.Location = new System.Drawing.Point( 14, 18 );
			this.panelColorBar.Name = "panelColorBar";
			this.panelColorBar.Size = new System.Drawing.Size( 180, 20 );
			this.panelColorBar.TabIndex = 0;
			// 
			// buttonInvMin
			// 
			this.buttonInvMin.Location = new System.Drawing.Point( 145, 63 );
			this.buttonInvMin.Name = "buttonInvMin";
			this.buttonInvMin.Size = new System.Drawing.Size( 56, 20 );
			this.buttonInvMin.TabIndex = 6;
			this.buttonInvMin.Text = "-Min";
			this.toolTip.SetToolTip( this.buttonInvMin, "最小値のマイナスを最大値にします。" );
			this.buttonInvMin.UseVisualStyleBackColor = true;
			this.buttonInvMin.Click += new System.EventHandler( this.buttonInvMin_Click );
			// 
			// textBoxMinColor
			// 
			this.textBoxMinColor.Location = new System.Drawing.Point( 7, 44 );
			this.textBoxMinColor.Name = "textBoxMinColor";
			this.textBoxMinColor.ReadOnly = true;
			this.textBoxMinColor.Size = new System.Drawing.Size( 84, 19 );
			this.textBoxMinColor.TabIndex = 0;
			// 
			// labelMax
			// 
			this.labelMax.AutoSize = true;
			this.labelMax.Location = new System.Drawing.Point( 116, 66 );
			this.labelMax.Name = "labelMax";
			this.labelMax.Size = new System.Drawing.Size( 26, 12 );
			this.labelMax.TabIndex = 3;
			this.labelMax.Text = "Max";
			// 
			// buttonInvMax
			// 
			this.buttonInvMax.Location = new System.Drawing.Point( 35, 63 );
			this.buttonInvMax.Name = "buttonInvMax";
			this.buttonInvMax.Size = new System.Drawing.Size( 56, 20 );
			this.buttonInvMax.TabIndex = 5;
			this.buttonInvMax.Text = "-Max";
			this.toolTip.SetToolTip( this.buttonInvMax, "最大値のマイナスを最小値にします。" );
			this.buttonInvMax.UseVisualStyleBackColor = true;
			this.buttonInvMax.Click += new System.EventHandler( this.buttonInvMax_Click );
			// 
			// textBoxMaxColor
			// 
			this.textBoxMaxColor.Location = new System.Drawing.Point( 118, 44 );
			this.textBoxMaxColor.Name = "textBoxMaxColor";
			this.textBoxMaxColor.ReadOnly = true;
			this.textBoxMaxColor.Size = new System.Drawing.Size( 84, 19 );
			this.textBoxMaxColor.TabIndex = 1;
			// 
			// checkBoxAutoColor
			// 
			this.checkBoxAutoColor.AutoSize = true;
			this.checkBoxAutoColor.Checked = true;
			this.checkBoxAutoColor.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxAutoColor.Location = new System.Drawing.Point( 68, 94 );
			this.checkBoxAutoColor.Name = "checkBoxAutoColor";
			this.checkBoxAutoColor.Size = new System.Drawing.Size( 72, 16 );
			this.checkBoxAutoColor.TabIndex = 4;
			this.checkBoxAutoColor.Text = "自動調整";
			this.toolTip.SetToolTip( this.checkBoxAutoColor, "色をデータの最大値と最小値に自動的に調整します。" );
			this.checkBoxAutoColor.UseVisualStyleBackColor = true;
			this.checkBoxAutoColor.CheckedChanged += new System.EventHandler( this.checkBoxAutoColor_CheckedChanged );
			// 
			// groupBoxView
			// 
			this.groupBoxView.Controls.Add( this.comboBoxSizeMode );
			this.groupBoxView.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxView.Location = new System.Drawing.Point( 3, 133 );
			this.groupBoxView.Name = "groupBoxView";
			this.groupBoxView.Size = new System.Drawing.Size( 209, 50 );
			this.groupBoxView.TabIndex = 7;
			this.groupBoxView.TabStop = false;
			this.groupBoxView.Text = "表示の設定";
			// 
			// comboBoxSizeMode
			// 
			this.comboBoxSizeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSizeMode.FormattingEnabled = true;
			this.comboBoxSizeMode.Items.AddRange( new object[] {
            "自動",
            "高さを基準にする",
            "幅を基準にする"} );
			this.comboBoxSizeMode.Location = new System.Drawing.Point( 47, 18 );
			this.comboBoxSizeMode.Name = "comboBoxSizeMode";
			this.comboBoxSizeMode.Size = new System.Drawing.Size( 121, 20 );
			this.comboBoxSizeMode.TabIndex = 0;
			this.comboBoxSizeMode.SelectedIndexChanged += new System.EventHandler( this.comboBoxSizeMode_SelectedIndexChanged );
			// 
			// groupBoxData2D
			// 
			this.groupBoxData2D.Controls.Add( this.switchButtonCrossView );
			this.groupBoxData2D.Controls.Add( this.switchButtonGridPoint );
			this.groupBoxData2D.Controls.Add( this.switchButtonVector );
			this.groupBoxData2D.Controls.Add( this.switchButtonContour );
			this.groupBoxData2D.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxData2D.Location = new System.Drawing.Point( 3, 61 );
			this.groupBoxData2D.Name = "groupBoxData2D";
			this.groupBoxData2D.Size = new System.Drawing.Size( 209, 72 );
			this.groupBoxData2D.TabIndex = 10;
			this.groupBoxData2D.TabStop = false;
			this.groupBoxData2D.Text = "2Dデータの表示";
			// 
			// groupBoxBasic
			// 
			this.groupBoxBasic.Controls.Add( this.buttonSaveBmp );
			this.groupBoxBasic.Controls.Add( this.buttonEdit );
			this.groupBoxBasic.Controls.Add( this.buttonReopen );
			this.groupBoxBasic.Controls.Add( this.buttonRight );
			this.groupBoxBasic.Controls.Add( this.buttonLeft );
			this.groupBoxBasic.Controls.Add( this.buttonRedraw );
			this.groupBoxBasic.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxBasic.Location = new System.Drawing.Point( 3, 3 );
			this.groupBoxBasic.Name = "groupBoxBasic";
			this.groupBoxBasic.Size = new System.Drawing.Size( 209, 58 );
			this.groupBoxBasic.TabIndex = 6;
			this.groupBoxBasic.TabStop = false;
			this.groupBoxBasic.Text = "基本操作";
			// 
			// buttonSaveBmp
			// 
			this.buttonSaveBmp.BackgroundImage = global::Conta.Properties.Resources.Save;
			this.buttonSaveBmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.buttonSaveBmp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonSaveBmp.Location = new System.Drawing.Point( 169, 18 );
			this.buttonSaveBmp.Margin = new System.Windows.Forms.Padding( 0, 3, 3, 3 );
			this.buttonSaveBmp.Name = "buttonSaveBmp";
			this.buttonSaveBmp.Size = new System.Drawing.Size( 32, 32 );
			this.buttonSaveBmp.TabIndex = 5;
			this.toolTip.SetToolTip( this.buttonSaveBmp, "画像ファイルとして保存する" );
			this.buttonSaveBmp.UseVisualStyleBackColor = true;
			this.buttonSaveBmp.Click += new System.EventHandler( this.buttonSaveBmp_Click );
			// 
			// buttonEdit
			// 
			this.buttonEdit.BackgroundImage = global::Conta.Properties.Resources.Edit;
			this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonEdit.Location = new System.Drawing.Point( 136, 18 );
			this.buttonEdit.Margin = new System.Windows.Forms.Padding( 0, 3, 3, 3 );
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size( 32, 32 );
			this.buttonEdit.TabIndex = 4;
			this.toolTip.SetToolTip( this.buttonEdit, "データファイルを開く" );
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler( this.buttonEdit_Click );
			// 
			// buttonReopen
			// 
			this.buttonReopen.BackgroundImage = global::Conta.Properties.Resources.Reopen;
			this.buttonReopen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonReopen.Location = new System.Drawing.Point( 40, 18 );
			this.buttonReopen.Name = "buttonReopen";
			this.buttonReopen.Size = new System.Drawing.Size( 32, 32 );
			this.buttonReopen.TabIndex = 3;
			this.toolTip.SetToolTip( this.buttonReopen, "再読み込み" );
			this.buttonReopen.UseVisualStyleBackColor = true;
			this.buttonReopen.Click += new System.EventHandler( this.buttonReopen_Click );
			// 
			// buttonRight
			// 
			this.buttonRight.BackgroundImage = global::Conta.Properties.Resources.RightButton;
			this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.buttonRight.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonRight.Location = new System.Drawing.Point( 104, 18 );
			this.buttonRight.Margin = new System.Windows.Forms.Padding( 0, 3, 3, 3 );
			this.buttonRight.Name = "buttonRight";
			this.buttonRight.Size = new System.Drawing.Size( 32, 32 );
			this.buttonRight.TabIndex = 2;
			this.toolTip.SetToolTip( this.buttonRight, "次のファイルへ" );
			this.buttonRight.UseVisualStyleBackColor = true;
			this.buttonRight.Click += new System.EventHandler( this.buttonRight_Click );
			// 
			// buttonLeft
			// 
			this.buttonLeft.BackgroundImage = global::Conta.Properties.Resources.LeftButton;
			this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.buttonLeft.Location = new System.Drawing.Point( 72, 18 );
			this.buttonLeft.Margin = new System.Windows.Forms.Padding( 3, 3, 0, 3 );
			this.buttonLeft.Name = "buttonLeft";
			this.buttonLeft.Size = new System.Drawing.Size( 32, 32 );
			this.buttonLeft.TabIndex = 1;
			this.toolTip.SetToolTip( this.buttonLeft, "前のファイルへ" );
			this.buttonLeft.UseVisualStyleBackColor = true;
			this.buttonLeft.Click += new System.EventHandler( this.buttonLeft_Click );
			// 
			// buttonRedraw
			// 
			this.buttonRedraw.BackgroundImage = global::Conta.Properties.Resources.Redraw;
			this.buttonRedraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonRedraw.Location = new System.Drawing.Point( 8, 18 );
			this.buttonRedraw.Name = "buttonRedraw";
			this.buttonRedraw.Size = new System.Drawing.Size( 32, 32 );
			this.buttonRedraw.TabIndex = 0;
			this.toolTip.SetToolTip( this.buttonRedraw, "再描画" );
			this.buttonRedraw.UseVisualStyleBackColor = true;
			this.buttonRedraw.Click += new System.EventHandler( this.buttonRedraw_Click );
			// 
			// menuStrip
			// 
			this.menuStrip.Location = new System.Drawing.Point( 0, 0 );
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size( 636, 24 );
			this.menuStrip.TabIndex = 6;
			this.menuStrip.Text = "menuStrip1";
			// 
			// toolStripMenuItemFile
			// 
			this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
			this.toolStripMenuItemFile.Size = new System.Drawing.Size( 85, 22 );
			this.toolStripMenuItemFile.Text = "ファイル(&F)";
			// 
			// 表示vToolStripMenuItem
			// 
			this.表示vToolStripMenuItem.Name = "表示vToolStripMenuItem";
			this.表示vToolStripMenuItem.Size = new System.Drawing.Size( 62, 22 );
			this.表示vToolStripMenuItem.Text = "表示(&V)";
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel} );
			this.statusStrip.Location = new System.Drawing.Point( 0, 423 );
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size( 636, 23 );
			this.statusStrip.TabIndex = 8;
			this.statusStrip.Text = "statusStrip1";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size( 320, 18 );
			this.toolStripStatusLabel.Text = "データファイルをドラッグアンドドロップしてください。";
			// 
			// panelBmp
			// 
			this.panelBmp.AutoScroll = true;
			this.panelBmp.AutoScrollMinSize = new System.Drawing.Size( 3, 3 );
			this.panelBmp.Controls.Add( this.pictureBox );
			this.panelBmp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBmp.Location = new System.Drawing.Point( 0, 24 );
			this.panelBmp.Name = "panelBmp";
			this.panelBmp.Size = new System.Drawing.Size( 400, 399 );
			this.panelBmp.TabIndex = 9;
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point( 0, 0 );
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size( 259, 279 );
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.Filter = "PNG ファイル|*.png|JPEG ファイル|*.jpg|ビットマップファイル|*.bmp|すべてのファイル|*.*";
			// 
			// textBoxRefVectorLength
			// 
			this.textBoxRefVectorLength.Location = new System.Drawing.Point( 118, 69 );
			this.textBoxRefVectorLength.Name = "textBoxRefVectorLength";
			this.textBoxRefVectorLength.ReadOnly = true;
			this.textBoxRefVectorLength.Size = new System.Drawing.Size( 83, 19 );
			this.textBoxRefVectorLength.TabIndex = 9;
			// 
			// checkBoxRefVector
			// 
			this.checkBoxRefVector.AutoSize = true;
			this.checkBoxRefVector.Location = new System.Drawing.Point( 14, 71 );
			this.checkBoxRefVector.Name = "checkBoxRefVector";
			this.checkBoxRefVector.Size = new System.Drawing.Size( 93, 16 );
			this.checkBoxRefVector.TabIndex = 10;
			this.checkBoxRefVector.Text = "基準値を指定";
			this.checkBoxRefVector.UseVisualStyleBackColor = true;
			this.checkBoxRefVector.CheckedChanged += new System.EventHandler( this.checkBoxRefVector_CheckedChanged );
			// 
			// checkBoxRefCrossView
			// 
			this.checkBoxRefCrossView.AutoSize = true;
			this.checkBoxRefCrossView.Location = new System.Drawing.Point( 14, 93 );
			this.checkBoxRefCrossView.Name = "checkBoxRefCrossView";
			this.checkBoxRefCrossView.Size = new System.Drawing.Size( 93, 16 );
			this.checkBoxRefCrossView.TabIndex = 12;
			this.checkBoxRefCrossView.Text = "基準値を指定";
			this.checkBoxRefCrossView.UseVisualStyleBackColor = true;
			this.checkBoxRefCrossView.CheckedChanged += new System.EventHandler( this.checkBoxRefCrossView_CheckedChanged );
			// 
			// textBoxRefCrossView
			// 
			this.textBoxRefCrossView.Location = new System.Drawing.Point( 118, 91 );
			this.textBoxRefCrossView.Name = "textBoxRefCrossView";
			this.textBoxRefCrossView.ReadOnly = true;
			this.textBoxRefCrossView.Size = new System.Drawing.Size( 83, 19 );
			this.textBoxRefCrossView.TabIndex = 11;
			// 
			// switchButtonCrossView
			// 
			this.switchButtonCrossView.BackgroundImage = global::Conta.Properties.Resources.CrossView;
			this.switchButtonCrossView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.switchButtonCrossView.BkImgNormal = global::Conta.Properties.Resources.CrossView;
			this.switchButtonCrossView.BkImgSelected = global::Conta.Properties.Resources.CrossView_Selected;
			this.switchButtonCrossView.Checked = false;
			this.switchButtonCrossView.FlatAppearance.BorderSize = 0;
			this.switchButtonCrossView.Location = new System.Drawing.Point( 156, 14 );
			this.switchButtonCrossView.Name = "switchButtonCrossView";
			this.switchButtonCrossView.Size = new System.Drawing.Size( 50, 50 );
			this.switchButtonCrossView.TabIndex = 7;
			this.toolTip.SetToolTip( this.switchButtonCrossView, "断面の分布" );
			this.switchButtonCrossView.UseVisualStyleBackColor = true;
			this.switchButtonCrossView.Click += new System.EventHandler( this.switchButtonCrossView_Click );
			// 
			// switchButtonGridPoint
			// 
			this.switchButtonGridPoint.BackgroundImage = global::Conta.Properties.Resources.GridPoint;
			this.switchButtonGridPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.switchButtonGridPoint.BkImgNormal = global::Conta.Properties.Resources.GridPoint;
			this.switchButtonGridPoint.BkImgSelected = global::Conta.Properties.Resources.GridPoint_Selected;
			this.switchButtonGridPoint.Checked = false;
			this.switchButtonGridPoint.FlatAppearance.BorderSize = 0;
			this.switchButtonGridPoint.Location = new System.Drawing.Point( 107, 14 );
			this.switchButtonGridPoint.Name = "switchButtonGridPoint";
			this.switchButtonGridPoint.Size = new System.Drawing.Size( 50, 50 );
			this.switchButtonGridPoint.TabIndex = 6;
			this.toolTip.SetToolTip( this.switchButtonGridPoint, "格子点" );
			this.switchButtonGridPoint.UseVisualStyleBackColor = true;
			this.switchButtonGridPoint.Click += new System.EventHandler( this.switchButtonGridPoint_Click );
			// 
			// switchButtonVector
			// 
			this.switchButtonVector.BackgroundImage = global::Conta.Properties.Resources.ColorVector;
			this.switchButtonVector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.switchButtonVector.BkImgNormal = global::Conta.Properties.Resources.ColorVector;
			this.switchButtonVector.BkImgSelected = global::Conta.Properties.Resources.ColorVector_Selected;
			this.switchButtonVector.Checked = false;
			this.switchButtonVector.FlatAppearance.BorderSize = 0;
			this.switchButtonVector.Location = new System.Drawing.Point( 57, 14 );
			this.switchButtonVector.Name = "switchButtonVector";
			this.switchButtonVector.Size = new System.Drawing.Size( 50, 50 );
			this.switchButtonVector.TabIndex = 4;
			this.toolTip.SetToolTip( this.switchButtonVector, "ベクトル図" );
			this.switchButtonVector.UseVisualStyleBackColor = true;
			this.switchButtonVector.Click += new System.EventHandler( this.vectorSwitchButton_Click );
			// 
			// switchButtonContour
			// 
			this.switchButtonContour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject( "switchButtonContour.BackgroundImage" )));
			this.switchButtonContour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.switchButtonContour.BkImgNormal = ((System.Drawing.Image)(resources.GetObject( "switchButtonContour.BkImgNormal" )));
			this.switchButtonContour.BkImgSelected = ((System.Drawing.Image)(resources.GetObject( "switchButtonContour.BkImgSelected" )));
			this.switchButtonContour.Checked = false;
			this.switchButtonContour.FlatAppearance.BorderSize = 0;
			this.switchButtonContour.Location = new System.Drawing.Point( 7, 14 );
			this.switchButtonContour.Name = "switchButtonContour";
			this.switchButtonContour.Size = new System.Drawing.Size( 50, 50 );
			this.switchButtonContour.TabIndex = 3;
			this.toolTip.SetToolTip( this.switchButtonContour, "カラー等値図" );
			this.switchButtonContour.UseVisualStyleBackColor = true;
			this.switchButtonContour.Click += new System.EventHandler( this.contourSwitchButton_Click );
			// 
			// ContaForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 636, 446 );
			this.Controls.Add( this.panelBmp );
			this.Controls.Add( this.panelSettings );
			this.Controls.Add( this.menuStrip );
			this.Controls.Add( this.statusStrip );
			this.Icon = ((System.Drawing.Icon)(resources.GetObject( "$this.Icon" )));
			this.MainMenuStrip = this.menuStrip;
			this.Name = "ContaForm";
			this.Text = "から～こんた～";
			this.Load += new System.EventHandler( this.ContaForm_Load );
			this.ResizeEnd += new System.EventHandler( this.ContaForm_ResizeEnd );
			this.DragDrop += new System.Windows.Forms.DragEventHandler( this.ContaForm_DragDrop );
			this.DragEnter += new System.Windows.Forms.DragEventHandler( this.ContaForm_DragEnter );
			this.Resize += new System.EventHandler( this.ContaForm_Resize );
			this.panelSettings.ResumeLayout( false );
			this.groupBoxCrossView.ResumeLayout( false );
			this.groupBoxCrossView.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
			this.groupBoxVector.ResumeLayout( false );
			this.groupBoxVector.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffset)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).EndInit();
			this.groupBoxContour.ResumeLayout( false );
			this.groupBoxContour.PerformLayout();
			this.groupBoxView.ResumeLayout( false );
			this.groupBoxData2D.ResumeLayout( false );
			this.groupBoxBasic.ResumeLayout( false );
			this.statusStrip.ResumeLayout( false );
			this.statusStrip.PerformLayout();
			this.panelBmp.ResumeLayout( false );
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelSettings;
		private System.Windows.Forms.GroupBox groupBoxCrossView;
		private System.Windows.Forms.GroupBox groupBoxVector;
		private System.Windows.Forms.Label labelMax;
		private System.Windows.Forms.Label labelMin;
		private System.Windows.Forms.TextBox textBoxMinColor;
		private System.Windows.Forms.TextBox textBoxMaxColor;
		private System.Windows.Forms.Panel panelColorBar;
		private System.Windows.Forms.GroupBox groupBoxData2D;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
		private SwitchButton switchButtonVector;
		private SwitchButton switchButtonContour;
		private System.Windows.Forms.CheckBox checkBoxAutoColor;
		private System.Windows.Forms.Button buttonInvMax;
		private System.Windows.Forms.Button buttonInvMin;
		private System.Windows.Forms.Button buttonArrowSet;
		private System.Windows.Forms.GroupBox groupBoxBasic;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button buttonRedraw;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.Button buttonRight;
		private System.Windows.Forms.Button buttonLeft;
		private System.Windows.Forms.Button buttonReopen;
		private System.Windows.Forms.Button buttonEdit;
		private SwitchButton switchButtonGridPoint;
		private System.Windows.Forms.Panel panelBmp;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.GroupBox groupBoxView;
		private System.Windows.Forms.ComboBox comboBoxSizeMode;
		private System.Windows.Forms.ToolStripMenuItem 表示vToolStripMenuItem;
		private SwitchButton switchButtonCrossView;
		private System.Windows.Forms.Label labelY;
		private System.Windows.Forms.Label labelX;
		private System.Windows.Forms.NumericUpDown numericUpDownY;
		private System.Windows.Forms.NumericUpDown numericUpDownX;
		private System.Windows.Forms.CheckBox checkBoxVertical;
		private System.Windows.Forms.CheckBox checkBoxHorizontal;
		private System.Windows.Forms.CheckBox checkBoxVectorMode;
		private System.Windows.Forms.Label labelScale;
		private System.Windows.Forms.TextBox textBoxScale;
		private System.Windows.Forms.GroupBox groupBoxContour;
		private System.Windows.Forms.Button buttonColorSet;
		private System.Windows.Forms.Button buttonToCenter;
		private System.Windows.Forms.CheckBox checkBoxFixedBound;
		private System.Windows.Forms.Label labelOffset;
		private System.Windows.Forms.Label labelInterval;
		private System.Windows.Forms.NumericUpDown numericUpDownOffset;
		private System.Windows.Forms.NumericUpDown numericUpDownInterval;
		private System.Windows.Forms.Button buttonSaveBmp;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.CheckBox checkBoxRefCrossView;
		private System.Windows.Forms.TextBox textBoxRefCrossView;
		private System.Windows.Forms.CheckBox checkBoxRefVector;
		private System.Windows.Forms.TextBox textBoxRefVectorLength;
	}
}