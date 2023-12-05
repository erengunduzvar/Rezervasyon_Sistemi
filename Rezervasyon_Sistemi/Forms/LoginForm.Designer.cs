namespace Rezervasyon_Sistemi.Forms
{
    partial class LoginForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.admin_panel = new System.Windows.Forms.Panel();
            this.admin_ticket = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.admin_password_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.admin_username_text = new System.Windows.Forms.TextBox();
            this.firma_panel = new System.Windows.Forms.Panel();
            this.testButton = new System.Windows.Forms.Button();
            this.firma_ticket = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.startPosComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.user_panel = new System.Windows.Forms.Panel();
            this.tripSearchButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.vehicleTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.endPosComboBox = new System.Windows.Forms.ComboBox();
            this.passangerCounterNum = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.admin_panel.SuspendLayout();
            this.firma_panel.SuspendLayout();
            this.user_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passangerCounterNum)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.firmaToolStripMenuItem,
            this.kullanıcıToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(178, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // firmaToolStripMenuItem
            // 
            this.firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.firmaToolStripMenuItem.Text = "Firma";
            this.firmaToolStripMenuItem.Click += new System.EventHandler(this.firmaToolStripMenuItem_Click);
            // 
            // kullanıcıToolStripMenuItem
            // 
            this.kullanıcıToolStripMenuItem.Name = "kullanıcıToolStripMenuItem";
            this.kullanıcıToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.kullanıcıToolStripMenuItem.Text = "Bilet Ara ";
            this.kullanıcıToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 20);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // admin_panel
            // 
            this.admin_panel.Controls.Add(this.admin_ticket);
            this.admin_panel.Controls.Add(this.label3);
            this.admin_panel.Controls.Add(this.button1);
            this.admin_panel.Controls.Add(this.label2);
            this.admin_panel.Controls.Add(this.admin_password_text);
            this.admin_panel.Controls.Add(this.label1);
            this.admin_panel.Controls.Add(this.admin_username_text);
            this.admin_panel.Location = new System.Drawing.Point(29, 27);
            this.admin_panel.Name = "admin_panel";
            this.admin_panel.Size = new System.Drawing.Size(842, 513);
            this.admin_panel.TabIndex = 1;
            this.admin_panel.Visible = false;
            // 
            // admin_ticket
            // 
            this.admin_ticket.BackColor = System.Drawing.Color.Yellow;
            this.admin_ticket.Location = new System.Drawing.Point(479, 281);
            this.admin_ticket.Name = "admin_ticket";
            this.admin_ticket.Size = new System.Drawing.Size(64, 28);
            this.admin_ticket.TabIndex = 6;
            this.admin_ticket.Text = "Bilet Ara";
            this.admin_ticket.UseVisualStyleBackColor = false;
            this.admin_ticket.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(311, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Admin Giriş";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Location = new System.Drawing.Point(367, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Giriş Yap ->";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // admin_password_text
            // 
            this.admin_password_text.Location = new System.Drawing.Point(282, 245);
            this.admin_password_text.Name = "admin_password_text";
            this.admin_password_text.Size = new System.Drawing.Size(261, 20);
            this.admin_password_text.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // admin_username_text
            // 
            this.admin_username_text.Location = new System.Drawing.Point(282, 199);
            this.admin_username_text.Name = "admin_username_text";
            this.admin_username_text.Size = new System.Drawing.Size(261, 20);
            this.admin_username_text.TabIndex = 0;
            // 
            // firma_panel
            // 
            this.firma_panel.Controls.Add(this.testButton);
            this.firma_panel.Controls.Add(this.firma_ticket);
            this.firma_panel.Controls.Add(this.label4);
            this.firma_panel.Controls.Add(this.button2);
            this.firma_panel.Controls.Add(this.label5);
            this.firma_panel.Controls.Add(this.textBox3);
            this.firma_panel.Controls.Add(this.label6);
            this.firma_panel.Controls.Add(this.textBox4);
            this.firma_panel.Location = new System.Drawing.Point(28, 28);
            this.firma_panel.Name = "firma_panel";
            this.firma_panel.Size = new System.Drawing.Size(842, 513);
            this.firma_panel.TabIndex = 6;
            this.firma_panel.Visible = false;
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(703, 14);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 8;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // firma_ticket
            // 
            this.firma_ticket.BackColor = System.Drawing.Color.Yellow;
            this.firma_ticket.Location = new System.Drawing.Point(480, 282);
            this.firma_ticket.Name = "firma_ticket";
            this.firma_ticket.Size = new System.Drawing.Size(64, 28);
            this.firma_ticket.TabIndex = 7;
            this.firma_ticket.Text = "Bilet Ara";
            this.firma_ticket.UseVisualStyleBackColor = false;
            this.firma_ticket.Click += new System.EventHandler(this.firma_ticket_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(311, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "Firma Giriş";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button2.Location = new System.Drawing.Point(367, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Giriş Yap ->";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Şifre";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(282, 245);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(261, 20);
            this.textBox3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kullanıcı Adı";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(282, 199);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(261, 20);
            this.textBox4.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(333, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 37);
            this.label7.TabIndex = 5;
            this.label7.Text = "Bilet Al";
            // 
            // startPosComboBox
            // 
            this.startPosComboBox.FormattingEnabled = true;
            this.startPosComboBox.Items.AddRange(new object[] {
            "İstanbul",
            "Kocaeli",
            "Bilecik",
            "Ankara",
            "Eskişehir",
            "Konya"});
            this.startPosComboBox.Location = new System.Drawing.Point(194, 205);
            this.startPosComboBox.Name = "startPosComboBox";
            this.startPosComboBox.Size = new System.Drawing.Size(187, 21);
            this.startPosComboBox.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(211, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Başlangıç Noktası";
            // 
            // user_panel
            // 
            this.user_panel.Controls.Add(this.label12);
            this.user_panel.Controls.Add(this.passangerCounterNum);
            this.user_panel.Controls.Add(this.tripSearchButton);
            this.user_panel.Controls.Add(this.label11);
            this.user_panel.Controls.Add(this.vehicleTypeComboBox);
            this.user_panel.Controls.Add(this.label10);
            this.user_panel.Controls.Add(this.dateComboBox);
            this.user_panel.Controls.Add(this.label8);
            this.user_panel.Controls.Add(this.endPosComboBox);
            this.user_panel.Controls.Add(this.label9);
            this.user_panel.Controls.Add(this.startPosComboBox);
            this.user_panel.Controls.Add(this.label7);
            this.user_panel.Location = new System.Drawing.Point(28, 30);
            this.user_panel.Name = "user_panel";
            this.user_panel.Size = new System.Drawing.Size(842, 513);
            this.user_panel.TabIndex = 7;
            this.user_panel.Visible = false;
            // 
            // tripSearchButton
            // 
            this.tripSearchButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tripSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tripSearchButton.Location = new System.Drawing.Point(610, 274);
            this.tripSearchButton.Name = "tripSearchButton";
            this.tripSearchButton.Size = new System.Drawing.Size(101, 34);
            this.tripSearchButton.TabIndex = 18;
            this.tripSearchButton.Text = "Sefer Ara";
            this.tripSearchButton.UseVisualStyleBackColor = false;
            this.tripSearchButton.Click += new System.EventHandler(this.tripSearchButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(462, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Araç Tipi";
            // 
            // vehicleTypeComboBox
            // 
            this.vehicleTypeComboBox.FormattingEnabled = true;
            this.vehicleTypeComboBox.Items.AddRange(new object[] {
            "Uçak",
            "Otobüs",
            "Tren",
            "Herhangi Biri"});
            this.vehicleTypeComboBox.Location = new System.Drawing.Point(402, 281);
            this.vehicleTypeComboBox.Name = "vehicleTypeComboBox";
            this.vehicleTypeComboBox.Size = new System.Drawing.Size(187, 21);
            this.vehicleTypeComboBox.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(267, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Tarih";
            // 
            // dateComboBox
            // 
            this.dateComboBox.FormattingEnabled = true;
            this.dateComboBox.Items.AddRange(new object[] {
            "04.12.2023",
            "05.12.2023",
            "06.12.2023",
            "07.12.2023",
            "08.12.2023",
            "09.12.2023",
            "10.12.2023",
            "Herhangi bir tarih"});
            this.dateComboBox.Location = new System.Drawing.Point(194, 282);
            this.dateComboBox.Name = "dateComboBox";
            this.dateComboBox.Size = new System.Drawing.Size(187, 21);
            this.dateComboBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(435, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Varış Noktası";
            // 
            // endPosComboBox
            // 
            this.endPosComboBox.FormattingEnabled = true;
            this.endPosComboBox.Items.AddRange(new object[] {
            "İstanbul",
            "Kocaeli",
            "Bilecik",
            "Ankara",
            "Eskişehir",
            "Konya"});
            this.endPosComboBox.Location = new System.Drawing.Point(402, 205);
            this.endPosComboBox.Name = "endPosComboBox";
            this.endPosComboBox.Size = new System.Drawing.Size(187, 21);
            this.endPosComboBox.TabIndex = 12;
            // 
            // passangerCounterNum
            // 
            this.passangerCounterNum.Location = new System.Drawing.Point(610, 205);
            this.passangerCounterNum.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.passangerCounterNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.passangerCounterNum.Name = "passangerCounterNum";
            this.passangerCounterNum.Size = new System.Drawing.Size(101, 20);
            this.passangerCounterNum.TabIndex = 19;
            this.passangerCounterNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(606, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Yolcu Sayısı";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 587);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.user_panel);
            this.Controls.Add(this.firma_panel);
            this.Controls.Add(this.admin_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasyon Sistemi";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.admin_panel.ResumeLayout(false);
            this.admin_panel.PerformLayout();
            this.firma_panel.ResumeLayout(false);
            this.firma_panel.PerformLayout();
            this.user_panel.ResumeLayout(false);
            this.user_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passangerCounterNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıToolStripMenuItem;
        private System.Windows.Forms.Panel admin_panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox admin_password_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox admin_username_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel firma_panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button admin_ticket;
        private System.Windows.Forms.Button firma_ticket;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox startPosComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel user_panel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox vehicleTypeComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox dateComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox endPosComboBox;
        private System.Windows.Forms.Button tripSearchButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown passangerCounterNum;
    }
}