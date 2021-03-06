﻿namespace HadithDatabase
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataDownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.converToJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSCToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bukhariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muslimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sunnahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bukhariToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.muslimToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataDownloadToolStripMenuItem,
            this.converToJSONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1124, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataDownloadToolStripMenuItem
            // 
            this.dataDownloadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSCToolStripMenuItem});
            this.dataDownloadToolStripMenuItem.Name = "dataDownloadToolStripMenuItem";
            this.dataDownloadToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.dataDownloadToolStripMenuItem.Text = "Data Download";
            // 
            // uSCToolStripMenuItem
            // 
            this.uSCToolStripMenuItem.Name = "uSCToolStripMenuItem";
            this.uSCToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.uSCToolStripMenuItem.Text = "USC";
            this.uSCToolStripMenuItem.Click += new System.EventHandler(this.uSCToolStripMenuItem_Click);
            // 
            // converToJSONToolStripMenuItem
            // 
            this.converToJSONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSCToolStripMenuItem1,
            this.sunnahToolStripMenuItem});
            this.converToJSONToolStripMenuItem.Name = "converToJSONToolStripMenuItem";
            this.converToJSONToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.converToJSONToolStripMenuItem.Text = "Conver to JSON";
            // 
            // uSCToolStripMenuItem1
            // 
            this.uSCToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bukhariToolStripMenuItem,
            this.muslimToolStripMenuItem});
            this.uSCToolStripMenuItem1.Name = "uSCToolStripMenuItem1";
            this.uSCToolStripMenuItem1.Size = new System.Drawing.Size(175, 24);
            this.uSCToolStripMenuItem1.Text = "USC";
            // 
            // bukhariToolStripMenuItem
            // 
            this.bukhariToolStripMenuItem.Name = "bukhariToolStripMenuItem";
            this.bukhariToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.bukhariToolStripMenuItem.Text = "Bukhari";
            this.bukhariToolStripMenuItem.Click += new System.EventHandler(this.bukhariToolStripMenuItem_Click);
            // 
            // muslimToolStripMenuItem
            // 
            this.muslimToolStripMenuItem.Name = "muslimToolStripMenuItem";
            this.muslimToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.muslimToolStripMenuItem.Text = "Muslim";
            this.muslimToolStripMenuItem.Click += new System.EventHandler(this.muslimToolStripMenuItem_Click);
            // 
            // sunnahToolStripMenuItem
            // 
            this.sunnahToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bukhariToolStripMenuItem1,
            this.muslimToolStripMenuItem1});
            this.sunnahToolStripMenuItem.Name = "sunnahToolStripMenuItem";
            this.sunnahToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.sunnahToolStripMenuItem.Text = "Sunnah";
            // 
            // bukhariToolStripMenuItem1
            // 
            this.bukhariToolStripMenuItem1.Name = "bukhariToolStripMenuItem1";
            this.bukhariToolStripMenuItem1.Size = new System.Drawing.Size(175, 24);
            this.bukhariToolStripMenuItem1.Text = "Bukhari";
            this.bukhariToolStripMenuItem1.Click += new System.EventHandler(this.bukhariToolStripMenuItem1_Click);
            // 
            // muslimToolStripMenuItem1
            // 
            this.muslimToolStripMenuItem1.Name = "muslimToolStripMenuItem1";
            this.muslimToolStripMenuItem1.Size = new System.Drawing.Size(175, 24);
            this.muslimToolStripMenuItem1.Text = "Muslim";
            this.muslimToolStripMenuItem1.Click += new System.EventHandler(this.muslimToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 549);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Hadith Database";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataDownloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem converToJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSCToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bukhariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muslimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sunnahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bukhariToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem muslimToolStripMenuItem1;
    }
}

