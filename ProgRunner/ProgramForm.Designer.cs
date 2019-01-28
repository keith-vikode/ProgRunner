namespace ProgRunner
{
    partial class ProgramForm
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
            this.InnerRunner = new ProgRunner.RunnerControl();
            this.SuspendLayout();
            // 
            // InnerRunner
            // 
            this.InnerRunner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InnerRunner.Location = new System.Drawing.Point(0, 0);
            this.InnerRunner.MinimumSize = new System.Drawing.Size(400, 200);
            this.InnerRunner.Name = "InnerRunner";
            this.InnerRunner.Process = null;
            this.InnerRunner.Size = new System.Drawing.Size(774, 529);
            this.InnerRunner.TabIndex = 0;
            // 
            // ProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 529);
            this.Controls.Add(this.InnerRunner);
            this.Name = "ProgramForm";
            this.Text = "ProgramForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProgramForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private RunnerControl InnerRunner;
    }
}