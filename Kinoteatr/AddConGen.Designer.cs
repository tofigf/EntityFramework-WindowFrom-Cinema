namespace Kinoteatr
{
    partial class AddConGen
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
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.bntAdd = new System.Windows.Forms.Button();
            this.lblFilms = new System.Windows.Forms.Label();
            this.clbCountry = new System.Windows.Forms.CheckedListBox();
            this.clbGenre = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // cmbFilm
            // 
            this.cmbFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Location = new System.Drawing.Point(54, 31);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(179, 28);
            this.cmbFilm.TabIndex = 1;
            // 
            // bntAdd
            // 
            this.bntAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bntAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bntAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bntAdd.Location = new System.Drawing.Point(12, 304);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(119, 38);
            this.bntAdd.TabIndex = 4;
            this.bntAdd.Text = "Add";
            this.bntAdd.UseVisualStyleBackColor = false;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // lblFilms
            // 
            this.lblFilms.AutoSize = true;
            this.lblFilms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilms.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFilms.Location = new System.Drawing.Point(54, 9);
            this.lblFilms.Name = "lblFilms";
            this.lblFilms.Size = new System.Drawing.Size(49, 18);
            this.lblFilms.TabIndex = 4;
            this.lblFilms.Text = "Films";
            // 
            // clbCountry
            // 
            this.clbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clbCountry.FormattingEnabled = true;
            this.clbCountry.Location = new System.Drawing.Point(12, 111);
            this.clbCountry.Name = "clbCountry";
            this.clbCountry.Size = new System.Drawing.Size(166, 169);
            this.clbCountry.TabIndex = 2;
            // 
            // clbGenre
            // 
            this.clbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clbGenre.FormattingEnabled = true;
            this.clbGenre.Location = new System.Drawing.Point(205, 111);
            this.clbGenre.Name = "clbGenre";
            this.clbGenre.Size = new System.Drawing.Size(155, 175);
            this.clbGenre.TabIndex = 3;
            // 
            // AddConGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 354);
            this.Controls.Add(this.clbGenre);
            this.Controls.Add(this.clbCountry);
            this.Controls.Add(this.lblFilms);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.cmbFilm);
            this.Name = "AddConGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddConGen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddConGen_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Label lblFilms;
        private System.Windows.Forms.CheckedListBox clbCountry;
        private System.Windows.Forms.CheckedListBox clbGenre;
    }
}