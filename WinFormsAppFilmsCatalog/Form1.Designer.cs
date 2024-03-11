namespace WinFormsAppFilmsCatalog
{
    partial class FrmStart
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblText = new Label();
            btnInsert = new Button();
            btnShow = new Button();
            btnOtherOperations = new Button();
            SuspendLayout();
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Font = new Font("Rockwell", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblText.ForeColor = SystemColors.ButtonHighlight;
            lblText.Location = new Point(12, 40);
            lblText.Name = "lblText";
            lblText.Size = new Size(738, 99);
            lblText.TabIndex = 0;
            lblText.Text = "Каталог за филми";
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.White;
            btnInsert.Font = new Font("Lucida Bright", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsert.ForeColor = Color.FromArgb(0, 192, 192);
            btnInsert.Location = new Point(164, 184);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(332, 109);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "Вмъкни информация в базата";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.White;
            btnShow.Font = new Font("Lucida Bright", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnShow.ForeColor = Color.FromArgb(0, 192, 192);
            btnShow.Location = new Point(164, 359);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(332, 109);
            btnShow.TabIndex = 2;
            btnShow.Text = "Покажи таблиците: Филми, Актьори, Жанр";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // btnOtherOperations
            // 
            btnOtherOperations.BackColor = Color.White;
            btnOtherOperations.Font = new Font("Lucida Bright", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnOtherOperations.ForeColor = Color.FromArgb(0, 192, 192);
            btnOtherOperations.Location = new Point(164, 534);
            btnOtherOperations.Name = "btnOtherOperations";
            btnOtherOperations.Size = new Size(332, 109);
            btnOtherOperations.TabIndex = 3;
            btnOtherOperations.Text = "Други функционалности";
            btnOtherOperations.UseVisualStyleBackColor = false;
            // 
            // FrmStart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(776, 823);
            Controls.Add(btnOtherOperations);
            Controls.Add(btnShow);
            Controls.Add(btnInsert);
            Controls.Add(lblText);
            Name = "FrmStart";
            Text = "StartForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblText;
        private Button btnInsert;
        private Button btnShow;
        private Button btnOtherOperations;
    }
}