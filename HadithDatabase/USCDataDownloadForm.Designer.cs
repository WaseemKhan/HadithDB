namespace HadithDatabase
{
    partial class USCDataDownloadForm
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
            this.btnBukhari = new System.Windows.Forms.Button();
            this.btnMuslim = new System.Windows.Forms.Button();
            this.btnDawud = new System.Windows.Forms.Button();
            this.btnMuwatta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBukhari
            // 
            this.btnBukhari.Location = new System.Drawing.Point(12, 12);
            this.btnBukhari.Name = "btnBukhari";
            this.btnBukhari.Size = new System.Drawing.Size(93, 28);
            this.btnBukhari.TabIndex = 0;
            this.btnBukhari.Text = "Bukhari";
            this.btnBukhari.UseVisualStyleBackColor = true;
            this.btnBukhari.Click += new System.EventHandler(this.btnBukhari_Click);
            // 
            // btnMuslim
            // 
            this.btnMuslim.Location = new System.Drawing.Point(12, 58);
            this.btnMuslim.Name = "btnMuslim";
            this.btnMuslim.Size = new System.Drawing.Size(93, 28);
            this.btnMuslim.TabIndex = 1;
            this.btnMuslim.Text = "Muslim";
            this.btnMuslim.UseVisualStyleBackColor = true;
            this.btnMuslim.Click += new System.EventHandler(this.btnMuslim_Click);
            // 
            // btnDawud
            // 
            this.btnDawud.Location = new System.Drawing.Point(12, 109);
            this.btnDawud.Name = "btnDawud";
            this.btnDawud.Size = new System.Drawing.Size(93, 28);
            this.btnDawud.TabIndex = 2;
            this.btnDawud.Text = "Dawud";
            this.btnDawud.UseVisualStyleBackColor = true;
            this.btnDawud.Click += new System.EventHandler(this.btnDawud_Click);
            // 
            // btnMuwatta
            // 
            this.btnMuwatta.Location = new System.Drawing.Point(12, 158);
            this.btnMuwatta.Name = "btnMuwatta";
            this.btnMuwatta.Size = new System.Drawing.Size(93, 28);
            this.btnMuwatta.TabIndex = 3;
            this.btnMuwatta.Text = "Muwatta";
            this.btnMuwatta.UseVisualStyleBackColor = true;
            this.btnMuwatta.Click += new System.EventHandler(this.btnMuwatta_Click);
            // 
            // USCDataDownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnMuwatta);
            this.Controls.Add(this.btnDawud);
            this.Controls.Add(this.btnMuslim);
            this.Controls.Add(this.btnBukhari);
            this.Name = "USCDataDownloadForm";
            this.Text = "USC Data Download";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBukhari;
        private System.Windows.Forms.Button btnMuslim;
        private System.Windows.Forms.Button btnDawud;
        private System.Windows.Forms.Button btnMuwatta;
    }
}