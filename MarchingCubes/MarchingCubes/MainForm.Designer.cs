namespace MarchingCubes
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.polygonsColorToolStrip = new System.Windows.Forms.ToolStrip();
            this.polygonsColorPicker = new ExHtmlEditor.ColorPicker.ThemeColorPickerToolStripSplitButton();
            this.polygonsColorLabel = new System.Windows.Forms.Label();
            this.dimSizeLabel = new System.Windows.Forms.Label();
            this.dimSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.xnaPictureBox = new System.Windows.Forms.PictureBox();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.controlsPanel.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.colorPanel.SuspendLayout();
            this.polygonsColorToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dimSizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xnaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlsPanel
            // 
            this.controlsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.controlsPanel.Controls.Add(this.mainTabControl);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsPanel.Location = new System.Drawing.Point(0, 0);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(244, 532);
            this.controlsPanel.TabIndex = 1;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(244, 532);
            this.mainTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.colorPanel);
            this.tabPage1.Controls.Add(this.dimSizeLabel);
            this.tabPage1.Controls.Add(this.dimSizeNumericUpDown);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(236, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // colorPanel
            // 
            this.colorPanel.Controls.Add(this.polygonsColorToolStrip);
            this.colorPanel.Controls.Add(this.polygonsColorLabel);
            this.colorPanel.Location = new System.Drawing.Point(6, 45);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(211, 50);
            this.colorPanel.TabIndex = 2;
            // 
            // polygonsColorToolStrip
            // 
            this.polygonsColorToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.polygonsColorToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polygonsColorPicker});
            this.polygonsColorToolStrip.Location = new System.Drawing.Point(0, 25);
            this.polygonsColorToolStrip.Name = "polygonsColorToolStrip";
            this.polygonsColorToolStrip.Size = new System.Drawing.Size(211, 25);
            this.polygonsColorToolStrip.TabIndex = 1;
            this.polygonsColorToolStrip.Text = "toolStrip1";
            // 
            // polygonsColorPicker
            // 
            this.polygonsColorPicker.Color = System.Drawing.Color.White;
            this.polygonsColorPicker.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.polygonsColorPicker.Image = ((System.Drawing.Image)(resources.GetObject("polygonsColorPicker.Image")));
            this.polygonsColorPicker.ImageHeight = 16;
            this.polygonsColorPicker.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.polygonsColorPicker.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.polygonsColorPicker.ImageWidth = 32;
            this.polygonsColorPicker.Name = "polygonsColorPicker";
            this.polygonsColorPicker.Size = new System.Drawing.Size(48, 22);
            this.polygonsColorPicker.Text = "themeColorPickerToolStripSplitButton1";
            this.polygonsColorPicker.ColorSelected += polygonsColorPicker_ColorSelected;
            // 
            // polygonsColorLabel
            // 
            this.polygonsColorLabel.AutoSize = true;
            this.polygonsColorLabel.Location = new System.Drawing.Point(3, 0);
            this.polygonsColorLabel.Name = "polygonsColorLabel";
            this.polygonsColorLabel.Size = new System.Drawing.Size(79, 13);
            this.polygonsColorLabel.TabIndex = 0;
            this.polygonsColorLabel.Text = "Polygons\' Color";
            // 
            // dimSizeLabel
            // 
            this.dimSizeLabel.AutoSize = true;
            this.dimSizeLabel.Location = new System.Drawing.Point(7, 3);
            this.dimSizeLabel.Name = "dimSizeLabel";
            this.dimSizeLabel.Size = new System.Drawing.Size(84, 13);
            this.dimSizeLabel.TabIndex = 1;
            this.dimSizeLabel.Text = "Dimensions Size";
            // 
            // dimSizeNumericUpDown
            // 
            this.dimSizeNumericUpDown.Location = new System.Drawing.Point(6, 19);
            this.dimSizeNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.dimSizeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dimSizeNumericUpDown.Name = "dimSizeNumericUpDown";
            this.dimSizeNumericUpDown.Size = new System.Drawing.Size(211, 20);
            this.dimSizeNumericUpDown.TabIndex = 0;
            this.dimSizeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dimSizeNumericUpDown.ValueChanged += new System.EventHandler(this.dimSizeNumericUpDown_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(236, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // xnaPictureBox
            // 
            this.xnaPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xnaPictureBox.Location = new System.Drawing.Point(0, 0);
            this.xnaPictureBox.Name = "xnaPictureBox";
            this.xnaPictureBox.Size = new System.Drawing.Size(671, 532);
            this.xnaPictureBox.TabIndex = 0;
            this.xnaPictureBox.TabStop = false;
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.xnaPictureBox);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.controlsPanel);
            this.mainSplitContainer.Size = new System.Drawing.Size(919, 532);
            this.mainSplitContainer.SplitterDistance = 671;
            this.mainSplitContainer.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(919, 532);
            this.Controls.Add(this.mainSplitContainer);
            this.MinimumSize = new System.Drawing.Size(935, 570);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.controlsPanel.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.colorPanel.ResumeLayout(false);
            this.colorPanel.PerformLayout();
            this.polygonsColorToolStrip.ResumeLayout(false);
            this.polygonsColorToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dimSizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xnaPictureBox)).EndInit();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox xnaPictureBox;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.NumericUpDown dimSizeNumericUpDown;
        private System.Windows.Forms.Label dimSizeLabel;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Label polygonsColorLabel;
        private System.Windows.Forms.ToolStrip polygonsColorToolStrip;
        private ExHtmlEditor.ColorPicker.ThemeColorPickerToolStripSplitButton polygonsColorPicker;    
    }
}