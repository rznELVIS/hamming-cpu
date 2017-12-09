namespace Hamming.UI
{
	partial class HammingForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HammingForm));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpTesting = new System.Windows.Forms.TabPage();
            this.tlpTesting = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTestingSettings = new System.Windows.Forms.TableLayoutPanel();
            this.gbTestingM = new System.Windows.Forms.GroupBox();
            this.nupdTestingM = new System.Windows.Forms.NumericUpDown();
            this.gbTestingEb = new System.Windows.Forms.GroupBox();
            this.nupdTestingEb = new System.Windows.Forms.NumericUpDown();
            this.gbTestingItterCount = new System.Windows.Forms.GroupBox();
            this.nupdTestingItterNumber = new System.Windows.Forms.NumericUpDown();
            this.bTestingFile = new System.Windows.Forms.Button();
            this.cbTestingIsLogging = new System.Windows.Forms.CheckBox();
            this.tbTestingFilePath = new System.Windows.Forms.TextBox();
            this.bTestingStart = new System.Windows.Forms.Button();
            this.pbTestingPrgress = new System.Windows.Forms.ProgressBar();
            this.lTestingResult = new System.Windows.Forms.Label();
            this.tpModeling = new System.Windows.Forms.TabPage();
            this.sfdTestingResult = new System.Windows.Forms.SaveFileDialog();
            this.tcMain.SuspendLayout();
            this.tpTesting.SuspendLayout();
            this.tlpTesting.SuspendLayout();
            this.tlpTestingSettings.SuspendLayout();
            this.gbTestingM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdTestingM)).BeginInit();
            this.gbTestingEb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdTestingEb)).BeginInit();
            this.gbTestingItterCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdTestingItterNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpTesting);
            this.tcMain.Controls.Add(this.tpModeling);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(598, 479);
            this.tcMain.TabIndex = 0;
            // 
            // tpTesting
            // 
            this.tpTesting.Controls.Add(this.tlpTesting);
            this.tpTesting.Location = new System.Drawing.Point(4, 22);
            this.tpTesting.Name = "tpTesting";
            this.tpTesting.Padding = new System.Windows.Forms.Padding(3);
            this.tpTesting.Size = new System.Drawing.Size(590, 453);
            this.tpTesting.TabIndex = 0;
            this.tpTesting.Text = "Тестирование";
            this.tpTesting.UseVisualStyleBackColor = true;
            // 
            // tlpTesting
            // 
            this.tlpTesting.ColumnCount = 3;
            this.tlpTesting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTesting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpTesting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tlpTesting.Controls.Add(this.tlpTestingSettings, 0, 1);
            this.tlpTesting.Controls.Add(this.bTestingFile, 1, 0);
            this.tlpTesting.Controls.Add(this.cbTestingIsLogging, 2, 0);
            this.tlpTesting.Controls.Add(this.tbTestingFilePath, 0, 0);
            this.tlpTesting.Controls.Add(this.bTestingStart, 2, 3);
            this.tlpTesting.Controls.Add(this.pbTestingPrgress, 0, 3);
            this.tlpTesting.Controls.Add(this.lTestingResult, 0, 2);
            this.tlpTesting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTesting.Location = new System.Drawing.Point(3, 3);
            this.tlpTesting.Name = "tlpTesting";
            this.tlpTesting.RowCount = 4;
            this.tlpTesting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpTesting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpTesting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTesting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpTesting.Size = new System.Drawing.Size(584, 447);
            this.tlpTesting.TabIndex = 0;
            // 
            // tlpTestingSettings
            // 
            this.tlpTestingSettings.ColumnCount = 3;
            this.tlpTesting.SetColumnSpan(this.tlpTestingSettings, 3);
            this.tlpTestingSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpTestingSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlpTestingSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpTestingSettings.Controls.Add(this.gbTestingM, 0, 0);
            this.tlpTestingSettings.Controls.Add(this.gbTestingEb, 1, 0);
            this.tlpTestingSettings.Controls.Add(this.gbTestingItterCount, 2, 0);
            this.tlpTestingSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTestingSettings.Location = new System.Drawing.Point(3, 28);
            this.tlpTestingSettings.Name = "tlpTestingSettings";
            this.tlpTestingSettings.RowCount = 1;
            this.tlpTestingSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTestingSettings.Size = new System.Drawing.Size(578, 54);
            this.tlpTestingSettings.TabIndex = 0;
            // 
            // gbTestingM
            // 
            this.gbTestingM.Controls.Add(this.nupdTestingM);
            this.gbTestingM.Location = new System.Drawing.Point(3, 3);
            this.gbTestingM.Name = "gbTestingM";
            this.gbTestingM.Size = new System.Drawing.Size(184, 48);
            this.gbTestingM.TabIndex = 0;
            this.gbTestingM.TabStop = false;
            this.gbTestingM.Text = "Значение M:";
            // 
            // nupdTestingM
            // 
            this.nupdTestingM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nupdTestingM.Location = new System.Drawing.Point(3, 16);
            this.nupdTestingM.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nupdTestingM.Name = "nupdTestingM";
            this.nupdTestingM.Size = new System.Drawing.Size(178, 20);
            this.nupdTestingM.TabIndex = 0;
            this.nupdTestingM.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // gbTestingEb
            // 
            this.gbTestingEb.Controls.Add(this.nupdTestingEb);
            this.gbTestingEb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTestingEb.Location = new System.Drawing.Point(193, 3);
            this.gbTestingEb.Name = "gbTestingEb";
            this.gbTestingEb.Size = new System.Drawing.Size(190, 48);
            this.gbTestingEb.TabIndex = 1;
            this.gbTestingEb.TabStop = false;
            this.gbTestingEb.Text = "Отношение сигнал/шум:";
            // 
            // nupdTestingEb
            // 
            this.nupdTestingEb.DecimalPlaces = 1;
            this.nupdTestingEb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nupdTestingEb.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nupdTestingEb.Location = new System.Drawing.Point(3, 16);
            this.nupdTestingEb.Name = "nupdTestingEb";
            this.nupdTestingEb.Size = new System.Drawing.Size(184, 20);
            this.nupdTestingEb.TabIndex = 0;
            this.nupdTestingEb.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // gbTestingItterCount
            // 
            this.gbTestingItterCount.Controls.Add(this.nupdTestingItterNumber);
            this.gbTestingItterCount.Location = new System.Drawing.Point(389, 3);
            this.gbTestingItterCount.Name = "gbTestingItterCount";
            this.gbTestingItterCount.Size = new System.Drawing.Size(186, 48);
            this.gbTestingItterCount.TabIndex = 2;
            this.gbTestingItterCount.TabStop = false;
            this.gbTestingItterCount.Text = "Кол-во повторений";
            // 
            // nupdTestingItterNumber
            // 
            this.nupdTestingItterNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nupdTestingItterNumber.Location = new System.Drawing.Point(3, 16);
            this.nupdTestingItterNumber.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nupdTestingItterNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupdTestingItterNumber.Name = "nupdTestingItterNumber";
            this.nupdTestingItterNumber.Size = new System.Drawing.Size(180, 20);
            this.nupdTestingItterNumber.TabIndex = 0;
            this.nupdTestingItterNumber.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // bTestingFile
            // 
            this.bTestingFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bTestingFile.Location = new System.Drawing.Point(307, 3);
            this.bTestingFile.Name = "bTestingFile";
            this.bTestingFile.Size = new System.Drawing.Size(94, 19);
            this.bTestingFile.TabIndex = 1;
            this.bTestingFile.Text = "Обзор";
            this.bTestingFile.UseVisualStyleBackColor = true;
            this.bTestingFile.Click += new System.EventHandler(this.bTestingFile_Click);
            // 
            // cbTestingIsLogging
            // 
            this.cbTestingIsLogging.AutoSize = true;
            this.cbTestingIsLogging.Checked = true;
            this.cbTestingIsLogging.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTestingIsLogging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTestingIsLogging.Location = new System.Drawing.Point(407, 3);
            this.cbTestingIsLogging.Name = "cbTestingIsLogging";
            this.cbTestingIsLogging.Size = new System.Drawing.Size(174, 19);
            this.cbTestingIsLogging.TabIndex = 2;
            this.cbTestingIsLogging.Text = "Включить логирование?";
            this.cbTestingIsLogging.UseVisualStyleBackColor = true;
            this.cbTestingIsLogging.CheckedChanged += new System.EventHandler(this.cbTestingIsLogging_CheckedChanged);
            // 
            // tbTestingFilePath
            // 
            this.tbTestingFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTestingFilePath.Enabled = false;
            this.tbTestingFilePath.Location = new System.Drawing.Point(3, 3);
            this.tbTestingFilePath.Name = "tbTestingFilePath";
            this.tbTestingFilePath.Size = new System.Drawing.Size(298, 20);
            this.tbTestingFilePath.TabIndex = 3;
            // 
            // bTestingStart
            // 
            this.bTestingStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bTestingStart.Enabled = false;
            this.bTestingStart.Location = new System.Drawing.Point(407, 415);
            this.bTestingStart.Name = "bTestingStart";
            this.bTestingStart.Size = new System.Drawing.Size(174, 29);
            this.bTestingStart.TabIndex = 4;
            this.bTestingStart.Text = "Тестировать";
            this.bTestingStart.UseVisualStyleBackColor = true;
            this.bTestingStart.Click += new System.EventHandler(this.bTestingStart_Click);
            // 
            // pbTestingPrgress
            // 
            this.tlpTesting.SetColumnSpan(this.pbTestingPrgress, 2);
            this.pbTestingPrgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbTestingPrgress.Location = new System.Drawing.Point(3, 415);
            this.pbTestingPrgress.Name = "pbTestingPrgress";
            this.pbTestingPrgress.Size = new System.Drawing.Size(398, 29);
            this.pbTestingPrgress.TabIndex = 5;
            // 
            // lTestingResult
            // 
            this.lTestingResult.AutoSize = true;
            this.tlpTesting.SetColumnSpan(this.lTestingResult, 3);
            this.lTestingResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTestingResult.Location = new System.Drawing.Point(3, 85);
            this.lTestingResult.Name = "lTestingResult";
            this.lTestingResult.Size = new System.Drawing.Size(578, 327);
            this.lTestingResult.TabIndex = 6;
            // 
            // tpModeling
            // 
            this.tpModeling.Location = new System.Drawing.Point(4, 22);
            this.tpModeling.Name = "tpModeling";
            this.tpModeling.Padding = new System.Windows.Forms.Padding(3);
            this.tpModeling.Size = new System.Drawing.Size(590, 453);
            this.tpModeling.TabIndex = 1;
            this.tpModeling.Text = "Моделирование";
            this.tpModeling.UseVisualStyleBackColor = true;
            // 
            // sfdTestingResult
            // 
            this.sfdTestingResult.Filter = "Text Files (*.txt)|*.txt";
            // 
            // HammingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 479);
            this.Controls.Add(this.tcMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HammingForm";
            this.Text = "Хэмминг";
            this.tcMain.ResumeLayout(false);
            this.tpTesting.ResumeLayout(false);
            this.tlpTesting.ResumeLayout(false);
            this.tlpTesting.PerformLayout();
            this.tlpTestingSettings.ResumeLayout(false);
            this.gbTestingM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupdTestingM)).EndInit();
            this.gbTestingEb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupdTestingEb)).EndInit();
            this.gbTestingItterCount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupdTestingItterNumber)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tcMain;
		private System.Windows.Forms.TabPage tpTesting;
		private System.Windows.Forms.TableLayoutPanel tlpTesting;
		private System.Windows.Forms.TableLayoutPanel tlpTestingSettings;
		private System.Windows.Forms.GroupBox gbTestingM;
		private System.Windows.Forms.NumericUpDown nupdTestingM;
		private System.Windows.Forms.GroupBox gbTestingEb;
		private System.Windows.Forms.NumericUpDown nupdTestingEb;
		private System.Windows.Forms.GroupBox gbTestingItterCount;
		private System.Windows.Forms.NumericUpDown nupdTestingItterNumber;
		private System.Windows.Forms.Button bTestingFile;
		private System.Windows.Forms.CheckBox cbTestingIsLogging;
		private System.Windows.Forms.TextBox tbTestingFilePath;
		private System.Windows.Forms.Button bTestingStart;
		private System.Windows.Forms.ProgressBar pbTestingPrgress;
		private System.Windows.Forms.Label lTestingResult;
		private System.Windows.Forms.TabPage tpModeling;
		private System.Windows.Forms.SaveFileDialog sfdTestingResult;
	}
}

