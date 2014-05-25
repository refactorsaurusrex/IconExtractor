namespace IconExtractor
{
	partial class IconExtractorForm
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
			this.components = new System.ComponentModel.Container();
			this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.labelInfo = new System.Windows.Forms.Label();
			this.buttonOpen = new System.Windows.Forms.Button();
			this.textBoxFilePath = new System.Windows.Forms.TextBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel
			// 
			this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel.Name = "flowLayoutPanel";
			this.flowLayoutPanel.Size = new System.Drawing.Size(688, 198);
			this.flowLayoutPanel.TabIndex = 0;
			// 
			// toolTip
			// 
			this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTip.ToolTipTitle = "Icon Index:";
			// 
			// splitContainer
			// 
			this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer.IsSplitterFixed = true;
			this.splitContainer.Location = new System.Drawing.Point(0, 0);
			this.splitContainer.Name = "splitContainer";
			this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.Window;
			this.splitContainer.Panel1.Controls.Add(this.labelInfo);
			this.splitContainer.Panel1.Controls.Add(this.buttonOpen);
			this.splitContainer.Panel1.Controls.Add(this.textBoxFilePath);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.flowLayoutPanel);
			this.splitContainer.Size = new System.Drawing.Size(692, 255);
			this.splitContainer.SplitterDistance = 49;
			this.splitContainer.TabIndex = 1;
			this.splitContainer.TabStop = false;
			// 
			// labelInfo
			// 
			this.labelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.labelInfo.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelInfo.ForeColor = System.Drawing.Color.Red;
			this.labelInfo.Location = new System.Drawing.Point(456, 0);
			this.labelInfo.Name = "labelInfo";
			this.labelInfo.Size = new System.Drawing.Size(222, 45);
			this.labelInfo.TabIndex = 2;
			this.labelInfo.Text = "user message goes here";
			this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonOpen
			// 
			this.buttonOpen.Location = new System.Drawing.Point(389, 10);
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Size = new System.Drawing.Size(61, 23);
			this.buttonOpen.TabIndex = 1;
			this.buttonOpen.Text = "Open";
			this.buttonOpen.UseVisualStyleBackColor = true;
			this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
			// 
			// textBoxFilePath
			// 
			this.textBoxFilePath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.textBoxFilePath.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBoxFilePath.Location = new System.Drawing.Point(12, 12);
			this.textBoxFilePath.Name = "textBoxFilePath";
			this.textBoxFilePath.ReadOnly = true;
			this.textBoxFilePath.Size = new System.Drawing.Size(371, 20);
			this.textBoxFilePath.TabIndex = 0;
			this.textBoxFilePath.TabStop = false;
			// 
			// IconExtractorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(692, 255);
			this.Controls.Add(this.splitContainer);
			this.Name = "IconExtractorForm";
			this.Text = "Icon Extractor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IconExtractorForm_FormClosing);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel1.PerformLayout();
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.Button buttonOpen;
		private System.Windows.Forms.TextBox textBoxFilePath;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Label labelInfo;



	}
}

