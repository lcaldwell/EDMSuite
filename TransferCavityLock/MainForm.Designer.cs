﻿namespace TransferCavityLock
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
            this.voltageRampControl = new System.Windows.Forms.GroupBox();
            this.triggerMenu = new System.Windows.Forms.ComboBox();
            this.rampLED = new NationalInstruments.UI.WindowsForms.Led();
            this.rampStopButton = new System.Windows.Forms.Button();
            this.rampChannelMenu = new System.Windows.Forms.ComboBox();
            this.rampStartButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.p1Intensity = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.scatterPlot1 = new NationalInstruments.UI.ScatterPlot();
            this.p2Intensity = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.scatterPlot2 = new NationalInstruments.UI.ScatterPlot();
            this.xAxis2 = new NationalInstruments.UI.XAxis();
            this.yAxis2 = new NationalInstruments.UI.YAxis();
            this.voltageRampControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rampLED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Intensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Intensity)).BeginInit();
            this.SuspendLayout();
            // 
            // voltageRampControl
            // 
            this.voltageRampControl.Controls.Add(this.triggerMenu);
            this.voltageRampControl.Controls.Add(this.rampLED);
            this.voltageRampControl.Controls.Add(this.rampStopButton);
            this.voltageRampControl.Controls.Add(this.rampChannelMenu);
            this.voltageRampControl.Controls.Add(this.rampStartButton);
            this.voltageRampControl.Location = new System.Drawing.Point(592, 12);
            this.voltageRampControl.Name = "voltageRampControl";
            this.voltageRampControl.Size = new System.Drawing.Size(159, 136);
            this.voltageRampControl.TabIndex = 2;
            this.voltageRampControl.TabStop = false;
            this.voltageRampControl.Text = "Voltage Ramp";
            this.voltageRampControl.Enter += new System.EventHandler(this.voltageRampControl_Enter);
            // 
            // triggerMenu
            // 
            this.triggerMenu.FormattingEnabled = true;
            this.triggerMenu.Items.AddRange(new object[] {
            "int",
            "ext"});
            this.triggerMenu.Location = new System.Drawing.Point(6, 106);
            this.triggerMenu.MaxDropDownItems = 2;
            this.triggerMenu.Name = "triggerMenu";
            this.triggerMenu.Size = new System.Drawing.Size(121, 21);
            this.triggerMenu.TabIndex = 8;
            this.triggerMenu.Text = "Select Trigger";
            this.triggerMenu.SelectedIndexChanged += new System.EventHandler(this.triggerMenu_SelectedIndexChanged);
            // 
            // rampLED
            // 
            this.rampLED.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.rampLED.Location = new System.Drawing.Point(123, 19);
            this.rampLED.Name = "rampLED";
            this.rampLED.OffColor = System.Drawing.Color.Red;
            this.rampLED.Size = new System.Drawing.Size(31, 29);
            this.rampLED.TabIndex = 7;
            // 
            // rampStopButton
            // 
            this.rampStopButton.Location = new System.Drawing.Point(6, 46);
            this.rampStopButton.Name = "rampStopButton";
            this.rampStopButton.Size = new System.Drawing.Size(111, 23);
            this.rampStopButton.TabIndex = 6;
            this.rampStopButton.Text = "Stop ramping";
            this.rampStopButton.UseVisualStyleBackColor = true;
            this.rampStopButton.Click += new System.EventHandler(this.rampStopButton_Click);
            // 
            // rampChannelMenu
            // 
            this.rampChannelMenu.FormattingEnabled = true;
            this.rampChannelMenu.Items.AddRange(new object[] {
            "laser",
            "cavity"});
            this.rampChannelMenu.Location = new System.Drawing.Point(6, 79);
            this.rampChannelMenu.MaxDropDownItems = 2;
            this.rampChannelMenu.Name = "rampChannelMenu";
            this.rampChannelMenu.Size = new System.Drawing.Size(121, 21);
            this.rampChannelMenu.TabIndex = 3;
            this.rampChannelMenu.Text = "Select Channel";
            this.rampChannelMenu.SelectedIndexChanged += new System.EventHandler(this.rampChannelMenu_SelectedIndexChanged);
            // 
            // rampStartButton
            // 
            this.rampStartButton.Location = new System.Drawing.Point(6, 19);
            this.rampStartButton.Name = "rampStartButton";
            this.rampStartButton.Size = new System.Drawing.Size(111, 23);
            this.rampStartButton.TabIndex = 2;
            this.rampStartButton.Text = "Start ramping";
            this.rampStartButton.UseVisualStyleBackColor = true;
            this.rampStartButton.Click += new System.EventHandler(this.rampStartButton_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 239);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(499, 20);
            this.textBox.TabIndex = 3;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // p1Intensity
            // 
            this.p1Intensity.Location = new System.Drawing.Point(0, 3);
            this.p1Intensity.Name = "p1Intensity";
            this.p1Intensity.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
            this.scatterPlot1});
            this.p1Intensity.Size = new System.Drawing.Size(548, 112);
            this.p1Intensity.TabIndex = 4;
            this.p1Intensity.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.p1Intensity.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            this.p1Intensity.PlotDataChanged += new NationalInstruments.UI.XYPlotDataChangedEventHandler(this.p1Intensity_PlotDataChanged);
            // 
            // scatterPlot1
            // 
            this.scatterPlot1.XAxis = this.xAxis1;
            this.scatterPlot1.YAxis = this.yAxis1;
            // 
            // p2Intensity
            // 
            this.p2Intensity.Location = new System.Drawing.Point(0, 121);
            this.p2Intensity.Name = "p2Intensity";
            this.p2Intensity.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
            this.scatterPlot2});
            this.p2Intensity.Size = new System.Drawing.Size(548, 112);
            this.p2Intensity.TabIndex = 5;
            this.p2Intensity.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis2});
            this.p2Intensity.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis2});
            this.p2Intensity.PlotDataChanged += new NationalInstruments.UI.XYPlotDataChangedEventHandler(this.p2Intensity_PlotDataChanged);
            // 
            // scatterPlot2
            // 
            this.scatterPlot2.XAxis = this.xAxis2;
            this.scatterPlot2.YAxis = this.yAxis2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 271);
            this.Controls.Add(this.p2Intensity);
            this.Controls.Add(this.p1Intensity);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.voltageRampControl);
            this.Name = "MainForm";
            this.Text = "Transfer Cavity Lock";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.voltageRampControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rampLED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Intensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Intensity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox voltageRampControl;
        private System.Windows.Forms.Button rampStartButton;
        private System.Windows.Forms.ComboBox rampChannelMenu;
        private System.Windows.Forms.Button rampStopButton;
        private NationalInstruments.UI.WindowsForms.Led rampLED;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ComboBox triggerMenu;
        private NationalInstruments.UI.WindowsForms.ScatterGraph p1Intensity;
        private NationalInstruments.UI.ScatterPlot scatterPlot1;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private NationalInstruments.UI.WindowsForms.ScatterGraph p2Intensity;
        private NationalInstruments.UI.ScatterPlot scatterPlot2;
        private NationalInstruments.UI.XAxis xAxis2;
        private NationalInstruments.UI.YAxis yAxis2;
    }
}

