namespace ProgRunner
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Toolbar = new System.Windows.Forms.ToolStrip();
            this.AddProcessButton = new System.Windows.Forms.ToolStripButton();
            this.RunAllButton = new System.Windows.Forms.ToolStripButton();
            this.StopAllButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolstripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowToolstripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TileHorizontallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TileVerticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Toolbar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Toolbar
            // 
            this.Toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Toolbar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddProcessButton,
            this.RunAllButton,
            this.StopAllButton});
            this.Toolbar.Location = new System.Drawing.Point(0, 40);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(1000, 39);
            this.Toolbar.TabIndex = 1;
            this.Toolbar.Text = "toolStrip1";
            // 
            // AddProcessButton
            // 
            this.AddProcessButton.Image = ((System.Drawing.Image)(resources.GetObject("AddProcessButton.Image")));
            this.AddProcessButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddProcessButton.Name = "AddProcessButton";
            this.AddProcessButton.Size = new System.Drawing.Size(109, 36);
            this.AddProcessButton.Text = "&Add...";
            this.AddProcessButton.Click += new System.EventHandler(this.AddProcessButton_Click);
            // 
            // RunAllButton
            // 
            this.RunAllButton.Image = ((System.Drawing.Image)(resources.GetObject("RunAllButton.Image")));
            this.RunAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RunAllButton.Name = "RunAllButton";
            this.RunAllButton.Size = new System.Drawing.Size(124, 36);
            this.RunAllButton.Text = "&Run all";
            this.RunAllButton.Click += new System.EventHandler(this.RunAllButton_Click);
            // 
            // StopAllButton
            // 
            this.StopAllButton.Image = ((System.Drawing.Image)(resources.GetObject("StopAllButton.Image")));
            this.StopAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopAllButton.Name = "StopAllButton";
            this.StopAllButton.Size = new System.Drawing.Size(130, 36);
            this.StopAllButton.Text = "&Stop all";
            this.StopAllButton.Click += new System.EventHandler(this.StopAllButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolstripButton,
            this.WindowToolstripButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.WindowToolstripButton;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 40);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolstripButton
            // 
            this.FileToolstripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitButton});
            this.FileToolstripButton.Name = "FileToolstripButton";
            this.FileToolstripButton.Size = new System.Drawing.Size(64, 36);
            this.FileToolstripButton.Text = "&File";
            // 
            // ExitButton
            // 
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(151, 38);
            this.ExitButton.Text = "E&xit";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // WindowToolstripButton
            // 
            this.WindowToolstripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TileHorizontallyToolStripMenuItem,
            this.TileVerticallyToolStripMenuItem,
            this.CascadeToolStripMenuItem,
            this.toolStripSeparator1});
            this.WindowToolstripButton.Name = "WindowToolstripButton";
            this.WindowToolstripButton.Size = new System.Drawing.Size(114, 36);
            this.WindowToolstripButton.Text = "&Window";
            // 
            // TileHorizontallyToolStripMenuItem
            // 
            this.TileHorizontallyToolStripMenuItem.Name = "TileHorizontallyToolStripMenuItem";
            this.TileHorizontallyToolStripMenuItem.Size = new System.Drawing.Size(284, 38);
            this.TileHorizontallyToolStripMenuItem.Text = "Tile horizontally";
            this.TileHorizontallyToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontallyToolStripMenuItem_Click);
            // 
            // TileVerticallyToolStripMenuItem
            // 
            this.TileVerticallyToolStripMenuItem.Name = "TileVerticallyToolStripMenuItem";
            this.TileVerticallyToolStripMenuItem.Size = new System.Drawing.Size(284, 38);
            this.TileVerticallyToolStripMenuItem.Text = "Tile vertically";
            this.TileVerticallyToolStripMenuItem.Click += new System.EventHandler(this.TileVerticallyToolStripMenuItem_Click);
            // 
            // CascadeToolStripMenuItem
            // 
            this.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem";
            this.CascadeToolStripMenuItem.Size = new System.Drawing.Size(284, 38);
            this.CascadeToolStripMenuItem.Text = "Cascade";
            this.CascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(281, 6);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 694);
            this.Controls.Add(this.Toolbar);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Multirunner";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Toolbar.ResumeLayout(false);
            this.Toolbar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Toolbar;
        private System.Windows.Forms.ToolStripButton AddProcessButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolstripButton;
        private System.Windows.Forms.ToolStripMenuItem WindowToolstripButton;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
        private System.Windows.Forms.ToolStripMenuItem TileHorizontallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TileVerticallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton RunAllButton;
        private System.Windows.Forms.ToolStripButton StopAllButton;
    }
}