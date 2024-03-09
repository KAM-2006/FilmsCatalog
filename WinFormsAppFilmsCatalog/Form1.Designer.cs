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
            button1 = new Button();
            SuspendLayout();
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Font = new Font("Rockwell", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblText.ForeColor = SystemColors.ButtonHighlight;
            lblText.Location = new Point(50, 48);
            lblText.Name = "lblText";
            lblText.Size = new Size(582, 99);
            lblText.TabIndex = 0;
            lblText.Text = "Films Catalog";
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
            btnInsert.Text = "Insert information into database";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
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
            btnShow.Text = "Show tables: films, actors and genre";
            btnShow.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Lucida Bright", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 192, 192);
            button1.Location = new Point(164, 534);
            button1.Name = "button1";
            button1.Size = new Size(332, 109);
            button1.TabIndex = 3;
            button1.Text = "Other database operations";
            button1.UseVisualStyleBackColor = false;
            // 
            // FrmStart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(676, 823);
            Controls.Add(button1);
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
        private Button button1;
    }
}