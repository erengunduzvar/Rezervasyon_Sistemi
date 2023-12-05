namespace Rezervasyon_Sistemi.Forms
{
    partial class PassengerRegister
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
            this.seatNoText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateText = new System.Windows.Forms.DateTimePicker();
            this.FinalizeTicketButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tcNoText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // seatNoText
            // 
            this.seatNoText.BackColor = System.Drawing.SystemColors.Window;
            this.seatNoText.Location = new System.Drawing.Point(178, 32);
            this.seatNoText.Name = "seatNoText";
            this.seatNoText.ReadOnly = true;
            this.seatNoText.Size = new System.Drawing.Size(153, 20);
            this.seatNoText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Koltuk No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adı";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(178, 70);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(153, 20);
            this.nameText.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Soyadı";
            // 
            // surnameText
            // 
            this.surnameText.Location = new System.Drawing.Point(178, 106);
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(153, 20);
            this.surnameText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Doğum Tarihi";
            // 
            // dateText
            // 
            this.dateText.Location = new System.Drawing.Point(178, 176);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(153, 20);
            this.dateText.TabIndex = 11;
            // 
            // FinalizeTicketButton
            // 
            this.FinalizeTicketButton.BackColor = System.Drawing.Color.Chartreuse;
            this.FinalizeTicketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FinalizeTicketButton.Location = new System.Drawing.Point(126, 218);
            this.FinalizeTicketButton.Name = "FinalizeTicketButton";
            this.FinalizeTicketButton.Size = new System.Drawing.Size(94, 43);
            this.FinalizeTicketButton.TabIndex = 12;
            this.FinalizeTicketButton.Text = "İşlemi Tamamla";
            this.FinalizeTicketButton.UseVisualStyleBackColor = false;
            this.FinalizeTicketButton.Click += new System.EventHandler(this.FinalizeTicketButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(26, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tc Kimlik No";
            // 
            // tcNoText
            // 
            this.tcNoText.Location = new System.Drawing.Point(178, 140);
            this.tcNoText.Name = "tcNoText";
            this.tcNoText.Size = new System.Drawing.Size(153, 20);
            this.tcNoText.TabIndex = 13;
            // 
            // PassengerRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 343);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tcNoText);
            this.Controls.Add(this.FinalizeTicketButton);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.surnameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seatNoText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PassengerRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ol";
            this.Load += new System.EventHandler(this.PassengerRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox seatNoText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateText;
        private System.Windows.Forms.Button FinalizeTicketButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tcNoText;
    }
}