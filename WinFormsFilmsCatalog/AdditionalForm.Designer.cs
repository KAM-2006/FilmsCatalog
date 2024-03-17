namespace WinFormsFilmsCatalog
{
    partial class AdditionalForm
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
            this.lblTitleFilm = new System.Windows.Forms.Label();
            this.txtTitleFilm = new System.Windows.Forms.TextBox();
            this.btnFilmInfo = new System.Windows.Forms.Button();
            this.lblFilmInfo = new System.Windows.Forms.Label();
            this.lblFirstNameА = new System.Windows.Forms.Label();
            this.lblLastNameA = new System.Windows.Forms.Label();
            this.txtFirstNameA = new System.Windows.Forms.TextBox();
            this.txtLastNameA = new System.Windows.Forms.TextBox();
            this.btnShowFilmsByActor = new System.Windows.Forms.Button();
            this.FilmsOfActors = new System.Windows.Forms.ListBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.btnShowFilmsByGenre = new System.Windows.Forms.Button();
            this.FilmsOfGenre = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitleFilm
            // 
            this.lblTitleFilm.AutoSize = true;
            this.lblTitleFilm.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleFilm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTitleFilm.Location = new System.Drawing.Point(12, 20);
            this.lblTitleFilm.Name = "lblTitleFilm";
            this.lblTitleFilm.Size = new System.Drawing.Size(243, 25);
            this.lblTitleFilm.TabIndex = 0;
            this.lblTitleFilm.Text = "Въведи заглавие на филм";
            // 
            // txtTitleFilm
            // 
            this.txtTitleFilm.Location = new System.Drawing.Point(12, 59);
            this.txtTitleFilm.Name = "txtTitleFilm";
            this.txtTitleFilm.Size = new System.Drawing.Size(234, 23);
            this.txtTitleFilm.TabIndex = 1;
            // 
            // btnFilmInfo
            // 
            this.btnFilmInfo.BackColor = System.Drawing.Color.White;
            this.btnFilmInfo.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFilmInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFilmInfo.Location = new System.Drawing.Point(283, 20);
            this.btnFilmInfo.Name = "btnFilmInfo";
            this.btnFilmInfo.Size = new System.Drawing.Size(130, 62);
            this.btnFilmInfo.TabIndex = 2;
            this.btnFilmInfo.Text = "Show Film Info";
            this.btnFilmInfo.UseVisualStyleBackColor = false;
            this.btnFilmInfo.Click += new System.EventHandler(this.btnFilmInfo_Click);
            // 
            // lblFilmInfo
            // 
            this.lblFilmInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFilmInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFilmInfo.Location = new System.Drawing.Point(12, 107);
            this.lblFilmInfo.Name = "lblFilmInfo";
            this.lblFilmInfo.Size = new System.Drawing.Size(401, 23);
            this.lblFilmInfo.TabIndex = 3;
            // 
            // lblFirstNameА
            // 
            this.lblFirstNameА.AutoSize = true;
            this.lblFirstNameА.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstNameА.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblFirstNameА.Location = new System.Drawing.Point(12, 182);
            this.lblFirstNameА.Name = "lblFirstNameА";
            this.lblFirstNameА.Size = new System.Drawing.Size(209, 25);
            this.lblFirstNameА.TabIndex = 4;
            this.lblFirstNameА.Text = "Въведи име на актьор";
            // 
            // lblLastNameA
            // 
            this.lblLastNameA.AutoSize = true;
            this.lblLastNameA.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastNameA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLastNameA.Location = new System.Drawing.Point(12, 245);
            this.lblLastNameA.Name = "lblLastNameA";
            this.lblLastNameA.Size = new System.Drawing.Size(255, 25);
            this.lblLastNameA.TabIndex = 5;
            this.lblLastNameA.Text = "Въведи фамилия на актьор";
            // 
            // txtFirstNameA
            // 
            this.txtFirstNameA.Location = new System.Drawing.Point(12, 219);
            this.txtFirstNameA.Name = "txtFirstNameA";
            this.txtFirstNameA.Size = new System.Drawing.Size(204, 23);
            this.txtFirstNameA.TabIndex = 6;
            // 
            // txtLastNameA
            // 
            this.txtLastNameA.Location = new System.Drawing.Point(12, 283);
            this.txtLastNameA.Name = "txtLastNameA";
            this.txtLastNameA.Size = new System.Drawing.Size(248, 23);
            this.txtLastNameA.TabIndex = 7;
            // 
            // btnShowFilmsByActor
            // 
            this.btnShowFilmsByActor.BackColor = System.Drawing.Color.White;
            this.btnShowFilmsByActor.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowFilmsByActor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnShowFilmsByActor.Location = new System.Drawing.Point(283, 245);
            this.btnShowFilmsByActor.Name = "btnShowFilmsByActor";
            this.btnShowFilmsByActor.Size = new System.Drawing.Size(130, 61);
            this.btnShowFilmsByActor.TabIndex = 8;
            this.btnShowFilmsByActor.Text = "Show Films";
            this.btnShowFilmsByActor.UseVisualStyleBackColor = false;
            this.btnShowFilmsByActor.Click += new System.EventHandler(this.btnShowFilmsByActor_Click);
            // 
            // FilmsOfActors
            // 
            this.FilmsOfActors.FormattingEnabled = true;
            this.FilmsOfActors.ItemHeight = 15;
            this.FilmsOfActors.Location = new System.Drawing.Point(12, 330);
            this.FilmsOfActors.Name = "FilmsOfActors";
            this.FilmsOfActors.Size = new System.Drawing.Size(401, 94);
            this.FilmsOfActors.TabIndex = 9;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblGenre.Location = new System.Drawing.Point(12, 489);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(130, 25);
            this.lblGenre.TabIndex = 10;
            this.lblGenre.Text = "Въведи жанр";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(12, 528);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(204, 23);
            this.txtGenre.TabIndex = 11;
            // 
            // btnShowFilmsByGenre
            // 
            this.btnShowFilmsByGenre.BackColor = System.Drawing.Color.White;
            this.btnShowFilmsByGenre.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowFilmsByGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnShowFilmsByGenre.Location = new System.Drawing.Point(283, 489);
            this.btnShowFilmsByGenre.Name = "btnShowFilmsByGenre";
            this.btnShowFilmsByGenre.Size = new System.Drawing.Size(130, 62);
            this.btnShowFilmsByGenre.TabIndex = 12;
            this.btnShowFilmsByGenre.Text = "Show Films";
            this.btnShowFilmsByGenre.UseVisualStyleBackColor = false;
            this.btnShowFilmsByGenre.Click += new System.EventHandler(this.btnShowFilmsByGenre_Click);
            // 
            // FilmsOfGenre
            // 
            this.FilmsOfGenre.FormattingEnabled = true;
            this.FilmsOfGenre.ItemHeight = 15;
            this.FilmsOfGenre.Location = new System.Drawing.Point(12, 573);
            this.FilmsOfGenre.Name = "FilmsOfGenre";
            this.FilmsOfGenre.Size = new System.Drawing.Size(401, 109);
            this.FilmsOfGenre.TabIndex = 13;
            // 
            // AdditionalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(430, 749);
            this.Controls.Add(this.FilmsOfGenre);
            this.Controls.Add(this.btnShowFilmsByGenre);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.FilmsOfActors);
            this.Controls.Add(this.btnShowFilmsByActor);
            this.Controls.Add(this.txtLastNameA);
            this.Controls.Add(this.txtFirstNameA);
            this.Controls.Add(this.lblLastNameA);
            this.Controls.Add(this.lblFirstNameА);
            this.Controls.Add(this.lblFilmInfo);
            this.Controls.Add(this.btnFilmInfo);
            this.Controls.Add(this.txtTitleFilm);
            this.Controls.Add(this.lblTitleFilm);
            this.Name = "AdditionalForm";
            this.Text = "Допълнителни функционалности";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitleFilm;
        private TextBox txtTitleFilm;
        private Button btnFilmInfo;
        private Label lblFilmInfo;
        private Label lblFirstNameА;
        private Label lblLastNameA;
        private TextBox txtFirstNameA;
        private TextBox txtLastNameA;
        private Button btnShowFilmsByActor;
        private ListBox FilmsOfActors;
        private Label lblGenre;
        private TextBox txtGenre;
        private Button btnShowFilmsByGenre;
        private ListBox FilmsOfGenre;
    }
}