namespace FOPRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.createB = new System.Windows.Forms.Button();
            this.findB = new System.Windows.Forms.Button();
            this.viewB = new System.Windows.Forms.Button();
            this.printB = new System.Windows.Forms.Button();
            this.mergeB = new System.Windows.Forms.Button();
            this.removeB = new System.Windows.Forms.Button();
            this.border = new System.Windows.Forms.Label();
            this.listPs = new System.Windows.Forms.ListView();
            this.idCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fnameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lnameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.conCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // createB
            // 
            this.createB.BackColor = System.Drawing.Color.Lavender;
            this.createB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.createB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createB.Location = new System.Drawing.Point(87, 19);
            this.createB.Name = "createB";
            this.createB.Size = new System.Drawing.Size(139, 35);
            this.createB.TabIndex = 10;
            this.createB.Text = "&Create";
            this.createB.UseVisualStyleBackColor = false;
            this.createB.Click += new System.EventHandler(this.createB_Click);
            // 
            // findB
            // 
            this.findB.BackColor = System.Drawing.Color.Lavender;
            this.findB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.findB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findB.Location = new System.Drawing.Point(297, 19);
            this.findB.Name = "findB";
            this.findB.Size = new System.Drawing.Size(139, 35);
            this.findB.TabIndex = 11;
            this.findB.Text = "&Find";
            this.findB.UseVisualStyleBackColor = false;
            this.findB.Click += new System.EventHandler(this.findB_Click);
            // 
            // viewB
            // 
            this.viewB.BackColor = System.Drawing.Color.Lavender;
            this.viewB.Enabled = false;
            this.viewB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.viewB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewB.Location = new System.Drawing.Point(87, 82);
            this.viewB.Name = "viewB";
            this.viewB.Size = new System.Drawing.Size(139, 35);
            this.viewB.TabIndex = 15;
            this.viewB.Text = "&View";
            this.viewB.UseVisualStyleBackColor = false;
            this.viewB.Click += new System.EventHandler(this.viewB_Click);
            // 
            // printB
            // 
            this.printB.BackColor = System.Drawing.Color.Lavender;
            this.printB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.printB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printB.Location = new System.Drawing.Point(505, 82);
            this.printB.Name = "printB";
            this.printB.Size = new System.Drawing.Size(139, 35);
            this.printB.TabIndex = 16;
            this.printB.Text = "&Print";
            this.printB.UseVisualStyleBackColor = false;
            this.printB.Click += new System.EventHandler(this.printB_Click);
            // 
            // mergeB
            // 
            this.mergeB.BackColor = System.Drawing.Color.Lavender;
            this.mergeB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mergeB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mergeB.Location = new System.Drawing.Point(505, 19);
            this.mergeB.MaximumSize = new System.Drawing.Size(139, 35);
            this.mergeB.MinimumSize = new System.Drawing.Size(139, 35);
            this.mergeB.Name = "mergeB";
            this.mergeB.Size = new System.Drawing.Size(139, 35);
            this.mergeB.TabIndex = 17;
            this.mergeB.Text = "&Merge";
            this.mergeB.UseVisualStyleBackColor = false;
            this.mergeB.Click += new System.EventHandler(this.mergeB_Click);
            // 
            // removeB
            // 
            this.removeB.BackColor = System.Drawing.Color.Lavender;
            this.removeB.Enabled = false;
            this.removeB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.removeB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeB.Location = new System.Drawing.Point(297, 82);
            this.removeB.Name = "removeB";
            this.removeB.Size = new System.Drawing.Size(139, 35);
            this.removeB.TabIndex = 18;
            this.removeB.Text = "&Remove";
            this.removeB.UseVisualStyleBackColor = false;
            this.removeB.Click += new System.EventHandler(this.removeB_Click);
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.Transparent;
            this.border.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.border.Location = new System.Drawing.Point(90, 66);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(550, 2);
            this.border.TabIndex = 19;
            // 
            // listPs
            // 
            this.listPs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPs.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listPs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idCol,
            this.fnameCol,
            this.lnameCol,
            this.genCol,
            this.conCol});
            this.listPs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPs.FullRowSelect = true;
            this.listPs.GridLines = true;
            this.listPs.HideSelection = false;
            this.listPs.Location = new System.Drawing.Point(28, 138);
            this.listPs.MaximumSize = new System.Drawing.Size(692, 596);
            this.listPs.MinimumSize = new System.Drawing.Size(692, 596);
            this.listPs.Name = "listPs";
            this.listPs.Size = new System.Drawing.Size(692, 596);
            this.listPs.TabIndex = 20;
            this.listPs.UseCompatibleStateImageBehavior = false;
            this.listPs.View = System.Windows.Forms.View.Details;
            this.listPs.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listPs_ColumnClick);
            this.listPs.SelectedIndexChanged += new System.EventHandler(this.listPs_SelectedIndexChanged);
            this.listPs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listPs_KeyDown);
            // 
            // idCol
            // 
            this.idCol.Text = "ID";
            this.idCol.Width = 55;
            // 
            // fnameCol
            // 
            this.fnameCol.Text = "First Name";
            this.fnameCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fnameCol.Width = 285;
            // 
            // lnameCol
            // 
            this.lnameCol.Text = "Last Name";
            this.lnameCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lnameCol.Width = 190;
            // 
            // genCol
            // 
            this.genCol.Text = "Gender";
            this.genCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.genCol.Width = 70;
            // 
            // conCol
            // 
            this.conCol.Text = "Condition";
            this.conCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.conCol.Width = 90;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(744, 758);
            this.Controls.Add(this.listPs);
            this.Controls.Add(this.border);
            this.Controls.Add(this.removeB);
            this.Controls.Add(this.mergeB);
            this.Controls.Add(this.printB);
            this.Controls.Add(this.viewB);
            this.Controls.Add(this.findB);
            this.Controls.Add(this.createB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(760, 797);
            this.MinimumSize = new System.Drawing.Size(760, 797);
            this.Name = "MainForm";
            this.Text = "FOPRM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Enter += new System.EventHandler(this.MainForm_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Leave += new System.EventHandler(this.MainForm_Leave);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button createB;
        private System.Windows.Forms.Button findB;
        private System.Windows.Forms.Button viewB;
        private System.Windows.Forms.Button printB;
        private System.Windows.Forms.Button mergeB;
        private System.Windows.Forms.Button removeB;
        private System.Windows.Forms.Label border;
        private System.Windows.Forms.ListView listPs;
        private System.Windows.Forms.ColumnHeader idCol;
        private System.Windows.Forms.ColumnHeader fnameCol;
        private System.Windows.Forms.ColumnHeader lnameCol;
        private System.Windows.Forms.ColumnHeader genCol;
        private System.Windows.Forms.ColumnHeader conCol;
    }
}

