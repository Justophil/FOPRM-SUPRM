namespace FOPRM
{
    partial class CreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateForm));
            this.fnameLb = new System.Windows.Forms.TextBox();
            this.lnameLb = new System.Windows.Forms.TextBox();
            this.ageLb = new System.Windows.Forms.TextBox();
            this.insurLb = new System.Windows.Forms.TextBox();
            this.genLb = new System.Windows.Forms.TextBox();
            this.passportLb = new System.Windows.Forms.TextBox();
            this.createB = new System.Windows.Forms.Button();
            this.fnameIp = new System.Windows.Forms.TextBox();
            this.lnameIp = new System.Windows.Forms.TextBox();
            this.insurIp = new System.Windows.Forms.TextBox();
            this.passportIp = new System.Windows.Forms.TextBox();
            this.ageIp = new System.Windows.Forms.NumericUpDown();
            this.genIp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ageIp)).BeginInit();
            this.SuspendLayout();
            // 
            // fnameLb
            // 
            this.fnameLb.BackColor = System.Drawing.Color.Lavender;
            this.fnameLb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fnameLb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.fnameLb.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameLb.Location = new System.Drawing.Point(12, 12);
            this.fnameLb.Name = "fnameLb";
            this.fnameLb.ReadOnly = true;
            this.fnameLb.Size = new System.Drawing.Size(93, 22);
            this.fnameLb.TabIndex = 0;
            this.fnameLb.TabStop = false;
            this.fnameLb.Text = "First Name:";
            this.fnameLb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lnameLb
            // 
            this.lnameLb.BackColor = System.Drawing.Color.Lavender;
            this.lnameLb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lnameLb.CausesValidation = false;
            this.lnameLb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lnameLb.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameLb.Location = new System.Drawing.Point(12, 39);
            this.lnameLb.Name = "lnameLb";
            this.lnameLb.ReadOnly = true;
            this.lnameLb.Size = new System.Drawing.Size(93, 22);
            this.lnameLb.TabIndex = 1;
            this.lnameLb.TabStop = false;
            this.lnameLb.Text = "Last Name:";
            this.lnameLb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ageLb
            // 
            this.ageLb.BackColor = System.Drawing.Color.Lavender;
            this.ageLb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ageLb.CausesValidation = false;
            this.ageLb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ageLb.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLb.Location = new System.Drawing.Point(13, 66);
            this.ageLb.Multiline = true;
            this.ageLb.Name = "ageLb";
            this.ageLb.ReadOnly = true;
            this.ageLb.Size = new System.Drawing.Size(93, 27);
            this.ageLb.TabIndex = 2;
            this.ageLb.TabStop = false;
            this.ageLb.Text = "Age:";
            this.ageLb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // insurLb
            // 
            this.insurLb.BackColor = System.Drawing.Color.Lavender;
            this.insurLb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.insurLb.CausesValidation = false;
            this.insurLb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.insurLb.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insurLb.Location = new System.Drawing.Point(13, 98);
            this.insurLb.Name = "insurLb";
            this.insurLb.ReadOnly = true;
            this.insurLb.Size = new System.Drawing.Size(93, 22);
            this.insurLb.TabIndex = 3;
            this.insurLb.TabStop = false;
            this.insurLb.Text = "Insurance:";
            this.insurLb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // genLb
            // 
            this.genLb.BackColor = System.Drawing.Color.Lavender;
            this.genLb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genLb.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genLb.Location = new System.Drawing.Point(227, 66);
            this.genLb.Multiline = true;
            this.genLb.Name = "genLb";
            this.genLb.Size = new System.Drawing.Size(102, 26);
            this.genLb.TabIndex = 4;
            this.genLb.TabStop = false;
            this.genLb.Text = "Gender:";
            this.genLb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passportLb
            // 
            this.passportLb.BackColor = System.Drawing.Color.Lavender;
            this.passportLb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passportLb.CausesValidation = false;
            this.passportLb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.passportLb.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passportLb.Location = new System.Drawing.Point(13, 125);
            this.passportLb.Name = "passportLb";
            this.passportLb.ReadOnly = true;
            this.passportLb.Size = new System.Drawing.Size(93, 22);
            this.passportLb.TabIndex = 5;
            this.passportLb.TabStop = false;
            this.passportLb.Text = "Passport:";
            this.passportLb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // createB
            // 
            this.createB.BackColor = System.Drawing.Color.Lavender;
            this.createB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.createB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createB.Location = new System.Drawing.Point(325, 152);
            this.createB.Name = "createB";
            this.createB.Size = new System.Drawing.Size(101, 33);
            this.createB.TabIndex = 11;
            this.createB.Text = "Create";
            this.createB.UseVisualStyleBackColor = false;
            this.createB.Click += new System.EventHandler(this.createB_Click);
            // 
            // fnameIp
            // 
            this.fnameIp.BackColor = System.Drawing.Color.GhostWhite;
            this.fnameIp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fnameIp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.fnameIp.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameIp.Location = new System.Drawing.Point(125, 12);
            this.fnameIp.Name = "fnameIp";
            this.fnameIp.Size = new System.Drawing.Size(300, 21);
            this.fnameIp.TabIndex = 12;
            this.fnameIp.Enter += new System.EventHandler(this.fnameIp_Enter);
            // 
            // lnameIp
            // 
            this.lnameIp.BackColor = System.Drawing.Color.GhostWhite;
            this.lnameIp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lnameIp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lnameIp.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameIp.Location = new System.Drawing.Point(125, 39);
            this.lnameIp.Name = "lnameIp";
            this.lnameIp.Size = new System.Drawing.Size(300, 21);
            this.lnameIp.TabIndex = 13;
            this.lnameIp.Enter += new System.EventHandler(this.lnameIp_Enter);
            // 
            // insurIp
            // 
            this.insurIp.BackColor = System.Drawing.Color.GhostWhite;
            this.insurIp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.insurIp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.insurIp.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insurIp.Location = new System.Drawing.Point(126, 98);
            this.insurIp.Name = "insurIp";
            this.insurIp.Size = new System.Drawing.Size(300, 21);
            this.insurIp.TabIndex = 14;
            this.insurIp.Enter += new System.EventHandler(this.insurIp_Enter);
            // 
            // passportIp
            // 
            this.passportIp.BackColor = System.Drawing.Color.GhostWhite;
            this.passportIp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passportIp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.passportIp.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passportIp.Location = new System.Drawing.Point(126, 125);
            this.passportIp.Name = "passportIp";
            this.passportIp.Size = new System.Drawing.Size(300, 21);
            this.passportIp.TabIndex = 15;
            this.passportIp.Enter += new System.EventHandler(this.passportIp_Enter);
            // 
            // ageIp
            // 
            this.ageIp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageIp.Location = new System.Drawing.Point(126, 67);
            this.ageIp.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.ageIp.Name = "ageIp";
            this.ageIp.Size = new System.Drawing.Size(82, 25);
            this.ageIp.TabIndex = 16;
            // 
            // genIp
            // 
            this.genIp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genIp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genIp.FormattingEnabled = true;
            this.genIp.Items.AddRange(new object[] {
            "M",
            "F"});
            this.genIp.Location = new System.Drawing.Point(347, 66);
            this.genIp.Name = "genIp";
            this.genIp.Size = new System.Drawing.Size(79, 26);
            this.genIp.TabIndex = 17;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(433, 193);
            this.Controls.Add(this.genIp);
            this.Controls.Add(this.ageIp);
            this.Controls.Add(this.passportIp);
            this.Controls.Add(this.insurIp);
            this.Controls.Add(this.lnameIp);
            this.Controls.Add(this.fnameIp);
            this.Controls.Add(this.createB);
            this.Controls.Add(this.passportLb);
            this.Controls.Add(this.genLb);
            this.Controls.Add(this.insurLb);
            this.Controls.Add(this.ageLb);
            this.Controls.Add(this.lnameLb);
            this.Controls.Add(this.fnameLb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(449, 232);
            this.MinimumSize = new System.Drawing.Size(449, 232);
            this.Name = "CreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateForm_FormClosed);
            this.Enter += new System.EventHandler(this.createB_Click);
            ((System.ComponentModel.ISupportInitialize)(this.ageIp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fnameLb;
        private System.Windows.Forms.TextBox lnameLb;
        private System.Windows.Forms.TextBox ageLb;
        private System.Windows.Forms.TextBox insurLb;
        private System.Windows.Forms.TextBox genLb;
        private System.Windows.Forms.TextBox passportLb;
        private System.Windows.Forms.Button createB;
        private System.Windows.Forms.TextBox fnameIp;
        private System.Windows.Forms.TextBox lnameIp;
        private System.Windows.Forms.TextBox insurIp;
        private System.Windows.Forms.TextBox passportIp;
        private System.Windows.Forms.NumericUpDown ageIp;
        private System.Windows.Forms.ComboBox genIp;
    }
}