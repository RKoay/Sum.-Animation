namespace Sum.Animation
{
    partial class Face
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Face));
            this.introO = new System.Windows.Forms.Label();
            this.introT = new System.Windows.Forms.Label();
            this.introTh = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // introO
            // 
            this.introO.AllowDrop = true;
            this.introO.AutoSize = true;
            this.introO.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.introO.Location = new System.Drawing.Point(41, 84);
            this.introO.Name = "introO";
            this.introO.Size = new System.Drawing.Size(346, 53);
            this.introO.TabIndex = 0;
            this.introO.Text = "\"Face\" By Rie Koay";
            // 
            // introT
            // 
            this.introT.AutoSize = true;
            this.introT.BackColor = System.Drawing.Color.White;
            this.introT.Location = new System.Drawing.Point(60, 165);
            this.introT.Name = "introT";
            this.introT.Size = new System.Drawing.Size(37, 13);
            this.introT.TabIndex = 1;
            this.introT.Text = "          ";
            // 
            // introTh
            // 
            this.introTh.AutoSize = true;
            this.introTh.BackColor = System.Drawing.Color.White;
            this.introTh.Location = new System.Drawing.Point(60, 192);
            this.introTh.Name = "introTh";
            this.introTh.Size = new System.Drawing.Size(37, 13);
            this.introTh.TabIndex = 2;
            this.introTh.Text = "          ";
            this.introTh.Click += new System.EventHandler(this.introTh_Click);
            // 
            // Face
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(419, 383);
            this.Controls.Add(this.introTh);
            this.Controls.Add(this.introT);
            this.Controls.Add(this.introO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Face";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label introO;
        private System.Windows.Forms.Label introT;
        private System.Windows.Forms.Label introTh;
    }
}

