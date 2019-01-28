namespace ProgRunner
{
    partial class LogDisplay
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
            this.InnerList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // InnerList
            // 
            this.InnerList.BackColor = System.Drawing.Color.Black;
            this.InnerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InnerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InnerList.Font = new System.Drawing.Font("Consolas", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InnerList.ForeColor = System.Drawing.Color.White;
            this.InnerList.FormattingEnabled = true;
            this.InnerList.HorizontalScrollbar = true;
            this.InnerList.ItemHeight = 24;
            this.InnerList.Location = new System.Drawing.Point(0, 0);
            this.InnerList.Name = "InnerList";
            this.InnerList.Size = new System.Drawing.Size(150, 150);
            this.InnerList.TabIndex = 0;
            // 
            // LogDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InnerList);
            this.Name = "LogDisplay";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox InnerList;
    }
}
