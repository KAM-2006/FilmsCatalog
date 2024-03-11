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
            lblF = new Label();
            lblI = new Label();
            lblL = new Label();
            lblM = new Label();
            gbFilm = new GroupBox();
            lblTitle = new Label();
            lblDirector = new Label();
            lblDOR = new Label();
            lblRating = new Label();
            txtTitle = new TextBox();
            txtDirector = new TextBox();
            txtDOR = new TextBox();
            txtRating = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            dGVFilm = new DataGridView();
            lblGenreG = new Label();
            lblGenreE2 = new Label();
            lblGenreE1 = new Label();
            lblGenreN = new Label();
            lblGenreR = new Label();
            gbGenre = new GroupBox();
            lblGenreName = new Label();
            txtGenreName = new TextBox();
            btnInsertGenre = new Button();
            btnUpdateGenre = new Button();
            btnSaveGenre = new Button();
            btnDeleteGenre = new Button();
            dGVGenre = new DataGridView();
            btnStartForm = new Button();
            btnOtherOperations = new Button();
            groupBoxActor = new GroupBox();
            lblR = new Label();
            lblO = new Label();
            lblA = new Label();
            lblT = new Label();
            lblC = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblYears = new Label();
            lblDateOfBirth = new Label();
            lblText = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtYears = new TextBox();
            txtDOB = new TextBox();
            btnInsertActor = new Button();
            btnUpdateActor = new Button();
            btnSaveActor = new Button();
            btnDeleteActor = new Button();
            dGVActor = new DataGridView();
            btnConect = new Button();
            checkedListActor = new CheckedListBox();
            lblFilmInfo = new Label();
            lblGenreId = new Label();
            txtGenreIdFilm = new TextBox();
            lblTextG = new Label();
            gbFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVFilm).BeginInit();
            gbGenre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVGenre).BeginInit();
            groupBoxActor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVActor).BeginInit();
            SuspendLayout();
            // 
            // lblF
            // 
            lblF.BackColor = Color.FromArgb(255, 224, 192);
            lblF.Font = new Font("Showcard Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblF.Location = new Point(1, 3);
            lblF.Name = "lblF";
            lblF.Size = new Size(47, 43);
            lblF.TabIndex = 0;
            lblF.Text = "Ф";
            lblF.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblI
            // 
            lblI.BackColor = Color.FromArgb(255, 224, 192);
            lblI.Font = new Font("Showcard Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblI.Location = new Point(1, 45);
            lblI.Name = "lblI";
            lblI.Size = new Size(47, 45);
            lblI.TabIndex = 1;
            lblI.Text = "И";
            lblI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblL
            // 
            lblL.BackColor = Color.FromArgb(255, 224, 192);
            lblL.Font = new Font("Showcard Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblL.Location = new Point(1, 91);
            lblL.Name = "lblL";
            lblL.Size = new Size(47, 45);
            lblL.TabIndex = 2;
            lblL.Text = "Л";
            lblL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblM
            // 
            lblM.BackColor = Color.FromArgb(255, 224, 192);
            lblM.Font = new Font("Showcard Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblM.Location = new Point(1, 136);
            lblM.Name = "lblM";
            lblM.Size = new Size(47, 49);
            lblM.TabIndex = 3;
            lblM.Text = "М";
            lblM.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbFilm
            // 
            gbFilm.Controls.Add(lblM);
            gbFilm.Controls.Add(lblL);
            gbFilm.Controls.Add(lblI);
            gbFilm.Controls.Add(lblF);
            gbFilm.Location = new Point(14, 41);
            gbFilm.Name = "gbFilm";
            gbFilm.Size = new Size(46, 184);
            gbFilm.TabIndex = 4;
            gbFilm.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(66, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(63, 31);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Title:";
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDirector.Location = new Point(66, 77);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(101, 31);
            lblDirector.TabIndex = 6;
            lblDirector.Text = "Director:";
            // 
            // lblDOR
            // 
            lblDOR.AutoSize = true;
            lblDOR.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDOR.Location = new Point(66, 123);
            lblDOR.Name = "lblDOR";
            lblDOR.Size = new Size(171, 31);
            lblDOR.TabIndex = 7;
            lblDOR.Text = "Date of release:";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblRating.Location = new Point(66, 171);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(86, 31);
            lblRating.TabIndex = 8;
            lblRating.Text = "Rating:";
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(135, 33);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(355, 30);
            txtTitle.TabIndex = 9;
            // 
            // txtDirector
            // 
            txtDirector.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDirector.Location = new Point(173, 77);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(317, 30);
            txtDirector.TabIndex = 10;
            // 
            // txtDOR
            // 
            txtDOR.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDOR.Location = new Point(243, 124);
            txtDOR.Name = "txtDOR";
            txtDOR.Size = new Size(247, 30);
            txtDOR.TabIndex = 11;
            // 
            // txtRating
            // 
            txtRating.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtRating.Location = new Point(158, 171);
            txtRating.Name = "txtRating";
            txtRating.Size = new Size(332, 30);
            txtRating.TabIndex = 12;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsert.Location = new Point(497, 33);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(110, 41);
            btnInsert.TabIndex = 13;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(496, 132);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 41);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(496, 132);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 41);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(496, 220);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 41);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dGVFilm
            // 
            dGVFilm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVFilm.Location = new Point(613, 21);
            dGVFilm.Name = "dGVFilm";
            dGVFilm.RowHeadersWidth = 51;
            dGVFilm.RowTemplate.Height = 29;
            dGVFilm.Size = new Size(543, 232);
            dGVFilm.TabIndex = 17;
            // 
            // lblGenreG
            // 
            lblGenreG.BackColor = Color.Coral;
            lblGenreG.Font = new Font("Showcard Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenreG.Location = new Point(3, 54);
            lblGenreG.Name = "lblGenreG";
            lblGenreG.Size = new Size(48, 45);
            lblGenreG.TabIndex = 18;
            lblGenreG.Text = "Ж";
            lblGenreG.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGenreE2
            // 
            lblGenreE2.BackColor = Color.FromArgb(255, 192, 128);
            lblGenreE2.Font = new Font("Showcard Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenreE2.Location = new Point(12, 508);
            lblGenreE2.Name = "lblGenreE2";
            lblGenreE2.Size = new Size(48, 49);
            lblGenreE2.TabIndex = 22;
            lblGenreE2.Text = "Р";
            lblGenreE2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGenreE1
            // 
            lblGenreE1.BackColor = Color.Coral;
            lblGenreE1.Font = new Font("Showcard Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenreE1.Location = new Point(2, 99);
            lblGenreE1.Name = "lblGenreE1";
            lblGenreE1.Size = new Size(48, 49);
            lblGenreE1.TabIndex = 23;
            lblGenreE1.Text = "А";
            lblGenreE1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGenreN
            // 
            lblGenreN.BackColor = Color.Coral;
            lblGenreN.Font = new Font("Showcard Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenreN.Location = new Point(3, 148);
            lblGenreN.Name = "lblGenreN";
            lblGenreN.Size = new Size(48, 49);
            lblGenreN.TabIndex = 24;
            lblGenreN.Text = "Н";
            lblGenreN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGenreR
            // 
            lblGenreR.BackColor = Color.Coral;
            lblGenreR.Font = new Font("Showcard Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenreR.Location = new Point(3, 197);
            lblGenreR.Name = "lblGenreR";
            lblGenreR.Size = new Size(48, 49);
            lblGenreR.TabIndex = 25;
            lblGenreR.Text = "Р";
            lblGenreR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbGenre
            // 
            gbGenre.Controls.Add(lblGenreR);
            gbGenre.Controls.Add(lblGenreN);
            gbGenre.Controls.Add(lblGenreE1);
            gbGenre.Controls.Add(lblGenreG);
            gbGenre.Location = new Point(10, 540);
            gbGenre.Name = "gbGenre";
            gbGenre.Size = new Size(50, 248);
            gbGenre.TabIndex = 26;
            gbGenre.TabStop = false;
            // 
            // lblGenreName
            // 
            lblGenreName.AutoSize = true;
            lblGenreName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblGenreName.Location = new Point(66, 608);
            lblGenreName.Name = "lblGenreName";
            lblGenreName.Size = new Size(210, 31);
            lblGenreName.TabIndex = 27;
            lblGenreName.Text = "Name of the genre:";
            // 
            // txtGenreName
            // 
            txtGenreName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtGenreName.Location = new Point(282, 609);
            txtGenreName.Name = "txtGenreName";
            txtGenreName.Size = new Size(324, 30);
            txtGenreName.TabIndex = 28;
            // 
            // btnInsertGenre
            // 
            btnInsertGenre.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsertGenre.Location = new Point(66, 745);
            btnInsertGenre.Name = "btnInsertGenre";
            btnInsertGenre.Size = new Size(110, 41);
            btnInsertGenre.TabIndex = 29;
            btnInsertGenre.Text = "Insert";
            btnInsertGenre.UseVisualStyleBackColor = true;
            btnInsertGenre.Click += btnInsertGenre_Click;
            // 
            // btnUpdateGenre
            // 
            btnUpdateGenre.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateGenre.Location = new Point(326, 745);
            btnUpdateGenre.Name = "btnUpdateGenre";
            btnUpdateGenre.Size = new Size(110, 41);
            btnUpdateGenre.TabIndex = 30;
            btnUpdateGenre.Text = "Update";
            btnUpdateGenre.UseVisualStyleBackColor = true;
            btnUpdateGenre.Click += btnUpdateGenre_Click;
            // 
            // btnSaveGenre
            // 
            btnSaveGenre.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveGenre.Location = new Point(182, 745);
            btnSaveGenre.Name = "btnSaveGenre";
            btnSaveGenre.Size = new Size(110, 41);
            btnSaveGenre.TabIndex = 31;
            btnSaveGenre.Text = "Save";
            btnSaveGenre.UseVisualStyleBackColor = true;
            btnSaveGenre.Click += btnSaveGenre_Click;
            // 
            // btnDeleteGenre
            // 
            btnDeleteGenre.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteGenre.Location = new Point(496, 745);
            btnDeleteGenre.Name = "btnDeleteGenre";
            btnDeleteGenre.Size = new Size(110, 41);
            btnDeleteGenre.TabIndex = 32;
            btnDeleteGenre.Text = "Delete";
            btnDeleteGenre.UseVisualStyleBackColor = true;
            btnDeleteGenre.Click += btnDeleteGenre_Click;
            // 
            // dGVGenre
            // 
            dGVGenre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVGenre.Location = new Point(612, 567);
            dGVGenre.Name = "dGVGenre";
            dGVGenre.RowHeadersWidth = 51;
            dGVGenre.RowTemplate.Height = 29;
            dGVGenre.Size = new Size(543, 243);
            dGVGenre.TabIndex = 33;
            // 
            // btnStartForm
            // 
            btnStartForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStartForm.Location = new Point(1262, 827);
            btnStartForm.Name = "btnStartForm";
            btnStartForm.Size = new Size(112, 37);
            btnStartForm.TabIndex = 34;
            btnStartForm.Text = "Start Form";
            btnStartForm.UseVisualStyleBackColor = true;
            // 
            // btnOtherOperations
            // 
            btnOtherOperations.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOtherOperations.Location = new Point(1381, 827);
            btnOtherOperations.Name = "btnOtherOperations";
            btnOtherOperations.Size = new Size(171, 37);
            btnOtherOperations.TabIndex = 35;
            btnOtherOperations.Text = "Other operations";
            btnOtherOperations.UseVisualStyleBackColor = true;
            // 
            // groupBoxActor
            // 
            groupBoxActor.Controls.Add(lblR);
            groupBoxActor.Controls.Add(lblO);
            groupBoxActor.Controls.Add(lblA);
            groupBoxActor.Controls.Add(lblT);
            groupBoxActor.Controls.Add(lblC);
            groupBoxActor.Location = new Point(13, 285);
            groupBoxActor.Name = "groupBoxActor";
            groupBoxActor.Size = new Size(47, 235);
            groupBoxActor.TabIndex = 36;
            groupBoxActor.TabStop = false;
            // 
            // lblR
            // 
            lblR.BackColor = Color.FromArgb(255, 192, 128);
            lblR.Font = new Font("Showcard Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblR.Location = new Point(-1, 178);
            lblR.Name = "lblR";
            lblR.Size = new Size(47, 45);
            lblR.TabIndex = 38;
            lblR.Text = "О";
            lblR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblO
            // 
            lblO.BackColor = Color.FromArgb(255, 192, 128);
            lblO.Font = new Font("Showcard Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblO.Location = new Point(-1, 133);
            lblO.Name = "lblO";
            lblO.Size = new Size(47, 45);
            lblO.TabIndex = 37;
            lblO.Text = "ь";
            lblO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblA
            // 
            lblA.BackColor = Color.FromArgb(255, 192, 128);
            lblA.Font = new Font("Showcard Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblA.Location = new Point(0, 0);
            lblA.Name = "lblA";
            lblA.Size = new Size(47, 43);
            lblA.TabIndex = 0;
            lblA.Text = "А";
            lblA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblT
            // 
            lblT.BackColor = Color.FromArgb(255, 192, 128);
            lblT.Font = new Font("Showcard Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblT.Location = new Point(0, 88);
            lblT.Name = "lblT";
            lblT.Size = new Size(47, 45);
            lblT.TabIndex = 2;
            lblT.Text = "Т";
            lblT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblC
            // 
            lblC.BackColor = Color.FromArgb(255, 192, 128);
            lblC.Font = new Font("Showcard Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblC.Location = new Point(0, 43);
            lblC.Name = "lblC";
            lblC.Size = new Size(47, 45);
            lblC.TabIndex = 1;
            lblC.Text = "К";
            lblC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstName.Location = new Point(66, 321);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(125, 31);
            lblFirstName.TabIndex = 38;
            lblFirstName.Text = "First name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastName.Location = new Point(66, 367);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(123, 31);
            lblLastName.TabIndex = 39;
            lblLastName.Text = "Last name:";
            // 
            // lblYears
            // 
            lblYears.AutoSize = true;
            lblYears.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblYears.Location = new Point(69, 412);
            lblYears.Name = "lblYears";
            lblYears.Size = new Size(72, 31);
            lblYears.TabIndex = 40;
            lblYears.Text = "Years:";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateOfBirth.Location = new Point(69, 456);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(154, 31);
            lblDateOfBirth.TabIndex = 41;
            lblDateOfBirth.Text = "Date of birth: ";
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblText.Location = new Point(69, 275);
            lblText.Name = "lblText";
            lblText.Size = new Size(491, 31);
            lblText.TabIndex = 37;
            lblText.Text = "Въведете информация за таблицата Актьори:";
            lblText.Click += lblText_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(197, 321);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(293, 30);
            txtFirstName.TabIndex = 42;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(197, 371);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(293, 30);
            txtLastName.TabIndex = 43;
            // 
            // txtYears
            // 
            txtYears.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtYears.Location = new Point(146, 417);
            txtYears.Name = "txtYears";
            txtYears.Size = new Size(345, 30);
            txtYears.TabIndex = 44;
            // 
            // txtDOB
            // 
            txtDOB.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDOB.Location = new Point(217, 456);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(273, 30);
            txtDOB.TabIndex = 45;
            // 
            // btnInsertActor
            // 
            btnInsertActor.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsertActor.Location = new Point(496, 321);
            btnInsertActor.Name = "btnInsertActor";
            btnInsertActor.Size = new Size(110, 41);
            btnInsertActor.TabIndex = 46;
            btnInsertActor.Text = "Insert";
            btnInsertActor.UseVisualStyleBackColor = true;
            // 
            // btnUpdateActor
            // 
            btnUpdateActor.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateActor.Location = new Point(496, 384);
            btnUpdateActor.Name = "btnUpdateActor";
            btnUpdateActor.Size = new Size(110, 41);
            btnUpdateActor.TabIndex = 47;
            btnUpdateActor.Text = "Update";
            btnUpdateActor.UseVisualStyleBackColor = true;
            // 
            // btnSaveActor
            // 
            btnSaveActor.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveActor.Location = new Point(496, 384);
            btnSaveActor.Name = "btnSaveActor";
            btnSaveActor.Size = new Size(110, 41);
            btnSaveActor.TabIndex = 48;
            btnSaveActor.Text = "Save";
            btnSaveActor.UseVisualStyleBackColor = true;
            // 
            // btnDeleteActor
            // 
            btnDeleteActor.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteActor.Location = new Point(496, 444);
            btnDeleteActor.Name = "btnDeleteActor";
            btnDeleteActor.Size = new Size(110, 41);
            btnDeleteActor.TabIndex = 49;
            btnDeleteActor.Text = "Delete";
            btnDeleteActor.UseVisualStyleBackColor = true;
            // 
            // dGVActor
            // 
            dGVActor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVActor.Location = new Point(613, 307);
            dGVActor.Name = "dGVActor";
            dGVActor.RowHeadersWidth = 51;
            dGVActor.RowTemplate.Height = 29;
            dGVActor.Size = new Size(543, 180);
            dGVActor.TabIndex = 50;
            // 
            // btnConect
            // 
            btnConect.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnConect.Location = new Point(1385, 124);
            btnConect.Name = "btnConect";
            btnConect.Size = new Size(153, 101);
            btnConect.TabIndex = 51;
            btnConect.Text = "Connection";
            btnConect.UseVisualStyleBackColor = true;
            // 
            // checkedListActor
            // 
            checkedListActor.FormattingEnabled = true;
            checkedListActor.Location = new Point(1162, 33);
            checkedListActor.Name = "checkedListActor";
            checkedListActor.Size = new Size(215, 334);
            checkedListActor.TabIndex = 52;
            // 
            // lblFilmInfo
            // 
            lblFilmInfo.AutoSize = true;
            lblFilmInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblFilmInfo.Location = new Point(66, -1);
            lblFilmInfo.Name = "lblFilmInfo";
            lblFilmInfo.Size = new Size(475, 31);
            lblFilmInfo.TabIndex = 53;
            lblFilmInfo.Text = "Въведете информация за таблицата Филми:";
            lblFilmInfo.Click += label1_Click;
            // 
            // lblGenreId
            // 
            lblGenreId.AutoSize = true;
            lblGenreId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblGenreId.Location = new Point(69, 220);
            lblGenreId.Name = "lblGenreId";
            lblGenreId.Size = new Size(110, 32);
            lblGenreId.TabIndex = 54;
            lblGenreId.Text = "Genre Id:";
            lblGenreId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtGenreIdFilm
            // 
            txtGenreIdFilm.Location = new Point(167, 223);
            txtGenreIdFilm.Margin = new Padding(3, 4, 3, 4);
            txtGenreIdFilm.Name = "txtGenreIdFilm";
            txtGenreIdFilm.Size = new Size(323, 27);
            txtGenreIdFilm.TabIndex = 55;
            // 
            // lblTextG
            // 
            lblTextG.AutoSize = true;
            lblTextG.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTextG.Location = new Point(69, 567);
            lblTextG.Name = "lblTextG";
            lblTextG.Size = new Size(463, 31);
            lblTextG.TabIndex = 56;
            lblTextG.Text = "Въведете информация за таблицата Жанр:";
            // 
            // TablesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1566, 879);
            Controls.Add(lblTextG);
            Controls.Add(txtGenreIdFilm);
            Controls.Add(lblGenreId);
            Controls.Add(lblGenreE2);
            Controls.Add(lblFilmInfo);
            Controls.Add(checkedListActor);
            Controls.Add(btnConect);
            Controls.Add(dGVActor);
            Controls.Add(btnDeleteActor);
            Controls.Add(btnSaveActor);
            Controls.Add(btnUpdateActor);
            Controls.Add(btnInsertActor);
            Controls.Add(txtDOB);
            Controls.Add(txtYears);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblDateOfBirth);
            Controls.Add(lblYears);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblText);
            Controls.Add(groupBoxActor);
            Controls.Add(btnOtherOperations);
            Controls.Add(btnStartForm);
            Controls.Add(dGVGenre);
            Controls.Add(btnDeleteGenre);
            Controls.Add(btnSaveGenre);
            Controls.Add(btnUpdateGenre);
            Controls.Add(btnInsertGenre);
            Controls.Add(txtGenreName);
            Controls.Add(lblGenreName);
            Controls.Add(gbGenre);
            Controls.Add(dGVFilm);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtRating);
            Controls.Add(txtDOR);
            Controls.Add(txtDirector);
            Controls.Add(txtTitle);
            Controls.Add(lblRating);
            Controls.Add(lblDOR);
            Controls.Add(lblDirector);
            Controls.Add(lblTitle);
            Controls.Add(gbFilm);
            Name = "TablesForm";
            Text = "TablesForm";
            gbFilm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGVFilm).EndInit();
            gbGenre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGVGenre).EndInit();
            groupBoxActor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGVActor).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private DataGridView dGVGenre;
        private Button btnStartForm;
        private Button btnOtherOperations;
        private GroupBox groupBoxActor;
        private Label lblR;
        private Label lblO;
        private Label lblA;
        private Label lblT;
        private Label lblC;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblYears;
        private Label lblDateOfBirth;
        private Label lblText;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtYears;
        private TextBox txtDOB;
        private Button btnInsertActor;
        private Button btnUpdateActor;
        private Button btnSaveActor;
        private Button btnDeleteActor;
        private DataGridView dGVActor;
        private Button btnConect;
        private CheckedListBox checkedListActor;
        private Label lblFilmInfo;
        private Label lblGenreId;
        private TextBox txtGenreIdFilm;
        private Label lblTextG;
    }
}