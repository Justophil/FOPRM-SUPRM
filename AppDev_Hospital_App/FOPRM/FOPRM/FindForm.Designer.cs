namespace FOPRM
{
    partial class FindForm
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
            this.genIp = new System.Windows.Forms.ComboBox();
            this.ageIp = new System.Windows.Forms.NumericUpDown();
            this.passportIp = new System.Windows.Forms.TextBox();
            this.insurIp = new System.Windows.Forms.TextBox();
            this.lnameIp = new System.Windows.Forms.TextBox();
            this.fnameIp = new System.Windows.Forms.TextBox();
            this.findB = new System.Windows.Forms.Button();
            this.passportLb = new System.Windows.Forms.TextBox();
            this.genLb = new System.Windows.Forms.TextBox();
            this.insurLb = new System.Windows.Forms.TextBox();
            this.ageLb = new System.Windows.Forms.TextBox();
            this.lnameLb = new System.Windows.Forms.TextBox();
            this.fnameLb = new System.Windows.Forms.TextBox();
            this.idLb = new System.Windows.Forms.TextBox();
            this.idIp = new System.Windows.Forms.TextBox();
            this.conLb = new System.Windows.Forms.TextBox();
            this.conIp = new System.Windows.Forms.NumericUpDown();
            this.disLb = new System.Windows.Forms.TextBox();
            this.disIp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ageIp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conIp)).BeginInit();
            this.SuspendLayout();
            // 
            // genIp
            // 
            this.genIp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genIp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genIp.FormattingEnabled = true;
            this.genIp.Items.AddRange(new object[] {
            "M",
            "F"});
            this.genIp.Location = new System.Drawing.Point(347, 97);
            this.genIp.Name = "genIp";
            this.genIp.Size = new System.Drawing.Size(79, 26);
            this.genIp.TabIndex = 30;
            // 
            // ageIp
            // 
            this.ageIp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageIp.Location = new System.Drawing.Point(347, 10);
            this.ageIp.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.ageIp.Name = "ageIp";
            this.ageIp.Size = new System.Drawing.Size(78, 25);
            this.ageIp.TabIndex = 29;
            // 
            // passportIp
            // 
            this.passportIp.BackColor = System.Drawing.Color.GhostWhite;
            this.passportIp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passportIp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.passportIp.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passportIp.Location = new System.Drawing.Point(125, 156);
            this.passportIp.Name = "passportIp";
            this.passportIp.Size = new System.Drawing.Size(300, 21);
            this.passportIp.TabIndex = 28;
            this.passportIp.Enter += new System.EventHandler(this.passportIp_Enter);
            // 
            // insurIp
            // 
            this.insurIp.BackColor = System.Drawing.Color.GhostWhite;
            this.insurIp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.insurIp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.insurIp.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insurIp.Location = new System.Drawing.Point(125, 127);
            this.insurIp.Name = "insurIp";
            this.insurIp.Size = new System.Drawing.Size(300, 21);
            this.insurIp.TabIndex = 27;
            this.insurIp.Enter += new System.EventHandler(this.insurIp_Enter);
            // 
            // lnameIp
            // 
            this.lnameIp.BackColor = System.Drawing.Color.GhostWhite;
            this.lnameIp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lnameIp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lnameIp.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameIp.Location = new System.Drawing.Point(125, 69);
            this.lnameIp.Name = "lnameIp";
            this.lnameIp.Size = new System.Drawing.Size(300, 21);
            this.lnameIp.TabIndex = 26;
            this.lnameIp.Enter += new System.EventHandler(this.lnameIp_Enter);
            // 
            // fnameIp
            // 
            this.fnameIp.BackColor = System.Drawing.Color.GhostWhite;
            this.fnameIp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fnameIp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.fnameIp.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameIp.Location = new System.Drawing.Point(125, 41);
            this.fnameIp.Name = "fnameIp";
            this.fnameIp.Size = new System.Drawing.Size(300, 21);
            this.fnameIp.TabIndex = 25;
            this.fnameIp.Enter += new System.EventHandler(this.fnameIp_Enter);
            // 
            // findB
            // 
            this.findB.BackColor = System.Drawing.Color.Lavender;
            this.findB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.findB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findB.Location = new System.Drawing.Point(325, 299);
            this.findB.Name = "findB";
            this.findB.Size = new System.Drawing.Size(101, 33);
            this.findB.TabIndex = 24;
            this.findB.Text = "Find";
            this.findB.UseVisualStyleBackColor = false;
            this.findB.Click += new System.EventHandler(this.findB_Click);
            // 
            // passportLb
            // 
            this.passportLb.BackColor = System.Drawing.Color.Lavender;
            this.passportLb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passportLb.CausesValidation = false;
            this.passportLb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.passportLb.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passportLb.Location = new System.Drawing.Point(12, 155);
            this.passportLb.Name = "passportLb";
            this.passportLb.ReadOnly = true;
            this.passportLb.Size = new System.Drawing.Size(94, 22);
            this.passportLb.TabIndex = 23;
            this.passportLb.TabStop = false;
            this.passportLb.Text = "Passport:";
            this.passportLb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // genLb
            // 
            this.genLb.BackColor = System.Drawing.Color.Lavender;
            this.genLb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genLb.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genLb.Location = new System.Drawing.Point(227, 97);
            this.genLb.Multiline = true;
            this.genLb.Name = "genLb";
            this.genLb.Size = new System.Drawing.Size(102, 25);
            this.genLb.TabIndex = 22;
            this.genLb.TabStop = false;
            this.genLb.Text = "Gender:";
            this.genLb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // insurLb
            // 
            this.insurLb.BackColor = System.Drawing.Color.Lavender;
            this.insurLb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.insurLb.CausesValidation = false;
            this.insurLb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.insurLb.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insurLb.Location = new System.Drawing.Point(12, 127);
            this.insurLb.Name = "insurLb";
            this.insurLb.ReadOnly = true;
            this.insurLb.Size = new System.Drawing.Size(93, 22);
            this.insurLb.TabIndex = 21;
            this.insurLb.TabStop = false;
            this.insurLb.Text = "Insurance:";
            this.insurLb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ageLb
            // 
            this.ageLb.BackColor = System.Drawing.Color.Lavender;
            this.ageLb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ageLb.CausesValidation = false;
            this.ageLb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ageLb.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLb.Location = new System.Drawing.Point(227, 10);
            this.ageLb.Multiline = true;
            this.ageLb.Name = "ageLb";
            this.ageLb.ReadOnly = true;
            this.ageLb.Size = new System.Drawing.Size(102, 25);
            this.ageLb.TabIndex = 20;
            this.ageLb.TabStop = false;
            this.ageLb.Text = "Age:";
            this.ageLb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lnameLb
            // 
            this.lnameLb.BackColor = System.Drawing.Color.Lavender;
            this.lnameLb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lnameLb.CausesValidation = false;
            this.lnameLb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lnameLb.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameLb.Location = new System.Drawing.Point(13, 68);
            this.lnameLb.Name = "lnameLb";
            this.lnameLb.ReadOnly = true;
            this.lnameLb.Size = new System.Drawing.Size(93, 22);
            this.lnameLb.TabIndex = 19;
            this.lnameLb.TabStop = false;
            this.lnameLb.Text = "Last Name:";
            this.lnameLb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fnameLb
            // 
            this.fnameLb.BackColor = System.Drawing.Color.Lavender;
            this.fnameLb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fnameLb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.fnameLb.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameLb.Location = new System.Drawing.Point(12, 40);
            this.fnameLb.Name = "fnameLb";
            this.fnameLb.ReadOnly = true;
            this.fnameLb.Size = new System.Drawing.Size(94, 22);
            this.fnameLb.TabIndex = 18;
            this.fnameLb.TabStop = false;
            this.fnameLb.Text = "First Name:";
            this.fnameLb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // idLb
            // 
            this.idLb.BackColor = System.Drawing.Color.Lavender;
            this.idLb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idLb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.idLb.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLb.Location = new System.Drawing.Point(12, 9);
            this.idLb.Multiline = true;
            this.idLb.Name = "idLb";
            this.idLb.ReadOnly = true;
            this.idLb.Size = new System.Drawing.Size(94, 25);
            this.idLb.TabIndex = 31;
            this.idLb.TabStop = false;
            this.idLb.Text = "ID:";
            this.idLb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // idIp
            // 
            this.idIp.BackColor = System.Drawing.Color.GhostWhite;
            this.idIp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idIp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.idIp.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idIp.Location = new System.Drawing.Point(125, 9);
            this.idIp.Multiline = true;
            this.idIp.Name = "idIp";
            this.idIp.Size = new System.Drawing.Size(80, 25);
            this.idIp.TabIndex = 32;
            this.idIp.Enter += new System.EventHandler(this.idIp_Enter);
            // 
            // conLb
            // 
            this.conLb.BackColor = System.Drawing.Color.Lavender;
            this.conLb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conLb.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conLb.Location = new System.Drawing.Point(13, 96);
            this.conLb.Multiline = true;
            this.conLb.Name = "conLb";
            this.conLb.Size = new System.Drawing.Size(93, 25);
            this.conLb.TabIndex = 33;
            this.conLb.TabStop = false;
            this.conLb.Text = "Condition:";
            this.conLb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // conIp
            // 
            this.conIp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conIp.Location = new System.Drawing.Point(125, 97);
            this.conIp.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.conIp.Name = "conIp";
            this.conIp.Size = new System.Drawing.Size(80, 25);
            this.conIp.TabIndex = 34;
            // 
            // disLb
            // 
            this.disLb.BackColor = System.Drawing.Color.Lavender;
            this.disLb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.disLb.CausesValidation = false;
            this.disLb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.disLb.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disLb.Location = new System.Drawing.Point(12, 183);
            this.disLb.Name = "disLb";
            this.disLb.ReadOnly = true;
            this.disLb.Size = new System.Drawing.Size(94, 22);
            this.disLb.TabIndex = 35;
            this.disLb.TabStop = false;
            this.disLb.Text = "Diseases:";
            this.disLb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // disIp
            // 
            this.disIp.BackColor = System.Drawing.Color.GhostWhite;
            this.disIp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.disIp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.disIp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disIp.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.disIp.Location = new System.Drawing.Point(125, 184);
            this.disIp.MaximumSize = new System.Drawing.Size(300, 109);
            this.disIp.MinimumSize = new System.Drawing.Size(300, 109);
            this.disIp.Multiline = true;
            this.disIp.Name = "disIp";
            this.disIp.Size = new System.Drawing.Size(300, 109);
            this.disIp.TabIndex = 36;
            this.disIp.Text = "SEPARATE EACH BY LINES (ENTER)";
            this.disIp.Enter += new System.EventHandler(this.disIp_Enter);
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 344);
            this.Controls.Add(this.disIp);
            this.Controls.Add(this.disLb);
            this.Controls.Add(this.conIp);
            this.Controls.Add(this.conLb);
            this.Controls.Add(this.idIp);
            this.Controls.Add(this.idLb);
            this.Controls.Add(this.genIp);
            this.Controls.Add(this.ageIp);
            this.Controls.Add(this.passportIp);
            this.Controls.Add(this.insurIp);
            this.Controls.Add(this.lnameIp);
            this.Controls.Add(this.fnameIp);
            this.Controls.Add(this.findB);
            this.Controls.Add(this.passportLb);
            this.Controls.Add(this.genLb);
            this.Controls.Add(this.insurLb);
            this.Controls.Add(this.ageLb);
            this.Controls.Add(this.lnameLb);
            this.Controls.Add(this.fnameLb);
            this.Name = "FindForm";
            this.Text = "Find";
            ((System.ComponentModel.ISupportInitialize)(this.ageIp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conIp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox genIp;
        private System.Windows.Forms.NumericUpDown ageIp;
        private System.Windows.Forms.TextBox passportIp;
        private System.Windows.Forms.TextBox insurIp;
        private System.Windows.Forms.TextBox lnameIp;
        private System.Windows.Forms.TextBox fnameIp;
        private System.Windows.Forms.Button findB;
        private System.Windows.Forms.TextBox passportLb;
        private System.Windows.Forms.TextBox genLb;
        private System.Windows.Forms.TextBox insurLb;
        private System.Windows.Forms.TextBox ageLb;
        private System.Windows.Forms.TextBox lnameLb;
        private System.Windows.Forms.TextBox fnameLb;
        private System.Windows.Forms.TextBox idLb;
        private System.Windows.Forms.TextBox idIp;
        private System.Windows.Forms.TextBox conLb;
        private System.Windows.Forms.NumericUpDown conIp;
        private System.Windows.Forms.TextBox disLb;
        private System.Windows.Forms.TextBox disIp;
    }
}