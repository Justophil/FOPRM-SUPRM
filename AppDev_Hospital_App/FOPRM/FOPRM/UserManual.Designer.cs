namespace FOPRM
{
    partial class UserManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManual));
            this.textLb = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.prevB1 = new System.Windows.Forms.Button();
            this.nextB1 = new System.Windows.Forms.Button();
            this.nextB2 = new System.Windows.Forms.Button();
            this.prevB2 = new System.Windows.Forms.Button();
            this.img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // textLb
            // 
            this.textLb.BackColor = System.Drawing.Color.Lavender;
            this.textLb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textLb.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLb.Location = new System.Drawing.Point(147, 18);
            this.textLb.Multiline = true;
            this.textLb.Name = "textLb";
            this.textLb.ReadOnly = true;
            this.textLb.Size = new System.Drawing.Size(356, 32);
            this.textLb.TabIndex = 43;
            this.textLb.TabStop = false;
            this.textLb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prevB1
            // 
            this.prevB1.BackColor = System.Drawing.Color.Lavender;
            this.prevB1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.prevB1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevB1.Location = new System.Drawing.Point(21, 17);
            this.prevB1.Name = "prevB1";
            this.prevB1.Size = new System.Drawing.Size(100, 33);
            this.prevB1.TabIndex = 55;
            this.prevB1.Text = "< Previous";
            this.prevB1.UseVisualStyleBackColor = false;
            this.prevB1.Click += new System.EventHandler(this.prevB1_Click);
            // 
            // nextB1
            // 
            this.nextB1.BackColor = System.Drawing.Color.Lavender;
            this.nextB1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.nextB1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextB1.Location = new System.Drawing.Point(526, 18);
            this.nextB1.Name = "nextB1";
            this.nextB1.Size = new System.Drawing.Size(100, 33);
            this.nextB1.TabIndex = 56;
            this.nextB1.Text = "Next >";
            this.nextB1.UseVisualStyleBackColor = false;
            this.nextB1.Click += new System.EventHandler(this.nextB1_Click);
            // 
            // nextB2
            // 
            this.nextB2.BackColor = System.Drawing.Color.Lavender;
            this.nextB2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.nextB2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextB2.Location = new System.Drawing.Point(346, 73);
            this.nextB2.Name = "nextB2";
            this.nextB2.Size = new System.Drawing.Size(280, 33);
            this.nextB2.TabIndex = 57;
            this.nextB2.Text = "Next Step >";
            this.nextB2.UseVisualStyleBackColor = false;
            this.nextB2.Click += new System.EventHandler(this.nextB2_Click);
            // 
            // prevB2
            // 
            this.prevB2.BackColor = System.Drawing.Color.Lavender;
            this.prevB2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.prevB2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevB2.Location = new System.Drawing.Point(21, 73);
            this.prevB2.Name = "prevB2";
            this.prevB2.Size = new System.Drawing.Size(297, 33);
            this.prevB2.TabIndex = 58;
            this.prevB2.Text = "< Previous Step";
            this.prevB2.UseVisualStyleBackColor = false;
            this.prevB2.Click += new System.EventHandler(this.prevB2_Click);
            // 
            // img
            // 
            this.img.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.img.Image = ((System.Drawing.Image)(resources.GetObject("img.Image")));
            this.img.Location = new System.Drawing.Point(21, 125);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(605, 644);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.img.TabIndex = 44;
            this.img.TabStop = false;
            // 
            // UserManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(648, 791);
            this.Controls.Add(this.prevB2);
            this.Controls.Add(this.nextB2);
            this.Controls.Add(this.nextB1);
            this.Controls.Add(this.prevB1);
            this.Controls.Add(this.img);
            this.Controls.Add(this.textLb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(664, 830);
            this.MinimumSize = new System.Drawing.Size(664, 830);
            this.Name = "UserManual";
            this.Text = "UserManual";
            this.Load += new System.EventHandler(this.UserManual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLb;
        private System.Windows.Forms.PictureBox img;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button prevB1;
        private System.Windows.Forms.Button nextB1;
        private System.Windows.Forms.Button nextB2;
        private System.Windows.Forms.Button prevB2;
    }
}