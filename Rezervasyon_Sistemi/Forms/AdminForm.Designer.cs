namespace Rezervasyon_Sistemi.Forms
{
    partial class AdminForm
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
            this.companyView = new System.Windows.Forms.DataGridView();
            this.companyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.companyAddNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.companyPassNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.compCreateButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.compDeleteComb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.compDeleteButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.oldAdminFeeBox = new System.Windows.Forms.TextBox();
            this.newAdminFeeUpDown = new System.Windows.Forms.NumericUpDown();
            this.newAdminFeeButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companyView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newAdminFeeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // companyView
            // 
            this.companyView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyId,
            this.companyName});
            this.companyView.Location = new System.Drawing.Point(31, 67);
            this.companyView.Name = "companyView";
            this.companyView.ReadOnly = true;
            this.companyView.RowHeadersVisible = false;
            this.companyView.Size = new System.Drawing.Size(203, 463);
            this.companyView.TabIndex = 0;
            // 
            // companyId
            // 
            this.companyId.HeaderText = "Firma Numarası";
            this.companyId.Name = "companyId";
            this.companyId.ReadOnly = true;
            // 
            // companyName
            // 
            this.companyName.HeaderText = "Firma İsmi";
            this.companyName.Name = "companyName";
            this.companyName.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(361, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin Paneli";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.compCreateButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.companyPassNameBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.companyAddNameBox);
            this.panel1.Location = new System.Drawing.Point(704, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 168);
            this.panel1.TabIndex = 2;
            // 
            // companyAddNameBox
            // 
            this.companyAddNameBox.Location = new System.Drawing.Point(15, 54);
            this.companyAddNameBox.Name = "companyAddNameBox";
            this.companyAddNameBox.Size = new System.Drawing.Size(166, 20);
            this.companyAddNameBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Firma Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Firma Şifresi";
            // 
            // companyPassNameBox
            // 
            this.companyPassNameBox.Location = new System.Drawing.Point(15, 100);
            this.companyPassNameBox.Name = "companyPassNameBox";
            this.companyPassNameBox.Size = new System.Drawing.Size(166, 20);
            this.companyPassNameBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(44, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Firma Oluştur";
            // 
            // compCreateButton
            // 
            this.compCreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.compCreateButton.Location = new System.Drawing.Point(54, 126);
            this.compCreateButton.Name = "compCreateButton";
            this.compCreateButton.Size = new System.Drawing.Size(146, 33);
            this.compCreateButton.TabIndex = 7;
            this.compCreateButton.Text = "Firma Oluştur";
            this.compCreateButton.UseVisualStyleBackColor = true;
            this.compCreateButton.Click += new System.EventHandler(this.compCreateButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.compDeleteButton);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.compDeleteComb);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(704, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 120);
            this.panel2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(50, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Firmayı Sil";
            // 
            // compDeleteComb
            // 
            this.compDeleteComb.FormattingEnabled = true;
            this.compDeleteComb.Location = new System.Drawing.Point(15, 58);
            this.compDeleteComb.Name = "compDeleteComb";
            this.compDeleteComb.Size = new System.Drawing.Size(170, 21);
            this.compDeleteComb.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Firma Seçimi";
            // 
            // compDeleteButton
            // 
            this.compDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.compDeleteButton.Location = new System.Drawing.Point(54, 85);
            this.compDeleteButton.Name = "compDeleteButton";
            this.compDeleteButton.Size = new System.Drawing.Size(139, 33);
            this.compDeleteButton.TabIndex = 8;
            this.compDeleteButton.Text = "Firmayı Sil";
            this.compDeleteButton.UseVisualStyleBackColor = true;
            this.compDeleteButton.Click += new System.EventHandler(this.compDeleteButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.newAdminFeeButton);
            this.panel3.Controls.Add(this.newAdminFeeUpDown);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.oldAdminFeeBox);
            this.panel3.Location = new System.Drawing.Point(704, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 150);
            this.panel3.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(97, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 33);
            this.button3.TabIndex = 8;
            this.button3.Text = "Firmayı Sil";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(39, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Admin Ücreti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Yeni Admin Ücreti";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Eski Admin Ücreti";
            // 
            // oldAdminFeeBox
            // 
            this.oldAdminFeeBox.BackColor = System.Drawing.SystemColors.Window;
            this.oldAdminFeeBox.Location = new System.Drawing.Point(16, 44);
            this.oldAdminFeeBox.Name = "oldAdminFeeBox";
            this.oldAdminFeeBox.ReadOnly = true;
            this.oldAdminFeeBox.Size = new System.Drawing.Size(169, 20);
            this.oldAdminFeeBox.TabIndex = 9999;
            // 
            // newAdminFeeUpDown
            // 
            this.newAdminFeeUpDown.Location = new System.Drawing.Point(16, 90);
            this.newAdminFeeUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.newAdminFeeUpDown.Name = "newAdminFeeUpDown";
            this.newAdminFeeUpDown.Size = new System.Drawing.Size(169, 20);
            this.newAdminFeeUpDown.TabIndex = 11;
            // 
            // newAdminFeeButton
            // 
            this.newAdminFeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newAdminFeeButton.Location = new System.Drawing.Point(54, 114);
            this.newAdminFeeButton.Name = "newAdminFeeButton";
            this.newAdminFeeButton.Size = new System.Drawing.Size(139, 33);
            this.newAdminFeeButton.TabIndex = 8;
            this.newAdminFeeButton.Text = "Admin Ücreti Belirle";
            this.newAdminFeeButton.UseVisualStyleBackColor = true;
            this.newAdminFeeButton.Click += new System.EventHandler(this.newAdminFeeButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(75, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Açık Firmalar";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 587);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.companyView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.companyView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newAdminFeeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView companyView;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox companyPassNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox companyAddNameBox;
        private System.Windows.Forms.Button compCreateButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button compDeleteButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox compDeleteComb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button newAdminFeeButton;
        private System.Windows.Forms.NumericUpDown newAdminFeeUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox oldAdminFeeBox;
        private System.Windows.Forms.Label label10;
    }
}