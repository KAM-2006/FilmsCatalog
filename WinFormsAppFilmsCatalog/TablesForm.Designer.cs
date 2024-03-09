namespace WinFormsAppFilmsCatalog
{
    partial class TablesForm
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
            this.lblF = new System.Windows.Forms.Label();
            this.lblI = new System.Windows.Forms.Label();
            this.lblL = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.gbFilm = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblDOR = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtDOR = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dGVFilm = new System.Windows.Forms.DataGridView();
            this.gbFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblF
            // 
            this.lblF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblF.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblF.Location = new System.Drawing.Point(1, 1);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(47, 43);
            this.lblF.TabIndex = 0;
            this.lblF.Text = "F";
            this.lblF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblI
            // 
            this.lblI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblI.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblI.Location = new System.Drawing.Point(1, 44);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(47, 46);
            this.lblI.TabIndex = 1;
            this.lblI.Text = "I";
            this.lblI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblL
            // 
            this.lblL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblL.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblL.Location = new System.Drawing.Point(1, 90);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(47, 46);
            this.lblL.TabIndex = 2;
            this.lblL.Text = "L";
            this.lblL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblM
            // 
            this.lblM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblM.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblM.Location = new System.Drawing.Point(1, 136);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(47, 49);
            this.lblM.TabIndex = 3;
            this.lblM.Text = "M";
            this.lblM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbFilm
            // 
            this.gbFilm.Controls.Add(this.lblM);
            this.gbFilm.Controls.Add(this.lblL);
            this.gbFilm.Controls.Add(this.lblI);
            this.gbFilm.Controls.Add(this.lblF);
            this.gbFilm.Location = new System.Drawing.Point(12, 21);
            this.gbFilm.Name = "gbFilm";
            this.gbFilm.Size = new System.Drawing.Size(48, 184);
            this.gbFilm.TabIndex = 4;
            this.gbFilm.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(66, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(63, 31);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Title:";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDirector.Location = new System.Drawing.Point(66, 77);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(101, 31);
            this.lblDirector.TabIndex = 6;
            this.lblDirector.Text = "Director:";
            // 
            // lblDOR
            // 
            this.lblDOR.AutoSize = true;
            this.lblDOR.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDOR.Location = new System.Drawing.Point(66, 123);
            this.lblDOR.Name = "lblDOR";
            this.lblDOR.Size = new System.Drawing.Size(171, 31);
            this.lblDOR.TabIndex = 7;
            this.lblDOR.Text = "Date of release:";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRating.Location = new System.Drawing.Point(66, 170);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(86, 31);
            this.lblRating.TabIndex = 8;
            this.lblRating.Text = "Rating:";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(135, 33);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(355, 30);
            this.txtTitle.TabIndex = 9;
            // 
            // txtDirector
            // 
            this.txtDirector.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDirector.Location = new System.Drawing.Point(173, 78);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(317, 30);
            this.txtDirector.TabIndex = 10;
            // 
            // txtDOR
            // 
            this.txtDOR.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDOR.Location = new System.Drawing.Point(243, 124);
            this.txtDOR.Name = "txtDOR";
            this.txtDOR.Size = new System.Drawing.Size(247, 30);
            this.txtDOR.TabIndex = 11;
            // 
            // txtRating
            // 
            this.txtRating.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRating.Location = new System.Drawing.Point(158, 171);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(332, 30);
            this.txtRating.TabIndex = 12;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInsert.Location = new System.Drawing.Point(496, 21);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(110, 41);
            this.btnInsert.TabIndex = 13;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(496, 65);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 41);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(496, 112);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 41);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(496, 159);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 41);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dGVFilm
            // 
            this.dGVFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVFilm.Location = new System.Drawing.Point(612, 21);
            this.dGVFilm.Name = "dGVFilm";
            this.dGVFilm.RowHeadersWidth = 51;
            this.dGVFilm.RowTemplate.Height = 29;
            this.dGVFilm.Size = new System.Drawing.Size(543, 180);
            this.dGVFilm.TabIndex = 17;
            // 
            // TablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1665, 856);
            this.Controls.Add(this.dGVFilm);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtDOR);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblDOR);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbFilm);
            this.Name = "TablesForm";
            this.Text = "TablesForm";
            this.Load += new System.EventHandler(this.TablesForm_Load);
            this.gbFilm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblF;
        private Label lblI;
        private Label lblL;
        private Label lblM;
        private GroupBox gbFilm;
        private Label lblTitle;
        private Label lblDirector;
        private Label lblDOR;
        private Label lblRating;
        private TextBox txtTitle;
        private TextBox txtDirector;
        private TextBox txtDOR;
        private TextBox txtRating;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnSave;
        private Button btnDelete;
        private DataGridView dGVFilm;
    }
}