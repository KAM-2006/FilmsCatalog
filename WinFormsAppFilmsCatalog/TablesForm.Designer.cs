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
            this.lblGenreG = new System.Windows.Forms.Label();
            this.lblGenreE2 = new System.Windows.Forms.Label();
            this.lblGenreE1 = new System.Windows.Forms.Label();
            this.lblGenreN = new System.Windows.Forms.Label();
            this.lblGenreR = new System.Windows.Forms.Label();
            this.gbGenre = new System.Windows.Forms.GroupBox();
            this.lblGenreName = new System.Windows.Forms.Label();
            this.txtGenreName = new System.Windows.Forms.TextBox();
            this.btnInsertGenre = new System.Windows.Forms.Button();
            this.btnUpdateGenre = new System.Windows.Forms.Button();
            this.btnSaveGenre = new System.Windows.Forms.Button();
            this.btnDeleteGenre = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnStartForm = new System.Windows.Forms.Button();
            this.btnOtherOperations = new System.Windows.Forms.Button();
            this.gbFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFilm)).BeginInit();
            this.gbGenre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // lblGenreG
            // 
            this.lblGenreG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblGenreG.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenreG.Location = new System.Drawing.Point(2, 4);
            this.lblGenreG.Name = "lblGenreG";
            this.lblGenreG.Size = new System.Drawing.Size(48, 46);
            this.lblGenreG.TabIndex = 18;
            this.lblGenreG.Text = "G";
            this.lblGenreG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenreE2
            // 
            this.lblGenreE2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblGenreE2.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenreE2.Location = new System.Drawing.Point(2, 197);
            this.lblGenreE2.Name = "lblGenreE2";
            this.lblGenreE2.Size = new System.Drawing.Size(48, 49);
            this.lblGenreE2.TabIndex = 22;
            this.lblGenreE2.Text = "E";
            this.lblGenreE2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenreE1
            // 
            this.lblGenreE1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblGenreE1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenreE1.Location = new System.Drawing.Point(2, 50);
            this.lblGenreE1.Name = "lblGenreE1";
            this.lblGenreE1.Size = new System.Drawing.Size(48, 49);
            this.lblGenreE1.TabIndex = 23;
            this.lblGenreE1.Text = "E";
            this.lblGenreE1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenreN
            // 
            this.lblGenreN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblGenreN.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenreN.Location = new System.Drawing.Point(2, 99);
            this.lblGenreN.Name = "lblGenreN";
            this.lblGenreN.Size = new System.Drawing.Size(48, 49);
            this.lblGenreN.TabIndex = 24;
            this.lblGenreN.Text = "N";
            this.lblGenreN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenreR
            // 
            this.lblGenreR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblGenreR.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenreR.Location = new System.Drawing.Point(2, 148);
            this.lblGenreR.Name = "lblGenreR";
            this.lblGenreR.Size = new System.Drawing.Size(48, 49);
            this.lblGenreR.TabIndex = 25;
            this.lblGenreR.Text = "R";
            this.lblGenreR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbGenre
            // 
            this.gbGenre.Controls.Add(this.lblGenreR);
            this.gbGenre.Controls.Add(this.lblGenreN);
            this.gbGenre.Controls.Add(this.lblGenreE1);
            this.gbGenre.Controls.Add(this.lblGenreE2);
            this.gbGenre.Controls.Add(this.lblGenreG);
            this.gbGenre.Location = new System.Drawing.Point(10, 540);
            this.gbGenre.Name = "gbGenre";
            this.gbGenre.Size = new System.Drawing.Size(50, 248);
            this.gbGenre.TabIndex = 26;
            this.gbGenre.TabStop = false;
            // 
            // lblGenreName
            // 
            this.lblGenreName.AutoSize = true;
            this.lblGenreName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenreName.Location = new System.Drawing.Point(66, 608);
            this.lblGenreName.Name = "lblGenreName";
            this.lblGenreName.Size = new System.Drawing.Size(210, 31);
            this.lblGenreName.TabIndex = 27;
            this.lblGenreName.Text = "Name of the genre:";
            // 
            // txtGenreName
            // 
            this.txtGenreName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGenreName.Location = new System.Drawing.Point(282, 609);
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.Size = new System.Drawing.Size(324, 30);
            this.txtGenreName.TabIndex = 28;
            // 
            // btnInsertGenre
            // 
            this.btnInsertGenre.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInsertGenre.Location = new System.Drawing.Point(66, 696);
            this.btnInsertGenre.Name = "btnInsertGenre";
            this.btnInsertGenre.Size = new System.Drawing.Size(110, 41);
            this.btnInsertGenre.TabIndex = 29;
            this.btnInsertGenre.Text = "Insert";
            this.btnInsertGenre.UseVisualStyleBackColor = true;
            // 
            // btnUpdateGenre
            // 
            this.btnUpdateGenre.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateGenre.Location = new System.Drawing.Point(207, 696);
            this.btnUpdateGenre.Name = "btnUpdateGenre";
            this.btnUpdateGenre.Size = new System.Drawing.Size(110, 41);
            this.btnUpdateGenre.TabIndex = 30;
            this.btnUpdateGenre.Text = "Update";
            this.btnUpdateGenre.UseVisualStyleBackColor = true;
            // 
            // btnSaveGenre
            // 
            this.btnSaveGenre.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveGenre.Location = new System.Drawing.Point(352, 696);
            this.btnSaveGenre.Name = "btnSaveGenre";
            this.btnSaveGenre.Size = new System.Drawing.Size(110, 41);
            this.btnSaveGenre.TabIndex = 31;
            this.btnSaveGenre.Text = "Save";
            this.btnSaveGenre.UseVisualStyleBackColor = true;
            // 
            // btnDeleteGenre
            // 
            this.btnDeleteGenre.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteGenre.Location = new System.Drawing.Point(496, 696);
            this.btnDeleteGenre.Name = "btnDeleteGenre";
            this.btnDeleteGenre.Size = new System.Drawing.Size(110, 41);
            this.btnDeleteGenre.TabIndex = 32;
            this.btnDeleteGenre.Text = "Delete";
            this.btnDeleteGenre.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(612, 540);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(543, 242);
            this.dataGridView1.TabIndex = 33;
            // 
            // btnStartForm
            // 
            this.btnStartForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStartForm.Location = new System.Drawing.Point(1363, 806);
            this.btnStartForm.Name = "btnStartForm";
            this.btnStartForm.Size = new System.Drawing.Size(112, 38);
            this.btnStartForm.TabIndex = 34;
            this.btnStartForm.Text = "Start Form";
            this.btnStartForm.UseVisualStyleBackColor = true;
            this.btnStartForm.Click += new System.EventHandler(this.btnStartForm_Click);
            // 
            // btnOtherOperations
            // 
            this.btnOtherOperations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOtherOperations.Location = new System.Drawing.Point(1481, 806);
            this.btnOtherOperations.Name = "btnOtherOperations";
            this.btnOtherOperations.Size = new System.Drawing.Size(172, 38);
            this.btnOtherOperations.TabIndex = 35;
            this.btnOtherOperations.Text = "Other operations";
            this.btnOtherOperations.UseVisualStyleBackColor = true;
            // 
            // TablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1665, 856);
            this.Controls.Add(this.btnOtherOperations);
            this.Controls.Add(this.btnStartForm);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteGenre);
            this.Controls.Add(this.btnSaveGenre);
            this.Controls.Add(this.btnUpdateGenre);
            this.Controls.Add(this.btnInsertGenre);
            this.Controls.Add(this.txtGenreName);
            this.Controls.Add(this.lblGenreName);
            this.Controls.Add(this.gbGenre);
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
            this.gbGenre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private Label lblGenreG;
        private Label lblGenreE2;
        private Label lblGenreE1;
        private Label lblGenreN;
        private Label lblGenreR;
        private GroupBox gbGenre;
        private Label lblGenreName;
        private TextBox txtGenreName;
        private Button btnInsertGenre;
        private Button btnUpdateGenre;
        private Button btnSaveGenre;
        private Button btnDeleteGenre;
        private DataGridView dataGridView1;
        private Button btnStartForm;
        private Button btnOtherOperations;
    }
}