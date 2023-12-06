namespace Rezervasyon_Sistemi.Forms
{
    partial class CompanyForm
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
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addTransButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.addTransSeatUpDown = new System.Windows.Forms.NumericUpDown();
            this.addTransTripCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addTripDateCombo = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.addTripRouteCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dailyRevDateCombo = new System.Windows.Forms.ComboBox();
            this.dailyRevButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dailyRevTextBox = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.allRevTextBox = new System.Windows.Forms.RichTextBox();
            this.allRevButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.deleteTransButton = new System.Windows.Forms.Button();
            this.deleteTransCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.deleteTripButton = new System.Windows.Forms.Button();
            this.deleteTripCombo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addTransSeatUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CompanyNameLabel.Location = new System.Drawing.Point(290, 9);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(340, 31);
            this.CompanyNameLabel.TabIndex = 0;
            this.CompanyNameLabel.Text = "X Firması Yönetim Paneli";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.addTransButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addTransSeatUpDown);
            this.panel1.Controls.Add(this.addTransTripCombo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(49, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 150);
            this.panel1.TabIndex = 1;
            // 
            // addTransButton
            // 
            this.addTransButton.BackColor = System.Drawing.Color.LightGreen;
            this.addTransButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTransButton.Location = new System.Drawing.Point(84, 107);
            this.addTransButton.Name = "addTransButton";
            this.addTransButton.Size = new System.Drawing.Size(75, 33);
            this.addTransButton.TabIndex = 5;
            this.addTransButton.Text = "Araç Ekle";
            this.addTransButton.UseVisualStyleBackColor = false;
            this.addTransButton.Click += new System.EventHandler(this.addTransButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Koltuk Sayısı";
            // 
            // addTransSeatUpDown
            // 
            this.addTransSeatUpDown.Location = new System.Drawing.Point(137, 58);
            this.addTransSeatUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.addTransSeatUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.addTransSeatUpDown.Name = "addTransSeatUpDown";
            this.addTransSeatUpDown.Size = new System.Drawing.Size(75, 20);
            this.addTransSeatUpDown.TabIndex = 4;
            this.addTransSeatUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addTransTripCombo
            // 
            this.addTransTripCombo.FormattingEnabled = true;
            this.addTransTripCombo.Location = new System.Drawing.Point(23, 31);
            this.addTransTripCombo.Name = "addTransTripCombo";
            this.addTransTripCombo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addTransTripCombo.Size = new System.Drawing.Size(189, 21);
            this.addTransTripCombo.TabIndex = 3;
            this.addTransTripCombo.Text = "Sefer Seçin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(64, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Araç Ekle";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.addTripDateCombo);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.addTripRouteCombo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(49, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 154);
            this.panel2.TabIndex = 8;
            // 
            // addTripDateCombo
            // 
            this.addTripDateCombo.FormattingEnabled = true;
            this.addTripDateCombo.Items.AddRange(new object[] {
            "04.12.2023",
            "05.12.2023",
            "06.12.2023",
            "07.12.2023",
            "08.12.2023",
            "09.12.2023",
            "10.12.2023"});
            this.addTripDateCombo.Location = new System.Drawing.Point(23, 58);
            this.addTripDateCombo.Name = "addTripDateCombo";
            this.addTripDateCombo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addTripDateCombo.Size = new System.Drawing.Size(189, 21);
            this.addTripDateCombo.TabIndex = 7;
            this.addTripDateCombo.Text = "Tarih Seçin";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(84, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "Araç Ekle";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // addTripRouteCombo
            // 
            this.addTripRouteCombo.FormattingEnabled = true;
            this.addTripRouteCombo.Location = new System.Drawing.Point(23, 31);
            this.addTripRouteCombo.Name = "addTripRouteCombo";
            this.addTripRouteCombo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addTripRouteCombo.Size = new System.Drawing.Size(189, 21);
            this.addTripRouteCombo.TabIndex = 6;
            this.addTripRouteCombo.Text = "Rota Seçin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(64, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sefer Ekle";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.dailyRevTextBox);
            this.panel3.Controls.Add(this.dailyRevDateCombo);
            this.panel3.Controls.Add(this.dailyRevButton);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(615, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 186);
            this.panel3.TabIndex = 9;
            // 
            // dailyRevDateCombo
            // 
            this.dailyRevDateCombo.FormattingEnabled = true;
            this.dailyRevDateCombo.Items.AddRange(new object[] {
            "04.12.2023",
            "05.12.2023",
            "06.12.2023",
            "07.12.2023",
            "08.12.2023",
            "09.12.2023",
            "10.12.2023"});
            this.dailyRevDateCombo.Location = new System.Drawing.Point(23, 31);
            this.dailyRevDateCombo.Name = "dailyRevDateCombo";
            this.dailyRevDateCombo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dailyRevDateCombo.Size = new System.Drawing.Size(189, 21);
            this.dailyRevDateCombo.TabIndex = 7;
            this.dailyRevDateCombo.Text = "Tarih Seçin";
            // 
            // dailyRevButton
            // 
            this.dailyRevButton.BackColor = System.Drawing.SystemColors.Info;
            this.dailyRevButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dailyRevButton.Location = new System.Drawing.Point(152, 58);
            this.dailyRevButton.Name = "dailyRevButton";
            this.dailyRevButton.Size = new System.Drawing.Size(75, 33);
            this.dailyRevButton.TabIndex = 8;
            this.dailyRevButton.Text = "Hesapla";
            this.dailyRevButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Günlük Kar Hesabı";
            // 
            // dailyRevTextBox
            // 
            this.dailyRevTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dailyRevTextBox.Location = new System.Drawing.Point(3, 107);
            this.dailyRevTextBox.Name = "dailyRevTextBox";
            this.dailyRevTextBox.ReadOnly = true;
            this.dailyRevTextBox.Size = new System.Drawing.Size(234, 76);
            this.dailyRevTextBox.TabIndex = 9;
            this.dailyRevTextBox.Text = "";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Controls.Add(this.allRevTextBox);
            this.panel4.Controls.Add(this.allRevButton);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(615, 271);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 186);
            this.panel4.TabIndex = 10;
            // 
            // allRevTextBox
            // 
            this.allRevTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.allRevTextBox.Location = new System.Drawing.Point(3, 79);
            this.allRevTextBox.Name = "allRevTextBox";
            this.allRevTextBox.ReadOnly = true;
            this.allRevTextBox.Size = new System.Drawing.Size(234, 104);
            this.allRevTextBox.TabIndex = 9;
            this.allRevTextBox.Text = "";
            // 
            // allRevButton
            // 
            this.allRevButton.BackColor = System.Drawing.SystemColors.Info;
            this.allRevButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allRevButton.Location = new System.Drawing.Point(152, 39);
            this.allRevButton.Name = "allRevButton";
            this.allRevButton.Size = new System.Drawing.Size(75, 33);
            this.allRevButton.TabIndex = 8;
            this.allRevButton.Text = "Hesapla";
            this.allRevButton.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(18, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Genel Kar Hesabı";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Controls.Add(this.deleteTransButton);
            this.panel5.Controls.Add(this.deleteTransCombo);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(314, 63);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(246, 150);
            this.panel5.TabIndex = 7;
            // 
            // deleteTransButton
            // 
            this.deleteTransButton.BackColor = System.Drawing.Color.Tomato;
            this.deleteTransButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteTransButton.Location = new System.Drawing.Point(84, 107);
            this.deleteTransButton.Name = "deleteTransButton";
            this.deleteTransButton.Size = new System.Drawing.Size(75, 33);
            this.deleteTransButton.TabIndex = 5;
            this.deleteTransButton.Text = "Araç Sil";
            this.deleteTransButton.UseVisualStyleBackColor = false;
            // 
            // deleteTransCombo
            // 
            this.deleteTransCombo.FormattingEnabled = true;
            this.deleteTransCombo.Location = new System.Drawing.Point(23, 31);
            this.deleteTransCombo.Name = "deleteTransCombo";
            this.deleteTransCombo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deleteTransCombo.Size = new System.Drawing.Size(189, 21);
            this.deleteTransCombo.TabIndex = 3;
            this.deleteTransCombo.Text = "Araç Seçin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(64, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Araç Sil";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel6.Controls.Add(this.deleteTripButton);
            this.panel6.Controls.Add(this.deleteTripCombo);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(314, 236);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(246, 150);
            this.panel6.TabIndex = 8;
            // 
            // deleteTripButton
            // 
            this.deleteTripButton.BackColor = System.Drawing.Color.Tomato;
            this.deleteTripButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteTripButton.Location = new System.Drawing.Point(83, 104);
            this.deleteTripButton.Name = "deleteTripButton";
            this.deleteTripButton.Size = new System.Drawing.Size(75, 33);
            this.deleteTripButton.TabIndex = 5;
            this.deleteTripButton.Text = "Sefer Sil";
            this.deleteTripButton.UseVisualStyleBackColor = false;
            // 
            // deleteTripCombo
            // 
            this.deleteTripCombo.FormattingEnabled = true;
            this.deleteTripCombo.Location = new System.Drawing.Point(23, 44);
            this.deleteTripCombo.Name = "deleteTripCombo";
            this.deleteTripCombo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deleteTripCombo.Size = new System.Drawing.Size(189, 21);
            this.deleteTripCombo.TabIndex = 3;
            this.deleteTripCombo.Text = "Sefer Seçin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(64, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Sefer Sil";
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 587);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CompanyNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompanyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CompanyForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addTransSeatUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox addTransTripCombo;
        private System.Windows.Forms.Button addTransButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown addTransSeatUpDown;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox addTripRouteCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox addTripDateCombo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox dailyRevDateCombo;
        private System.Windows.Forms.Button dailyRevButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox dailyRevTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox allRevTextBox;
        private System.Windows.Forms.Button allRevButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button deleteTransButton;
        private System.Windows.Forms.ComboBox deleteTransCombo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button deleteTripButton;
        private System.Windows.Forms.ComboBox deleteTripCombo;
        private System.Windows.Forms.Label label9;
    }
}