namespace ProgRunner
{
    partial class RunnerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunnerControl));
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.ProcessNameLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.ControlStrip = new System.Windows.Forms.ToolStrip();
            this.StartButton = new System.Windows.Forms.ToolStripButton();
            this.StopButton = new System.Windows.Forms.ToolStripButton();
            this.ToolSplitter = new System.Windows.Forms.ToolStripSeparator();
            this.CopyOutputButton = new System.Windows.Forms.ToolStripButton();
            this.ClearOutputButton = new System.Windows.Forms.ToolStripButton();
            this.TargetProcess = new System.Diagnostics.Process();
            this.LogOutput = new ProgRunner.LogDisplay();
            this.StatusStrip.SuspendLayout();
            this.ControlStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProcessNameLabel,
            this.StatusProgressBar});
            this.StatusStrip.Location = new System.Drawing.Point(0, 362);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(600, 38);
            this.StatusStrip.TabIndex = 1;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // ProcessNameLabel
            // 
            this.ProcessNameLabel.Name = "ProcessNameLabel";
            this.ProcessNameLabel.Size = new System.Drawing.Size(194, 33);
            this.ProcessNameLabel.Text = "<process name>";
            // 
            // StatusProgressBar
            // 
            this.StatusProgressBar.Name = "StatusProgressBar";
            this.StatusProgressBar.Size = new System.Drawing.Size(100, 32);
            this.StatusProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // ControlStrip
            // 
            this.ControlStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ControlStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ControlStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartButton,
            this.StopButton,
            this.ToolSplitter,
            this.CopyOutputButton,
            this.ClearOutputButton});
            this.ControlStrip.Location = new System.Drawing.Point(0, 0);
            this.ControlStrip.Name = "ControlStrip";
            this.ControlStrip.Size = new System.Drawing.Size(600, 39);
            this.ControlStrip.TabIndex = 2;
            // 
            // StartButton
            // 
            this.StartButton.Image = ((System.Drawing.Image)(resources.GetObject("StartButton.Image")));
            this.StartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(99, 36);
            this.StartButton.Text = "&Start";
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Image = ((System.Drawing.Image)(resources.GetObject("StopButton.Image")));
            this.StopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(99, 36);
            this.StopButton.Text = "S&top";
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ToolSplitter
            // 
            this.ToolSplitter.Name = "ToolSplitter";
            this.ToolSplitter.Size = new System.Drawing.Size(6, 39);
            // 
            // CopyOutputButton
            // 
            this.CopyOutputButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyOutputButton.Image")));
            this.CopyOutputButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyOutputButton.Name = "CopyOutputButton";
            this.CopyOutputButton.Size = new System.Drawing.Size(106, 36);
            this.CopyOutputButton.Text = "&Copy";
            this.CopyOutputButton.Click += new System.EventHandler(this.CopyOutputButton_Click);
            // 
            // ClearOutputButton
            // 
            this.ClearOutputButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearOutputButton.Image")));
            this.ClearOutputButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearOutputButton.Name = "ClearOutputButton";
            this.ClearOutputButton.Size = new System.Drawing.Size(105, 36);
            this.ClearOutputButton.Text = "Clear";
            this.ClearOutputButton.Click += new System.EventHandler(this.ClearOutputButton_Click);
            // 
            // TargetProcess
            // 
            this.TargetProcess.EnableRaisingEvents = true;
            this.TargetProcess.StartInfo.CreateNoWindow = true;
            this.TargetProcess.StartInfo.Domain = "";
            this.TargetProcess.StartInfo.LoadUserProfile = true;
            this.TargetProcess.StartInfo.Password = null;
            this.TargetProcess.StartInfo.RedirectStandardOutput = true;
            this.TargetProcess.StartInfo.StandardErrorEncoding = null;
            this.TargetProcess.StartInfo.StandardOutputEncoding = null;
            this.TargetProcess.StartInfo.UserName = "";
            this.TargetProcess.StartInfo.UseShellExecute = false;
            this.TargetProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            this.TargetProcess.SynchronizingObject = this;
            this.TargetProcess.OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler(this.TargetProcess_OutputDataReceived);
            this.TargetProcess.Exited += new System.EventHandler(this.TargetProcess_Exited);
            // 
            // LogOutput
            // 
            this.LogOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogOutput.Location = new System.Drawing.Point(0, 39);
            this.LogOutput.Name = "LogOutput";
            this.LogOutput.Size = new System.Drawing.Size(600, 323);
            this.LogOutput.TabIndex = 3;
            // 
            // RunnerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LogOutput);
            this.Controls.Add(this.ControlStrip);
            this.Controls.Add(this.StatusStrip);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "RunnerControl";
            this.Size = new System.Drawing.Size(600, 400);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ControlStrip.ResumeLayout(false);
            this.ControlStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ProcessNameLabel;
        private System.Windows.Forms.ToolStrip ControlStrip;
        private System.Windows.Forms.ToolStripButton StartButton;
        private System.Windows.Forms.ToolStripButton StopButton;
        private System.Diagnostics.Process TargetProcess;
        private System.Windows.Forms.ToolStripSeparator ToolSplitter;
        private System.Windows.Forms.ToolStripButton CopyOutputButton;
        private System.Windows.Forms.ToolStripButton ClearOutputButton;
        private System.Windows.Forms.ToolStripProgressBar StatusProgressBar;
        private LogDisplay LogOutput;
    }
}
