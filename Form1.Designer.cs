namespace WindowsFormsApp2
{
    partial class Form1
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtOgrTc = new System.Windows.Forms.TextBox();
            this.txtOgrSurname = new System.Windows.Forms.TextBox();
            this.txtOgrName = new System.Windows.Forms.TextBox();
            this.txtOgrNumber = new System.Windows.Forms.TextBox();
            this.cmbOgrFaculty = new System.Windows.Forms.ComboBox();
            this.cmbBloodType = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetByID = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.label8.Location = new System.Drawing.Point(11, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(388, 55);
            this.label8.TabIndex = 58;
            this.label8.Text = "Öğrenci Bİlgi Sistemi";
            // 
            // txtOgrTc
            // 
            this.txtOgrTc.Location = new System.Drawing.Point(195, 268);
            this.txtOgrTc.MaxLength = 11;
            this.txtOgrTc.Name = "txtOgrTc";
            this.txtOgrTc.Size = new System.Drawing.Size(218, 22);
            this.txtOgrTc.TabIndex = 56;
            // 
            // txtOgrSurname
            // 
            this.txtOgrSurname.Location = new System.Drawing.Point(195, 190);
            this.txtOgrSurname.Name = "txtOgrSurname";
            this.txtOgrSurname.Size = new System.Drawing.Size(218, 22);
            this.txtOgrSurname.TabIndex = 55;
            // 
            // txtOgrName
            // 
            this.txtOgrName.Location = new System.Drawing.Point(195, 144);
            this.txtOgrName.Name = "txtOgrName";
            this.txtOgrName.Size = new System.Drawing.Size(218, 22);
            this.txtOgrName.TabIndex = 54;
            // 
            // txtOgrNumber
            // 
            this.txtOgrNumber.Location = new System.Drawing.Point(195, 99);
            this.txtOgrNumber.Name = "txtOgrNumber";
            this.txtOgrNumber.Size = new System.Drawing.Size(218, 22);
            this.txtOgrNumber.TabIndex = 53;
            // 
            // cmbOgrFaculty
            // 
            this.cmbOgrFaculty.FormattingEnabled = true;
            this.cmbOgrFaculty.Location = new System.Drawing.Point(195, 229);
            this.cmbOgrFaculty.Name = "cmbOgrFaculty";
            this.cmbOgrFaculty.Size = new System.Drawing.Size(218, 24);
            this.cmbOgrFaculty.TabIndex = 52;
            // 
            // cmbBloodType
            // 
            this.cmbBloodType.FormattingEnabled = true;
            this.cmbBloodType.Location = new System.Drawing.Point(195, 344);
            this.cmbBloodType.Name = "cmbBloodType";
            this.cmbBloodType.Size = new System.Drawing.Size(103, 24);
            this.cmbBloodType.TabIndex = 51;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(176)))), ((int)(((byte)(190)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(430, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1005, 438);
            this.dataGridView1.TabIndex = 50;
            // 
            // btnGetByID
            // 
            this.btnGetByID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnGetByID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetByID.Location = new System.Drawing.Point(161, 428);
            this.btnGetByID.Name = "btnGetByID";
            this.btnGetByID.Size = new System.Drawing.Size(137, 35);
            this.btnGetByID.TabIndex = 49;
            this.btnGetByID.Text = "ID\'e Göre Listele";
            this.btnGetByID.UseVisualStyleBackColor = false;
            this.btnGetByID.Click += new System.EventHandler(this.btnGetByID_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(329, 387);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 35);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(241, 387);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 35);
            this.btnUpdate.TabIndex = 47;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(144, 387);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 35);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnList.Location = new System.Drawing.Point(55, 387);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(83, 35);
            this.btnList.TabIndex = 45;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label7.Location = new System.Drawing.Point(27, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 17);
            this.label7.TabIndex = 44;
            this.label7.Text = "Öğrenci Kan Grubu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label6.Location = new System.Drawing.Point(6, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Öğrenci Doğum Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label5.Location = new System.Drawing.Point(86, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Öğrenci TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label4.Location = new System.Drawing.Point(50, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Öğrenci Fakülte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label3.Location = new System.Drawing.Point(58, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Öğrenci Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label2.Location = new System.Drawing.Point(77, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Öğrenci İsmi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(38, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Öğrenci Numarası:";
            // 
            // dtBirthday
            // 
            this.dtBirthday.Location = new System.Drawing.Point(195, 307);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(200, 22);
            this.dtBirthday.TabIndex = 59;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1457, 477);
            this.Controls.Add(this.dtBirthday);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOgrTc);
            this.Controls.Add(this.txtOgrSurname);
            this.Controls.Add(this.txtOgrName);
            this.Controls.Add(this.txtOgrNumber);
            this.Controls.Add(this.cmbOgrFaculty);
            this.Controls.Add(this.cmbBloodType);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGetByID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOgrTc;
        private System.Windows.Forms.TextBox txtOgrSurname;
        private System.Windows.Forms.TextBox txtOgrName;
        private System.Windows.Forms.TextBox txtOgrNumber;
        private System.Windows.Forms.ComboBox cmbOgrFaculty;
        private System.Windows.Forms.ComboBox cmbBloodType;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetByID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtBirthday;
    }
}

