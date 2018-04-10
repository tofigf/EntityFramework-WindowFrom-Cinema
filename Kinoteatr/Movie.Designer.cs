namespace Kinoteatr
{
    partial class Movie
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.rtxtAbout = new System.Windows.Forms.RichTextBox();
            this.rbtn3D = new System.Windows.Forms.RadioButton();
            this.dtpPrimiere = new System.Windows.Forms.DateTimePicker();
            this.lblName = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.lblDirector = new System.Windows.Forms.Label();
            this.txtAgeRes = new System.Windows.Forms.TextBox();
            this.lblAgeRes = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblPremyera = new System.Windows.Forms.Label();
            this.lbl3D = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.clbLanguage = new System.Windows.Forms.CheckedListBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.clbSub = new System.Windows.Forms.CheckedListBox();
            this.lblSub = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddInfo = new System.Windows.Forms.Label();
            this.btnAddContrGenre = new System.Windows.Forms.Button();
            this.lblClikHere = new System.Windows.Forms.Label();
            this.lblErrorInfo = new System.Windows.Forms.Label();
            this.btnCreatePoster = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvFilms = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtYear.Location = new System.Drawing.Point(12, 113);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(145, 26);
            this.txtYear.TabIndex = 2;
            // 
            // rtxtAbout
            // 
            this.rtxtAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtxtAbout.Location = new System.Drawing.Point(197, 220);
            this.rtxtAbout.Name = "rtxtAbout";
            this.rtxtAbout.Size = new System.Drawing.Size(198, 96);
            this.rtxtAbout.TabIndex = 8;
            this.rtxtAbout.Text = " ";
            // 
            // rbtn3D
            // 
            this.rbtn3D.AutoSize = true;
            this.rbtn3D.Location = new System.Drawing.Point(251, 126);
            this.rbtn3D.Name = "rbtn3D";
            this.rbtn3D.Size = new System.Drawing.Size(14, 13);
            this.rbtn3D.TabIndex = 7;
            this.rbtn3D.TabStop = true;
            this.rbtn3D.UseVisualStyleBackColor = true;
            // 
            // dtpPrimiere
            // 
            this.dtpPrimiere.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpPrimiere.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPrimiere.Location = new System.Drawing.Point(182, 36);
            this.dtpPrimiere.Name = "dtpPrimiere";
            this.dtpPrimiere.Size = new System.Drawing.Size(213, 24);
            this.dtpPrimiere.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(20, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 18);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name *";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYear.Location = new System.Drawing.Point(12, 76);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(54, 18);
            this.lblYear.TabIndex = 14;
            this.lblYear.Text = "Year *";
            // 
            // txtDirector
            // 
            this.txtDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDirector.Location = new System.Drawing.Point(12, 183);
            this.txtDirector.MaxLength = 500;
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(145, 26);
            this.txtDirector.TabIndex = 3;
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDirector.Location = new System.Drawing.Point(12, 149);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(81, 18);
            this.lblDirector.TabIndex = 16;
            this.lblDirector.Text = "Director *";
            // 
            // txtAgeRes
            // 
            this.txtAgeRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAgeRes.Location = new System.Drawing.Point(12, 274);
            this.txtAgeRes.MaxLength = 3;
            this.txtAgeRes.Name = "txtAgeRes";
            this.txtAgeRes.Size = new System.Drawing.Size(145, 26);
            this.txtAgeRes.TabIndex = 4;
            // 
            // lblAgeRes
            // 
            this.lblAgeRes.AutoSize = true;
            this.lblAgeRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAgeRes.Location = new System.Drawing.Point(12, 234);
            this.lblAgeRes.Name = "lblAgeRes";
            this.lblAgeRes.Size = new System.Drawing.Size(136, 18);
            this.lblAgeRes.TabIndex = 18;
            this.lblAgeRes.Text = "Age-Restricted  *";
            // 
            // txtDuration
            // 
            this.txtDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDuration.Location = new System.Drawing.Point(12, 368);
            this.txtDuration.MaxLength = 5;
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(145, 26);
            this.txtDuration.TabIndex = 5;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDuration.Location = new System.Drawing.Point(12, 330);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(84, 18);
            this.lblDuration.TabIndex = 20;
            this.lblDuration.Text = "Duration *";
            // 
            // lblPremyera
            // 
            this.lblPremyera.AutoSize = true;
            this.lblPremyera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPremyera.Location = new System.Drawing.Point(194, 9);
            this.lblPremyera.Name = "lblPremyera";
            this.lblPremyera.Size = new System.Drawing.Size(83, 18);
            this.lblPremyera.TabIndex = 21;
            this.lblPremyera.Text = "Primiere *";
            // 
            // lbl3D
            // 
            this.lbl3D.AutoSize = true;
            this.lbl3D.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl3D.Location = new System.Drawing.Point(194, 122);
            this.lbl3D.Name = "lbl3D";
            this.lbl3D.Size = new System.Drawing.Size(42, 18);
            this.lbl3D.TabIndex = 22;
            this.lbl3D.Text = "Is3D";
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAbout.Location = new System.Drawing.Point(214, 183);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(51, 18);
            this.lblAbout.TabIndex = 23;
            this.lblAbout.Text = "About";
            // 
            // clbLanguage
            // 
            this.clbLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clbLanguage.FormattingEnabled = true;
            this.clbLanguage.Location = new System.Drawing.Point(442, 76);
            this.clbLanguage.Name = "clbLanguage";
            this.clbLanguage.Size = new System.Drawing.Size(159, 194);
            this.clbLanguage.TabIndex = 9;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLanguage.Location = new System.Drawing.Point(475, 41);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(101, 18);
            this.lblLanguage.TabIndex = 27;
            this.lblLanguage.Text = "Languages *";
            // 
            // clbSub
            // 
            this.clbSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clbSub.FormattingEnabled = true;
            this.clbSub.Location = new System.Drawing.Point(672, 76);
            this.clbSub.Name = "clbSub";
            this.clbSub.Size = new System.Drawing.Size(159, 194);
            this.clbSub.TabIndex = 10;
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSub.Location = new System.Drawing.Point(694, 42);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(109, 18);
            this.lblSub.TabIndex = 29;
            this.lblSub.Text = "Subtutitiries *";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(414, 368);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(332, 40);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblError.ForeColor = System.Drawing.Color.Maroon;
            this.lblError.Location = new System.Drawing.Point(9, 422);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 31);
            this.lblError.TabIndex = 33;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(12, 37);
            this.txtName.MaxLength = 500;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 26);
            this.txtName.TabIndex = 1;
            // 
            // lblAddInfo
            // 
            this.lblAddInfo.AutoSize = true;
            this.lblAddInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddInfo.ForeColor = System.Drawing.Color.Teal;
            this.lblAddInfo.Location = new System.Drawing.Point(411, 319);
            this.lblAddInfo.Name = "lblAddInfo";
            this.lblAddInfo.Size = new System.Drawing.Size(420, 18);
            this.lblAddInfo.TabIndex = 35;
            this.lblAddInfo.Text = "After adding films you have to select country and genre";
            this.lblAddInfo.Visible = false;
            // 
            // btnAddContrGenre
            // 
            this.btnAddContrGenre.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAddContrGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddContrGenre.Location = new System.Drawing.Point(864, 122);
            this.btnAddContrGenre.Name = "btnAddContrGenre";
            this.btnAddContrGenre.Size = new System.Drawing.Size(329, 40);
            this.btnAddContrGenre.TabIndex = 12;
            this.btnAddContrGenre.Text = "Add Country and Genre";
            this.btnAddContrGenre.UseVisualStyleBackColor = false;
            this.btnAddContrGenre.Click += new System.EventHandler(this.btnAddContrGenre_Click);
            // 
            // lblClikHere
            // 
            this.lblClikHere.AutoSize = true;
            this.lblClikHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClikHere.ForeColor = System.Drawing.Color.Teal;
            this.lblClikHere.Location = new System.Drawing.Point(861, 76);
            this.lblClikHere.Name = "lblClikHere";
            this.lblClikHere.Size = new System.Drawing.Size(91, 18);
            this.lblClikHere.TabIndex = 41;
            this.lblClikHere.Text = "Click Here!";
            // 
            // lblErrorInfo
            // 
            this.lblErrorInfo.AutoSize = true;
            this.lblErrorInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblErrorInfo.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorInfo.Location = new System.Drawing.Point(862, 223);
            this.lblErrorInfo.Name = "lblErrorInfo";
            this.lblErrorInfo.Size = new System.Drawing.Size(0, 18);
            this.lblErrorInfo.TabIndex = 42;
            this.lblErrorInfo.Visible = false;
            // 
            // btnCreatePoster
            // 
            this.btnCreatePoster.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCreatePoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreatePoster.Location = new System.Drawing.Point(865, 260);
            this.btnCreatePoster.Name = "btnCreatePoster";
            this.btnCreatePoster.Size = new System.Drawing.Size(332, 40);
            this.btnCreatePoster.TabIndex = 13;
            this.btnCreatePoster.Text = "Create Poster";
            this.btnCreatePoster.UseVisualStyleBackColor = false;
            this.btnCreatePoster.Click += new System.EventHandler(this.btnCreatePoster_Click);
            this.btnCreatePoster.MouseHover += new System.EventHandler(this.btnCreatePoster_MouseHover);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(414, 433);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(332, 40);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Delete Film Info";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvFilms
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFilms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column10,
            this.Column12,
            this.Column13,
            this.Column11,
            this.Column9,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFilms.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvFilms.Location = new System.Drawing.Point(2, 537);
            this.dgvFilms.Name = "dgvFilms";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFilms.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvFilms.Size = new System.Drawing.Size(1297, 150);
            this.dgvFilms.TabIndex = 47;
            this.dgvFilms.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFilms_RowHeaderMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Year";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Director";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "AgeRes";
            this.Column5.Name = "Column5";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Duration";
            this.Column10.Name = "Column10";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Language";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Subtuties";
            this.Column13.Name = "Column13";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Primeire";
            this.Column11.Name = "Column11";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "is3D";
            this.Column9.Name = "Column9";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "About";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Photo";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Trailer";
            this.Column8.Name = "Column8";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(414, 491);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(332, 40);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "Update Film Info";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvFilms);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreatePoster);
            this.Controls.Add(this.lblErrorInfo);
            this.Controls.Add(this.lblClikHere);
            this.Controls.Add(this.btnAddContrGenre);
            this.Controls.Add(this.lblAddInfo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.clbSub);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.clbLanguage);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.lbl3D);
            this.Controls.Add(this.lblPremyera);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.lblAgeRes);
            this.Controls.Add(this.txtAgeRes);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dtpPrimiere);
            this.Controls.Add(this.rbtn3D);
            this.Controls.Add(this.rtxtAbout);
            this.Controls.Add(this.txtYear);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Movie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.RichTextBox rtxtAbout;
        private System.Windows.Forms.RadioButton rbtn3D;
        private System.Windows.Forms.DateTimePicker dtpPrimiere;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.TextBox txtAgeRes;
        private System.Windows.Forms.Label lblAgeRes;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblPremyera;
        private System.Windows.Forms.Label lbl3D;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.CheckedListBox clbLanguage;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.CheckedListBox clbSub;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAddInfo;
        private System.Windows.Forms.Button btnAddContrGenre;
        private System.Windows.Forms.Label lblClikHere;
        private System.Windows.Forms.Label lblErrorInfo;
        private System.Windows.Forms.Button btnCreatePoster;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvFilms;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btnUpdate;
    }
}

